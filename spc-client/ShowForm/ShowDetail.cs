using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using spc_client.Model;
using spc_client.Tools;
using spc_client.UserControls;
using spc_client.SqlPar;
using DevExpress.XtraGrid;
using System.Threading;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraLayout;
using System.Reflection;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;

namespace spc_client.ShowForm
{
    public partial class ShowDetail : XtraFormBase
    {
        Rectangle rectFront,rectBack;
        public ShowDetail()
        {
            InitializeComponent();
            gridView_Pcbs.FocusedRowChanged += GridView_Pcbs_FocusedRowChanged;
            gridView_Results.FocusedRowChanged += GridView_Results_FocusedRowChanged;
            gridView_Pcbs.CustomDrawEmptyForeground += GridView_CustomDrawEmptyForeground;
            gridView_Results.CustomDrawEmptyForeground += GridView_CustomDrawEmptyForeground;
            rectFront = rectBack = new Rectangle(-1, -1, 0, 0);
            SetReadOnly(gridView_Pcbs);
            SetReadOnly(gridView_Results);
        }

        void SetReadOnly(GridView gv)
        {
            foreach (GridColumn item in gv.Columns)
            {
                item.OptionsColumn.ReadOnly = true;
                item.OptionsColumn.AllowEdit = false;
                //禁止单元格获取焦点
                item.OptionsColumn.AllowFocus = false;
            }
        }

        private void GridView_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            GridView gridView = sender as GridView;
            if (gridView.RowCount == 0)
            {
                string str = "暂未查找到匹配的数据!";
                Font f = new Font("微软雅黑", 16);
                Rectangle r = new Rectangle(gridView.GridControl.Width / 2 - 100, e.Bounds.Top + 45, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString(str, f, Brushes.Gray, r);

            }
        }

        void DrawCrossLine(bool isBack, Rectangle rect)
        {
            try
            {
                if (isBack)
                {
                    rectBack = ConvertRect(pictureBox_Back, rect);
                    pictureBox_Back.Refresh();
                }
                else
                {
                    rectFront = ConvertRect(pictureBox_Front, rect);
                    pictureBox_Front.Refresh();
                }
            }
            catch (Exception er) { }
        }

        private void ShowResultInfo(RetResults currentRetResult)
        {
            string[] reg = currentRetResult.area.Split(',');
            int x = Convert.ToInt32(double.Parse(reg[0]));
            int y = Convert.ToInt32(double.Parse(reg[1]));
            int w = Convert.ToInt32(double.Parse(reg[2]));
            int h = Convert.ToInt32(double.Parse(reg[3]));
            Rectangle rect = new Rectangle(x, y, w, h);
            DrawCrossLine(Convert.ToBoolean(currentRetResult.is_back), rect);
            MySmartThreadPool.Instance().QueueWorkItem((ap) =>
            {
                try
                {
                    string[] region = currentRetResult.region.Split(',');
                    Rectangle rectRegion = new Rectangle(Convert.ToInt32(double.Parse(region[0])),
                        Convert.ToInt32(double.Parse(region[1])),
                        Convert.ToInt32(double.Parse(region[2])),
                        Convert.ToInt32(double.Parse(region[3])));
                    string file = ap.PathConcatenate(ap.GetBasePath(), ap.part_image_path);
                    if (File.Exists(file))
                    {
                        Image image = Image.FromFile(file);
                        {

                            using (Graphics g = Graphics.FromImage(image))
                            {
                                using (Pen pen = new Pen(Color.Red, 3))
                                {
                                    g.DrawRectangle(pen, rectRegion.X, rectRegion.Y, rectRegion.Width, rectRegion.Height);
                                }
                            }
                        }
                        this.BeginInvoke((Action<Image, int, Rectangle>)((img, isback, r2) =>
                        {
                            imageBox_Part.TextDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.None;
                            xtraTabControl1.SelectedTabPageIndex = isback;
                            if (imageBox_Part.Image != null) imageBox_Part.Image.Dispose();
                            imageBox_Part.Image = img;
                            imageBox_Part.CenterAt(new Point(r2.X, r2.Y));
                            imageBox_Part.Invalidate();
                        }), image.Clone(), ap.is_back, rectRegion);
                        image.Dispose();
                    }
                    else
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            if (imageBox_Part.Image != null) imageBox_Part.Image.Dispose();
                            imageBox_Part.TextDisplayMode = Cyotek.Windows.Forms.ImageBoxGridDisplayMode.Client;
                        }));
                    }
                }
                catch(Exception er) { }
            }, currentRetResult);
        }

        private void GridView_Results_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(gridView_Results.GetFocusedRow()!=null)
            ShowResultInfo(gridView_Results.GetFocusedRow() as RetResults);
        }

        private void GridView_Pcbs_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            AoiPcbs currentPcb = gridView_Pcbs.GetFocusedRow() as AoiPcbs;
            if (currentPcb == null) return;
            MySmartThreadPool.Instance().QueueWorkItem((ap) =>
            {
                SplashScreenManager sp = new SplashScreenManager(this, typeof(global::spc_client.MyWaitForm), true, true);
                sp.ShowWaitForm();
                SpcModel spcModel = DB.Instance();
                try
                {
                    MySmartThreadPool.Instance().QueueWorkItem((f1, f2) =>
                    {
                        bool f1IsExist, f2IsExist;
                        f1IsExist = File.Exists(f1) ? true : false;
                        f2IsExist = File.Exists(f2) ? true : false;

                        this.BeginInvoke((Action<bool, bool>)((a1, a2) =>
                        {
                            pictureBox_Front.Image = null;
                            pictureBox_Back.Image = null;
                            if (a1) pictureBox_Front.Load(f1);
                            else
                            {
                                pictureBox_Front.LoadAsync("showErrImg");
                            }
                            if (a2) pictureBox_Back.Load(f2);
                            else
                            {
                                pictureBox_Back.LoadAsync("showErrImg");
                            }
                        }), f1IsExist, f2IsExist);
                    }, ap.PathConcatenate(ap.GetBasePath(), "front.jpg"),
                    ap.PathConcatenate(ap.GetBasePath(), "back.jpg"));
                    //this.BeginInvoke((Action)(() =>
                    //{

                    //}));


                    List<RetResults> retResults = spcModel.Database.SqlQuery<RetResults>(String.Format("SELECT is_back,score,area,region,ng_str, (SELECT ng_str FROM aoi_ng_types WHERE id = ss.result_ng_type_id) as result_ng_str,result_ng_type_id, ng_type_id, result_ng_type_id != '' as NG,pc_ip,pcb_path,part_image_path, pcb_id FROM (SELECT * FROM aoi_results WHERE aoi_results.pcb_id = '{0}') as ss LEFT JOIN aoi_pcbs ON ss.pcb_id = aoi_pcbs.id LEFT JOIN aoi_softwares ON aoi_pcbs.software_id = aoi_softwares.id LEFT JOIN aoi_ng_types ON aoi_ng_types.id = ss.ng_type_id LEFT JOIN aoi_pcs ON aoi_pcs.id = aoi_softwares.pc_id", ap.id)).ToList();
                    foreach(RetResults r in retResults)
                    {
                        r.NG = r.NG == "1" ? "NG" : "OK";
                    }
                    this.BeginInvoke((Action)(() =>
                    {
                        gridControl_Results.DataSource = retResults;
                        //gridView_Pcbs.FocusedRowHandle = 0;
                        //gridView_Results.FocusedRowHandle = 0;
                        //gridControl_Results.Focus();
                    }));
                    if (retResults.Count > 0)
                    {
                        MySmartThreadPool.Instance().QueueWorkItem((a) =>
                        {
                            this.BeginInvoke((Action)(() =>
                            {
                                ShowResultInfo(retResults[0]);
                            }));

                        }, retResults[0]);
                    }
                }
                catch (Exception er)
                {
                    //LogHelper.WriteLog(er.Message);
                }
                finally
                {
                    sp.CloseWaitForm();
                    spcModel.Dispose();
                }
            }, currentPcb);
        }
        void ReSetInfo()
        {
            pictureBox_Front.Image = null;
            pictureBox_Back.Image = null;
            gridControl_Pcbs.DataSource = null;
            gridControl_Results.DataSource = null;
        }
        public override void Export()
        {
            ShowDetailNew showDetailNew = new ShowDetailNew();
            showDetailNew.Export();
            showDetailNew.Dispose();
        }
        public override void QueryReset()
        {
            ReSetInfo();
           
            if(QueryPars.enableResult)
            {
                //string aa = gridView_Results.ActiveFilterString;
                gridView_Results.ActiveFilterString = String.Format("[ng_str] = '{0}'", QueryPars.ng_type);
            }

            MySmartThreadPool.Instance().QueueWorkItem(() =>
            {
                if (!splashScreenManager.IsSplashFormVisible) splashScreenManager.ShowWaitForm();
                SpcModel spcModel = DB.Instance();
                try
                {
                    List<AoiPcbs> aoiPcbs = spcModel.pcbs.SqlQuery(QueryPars.GetPcbsQueryStr()).ToList();
                    this.BeginInvoke((Action)(() =>
                    {
                        gridControl_Pcbs.DataSource = aoiPcbs;
                    }));
                }
                catch (Exception er)
                {

                }
                finally
                {
                    if (splashScreenManager.IsSplashFormVisible) splashScreenManager.CloseWaitForm();
                    spcModel.Dispose();
                }
            });
        }

        /// <summary>
        /// 转换图像原始坐标在控件zoom情况下的位置
        /// </summary>
        /// <param name="point"></param>
        Rectangle ConvertRect(PictureBox pictureBox, Rectangle originalRect)
        {
            if (pictureBox.Image == null) return new Rectangle(-1, -1, 0, 0);
            int originalWidth = pictureBox.Image.Width;
            int originalHeight = pictureBox.Image.Height;

            PropertyInfo rectangleProperty = pictureBox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
            Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(pictureBox, null);

            int currentWidth = rectangle.Width;
            int currentHeight = rectangle.Height;

            double rate = (double)currentHeight / (double)originalHeight;

            int black_left_width = (currentWidth == pictureBox.Width) ? 0 : (pictureBox.Width - currentWidth) / 2;
            int black_top_height = (currentHeight == pictureBox.Height) ? 0 : (pictureBox.Height - currentHeight) / 2;

            //int zoom_x = point.X - black_left_width;
            //int zoom_y = point.Y - black_top_height;

            //double original_x = (double)zoom_x / rate;
            //double original_y = (double)zoom_y / rate;

            StringBuilder sb = new StringBuilder();

            //sb.AppendFormat("原始尺寸{0}/{1}(宽/高)\r\n", originalWidth, originalHeight);
            //sb.AppendFormat("缩放状态图片尺寸{0}/{1}(宽/高)\r\n", currentWidth, currentHeight);
            //sb.AppendFormat("缩放比率{0}\r\n", rate);
            //sb.AppendFormat("左留白宽度{0}\r\n", black_left_width);
            //sb.AppendFormat("上留白高度{0}\r\n", black_top_height);
            //sb.AppendFormat("当前鼠标坐标{0}/{1}(X/Y)\r\n", point.X, point.Y);
            //sb.AppendFormat("缩放图中鼠标坐标{0}/{1}(X/Y)\r\n", zoom_x, zoom_y);
            //sb.AppendFormat("原始图中鼠标坐标{0}/{1}(X/Y)\r\n", original_x, original_y);
            int x = Convert.ToInt32(originalRect.X * rate) + black_left_width;
            int y = Convert.ToInt32(originalRect.Y * rate) + black_top_height;
            int w = Convert.ToInt32(originalRect.Width * rate);
            int h = Convert.ToInt32(originalRect.Height * rate);
            Rectangle retRect = new Rectangle(x, y, w, h);
            return retRect;
            //this.label1.Text = sb.ToString();
        }

        private void pictureBox_Front_Paint(object sender, PaintEventArgs e)
        {
            Pen newPen = new Pen(Color.Yellow, 2);//定义一个画笔，黄色
            //pictureBox_Front.Update();//这句话相当关键  会是消除之前画的图 速度加快
            e.Graphics.DrawLine(newPen, new Point(rectFront.X, 0), new Point(rectFront.X, pictureBox_Front.Height));
            e.Graphics.DrawLine(newPen, new Point(0, rectFront.Y), new Point(pictureBox_Front.Width, rectFront.Y));
        }

        private void pictureBox_Back_Paint(object sender, PaintEventArgs e)
        {
            //pictureBox_Back.Refresh();
            Pen newPen = new Pen(Color.Yellow, 2);//定义一个画笔，黄色
            //pictureBox_Back.Update();//这句话相当关键  会是消除之前画的图 速度加快
            e.Graphics.DrawLine(newPen, new Point(rectBack.X, 0), new Point(rectBack.X, pictureBox_Back.Height));
            e.Graphics.DrawLine(newPen, new Point(0, rectBack.Y), new Point(pictureBox_Back.Width, rectBack.Y));
        }
    }
}