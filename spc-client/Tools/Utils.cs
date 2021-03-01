﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spc_client.Tools
{
    public class Utils
    {
        /// <summary>
        /// 主要用于判断是否是当月，如果是当月那么返回不加前缀的表名
        /// </summary>
        /// <param name="time"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string GetFinalDateTimeSuffix(DateTime time)
        {
            if (time.Month == DateTime.Now.Month && time.Year == DateTime.Now.Year) // 开始时间是否是当月
            {
                return "";
            }
            else
            {
                return String.Format("_{0}", time.ToString("yyyy_MM"));
            }
        }
        /// <summary>
        /// 主要用于判断是否是当月，如果是当月那么返回不加前缀的表名
        /// </summary>
        /// <param name="time"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static string GetFinalTableName(DateTime time, string prefix)
        {
            if (time.Month == DateTime.Now.Month && time.Year == DateTime.Now.Year) // 开始时间是否是当月
            {
                return prefix;
            }
            else
            {
                return String.Format("{0}_{1}", prefix, time.ToString("yyyy_MM"));
            }
        }
        /// <summary>
        /// 获取两个时间之间的所有分表，如果是当月的话那么就不会加时间后缀
        /// </summary>
        /// <param name="startDateTime">开始时间</param>
        /// <param name="endDateTime">结束时间</param>
        /// <param name="prefix">表名前缀</param>
        /// <returns></returns>
        public static List<string> GetQueryTables(DateTime startDateTime, DateTime endDateTime, string prefix)
        {
            List<string> res = new List<string>();
            res.Add(GetFinalTableName(startDateTime, prefix));

            DateTime tempStartDt = DateTime.Parse(startDateTime.ToString("yyyy-MM"));
            DateTime tempEndDt = DateTime.Parse(endDateTime.ToString("yyyy-MM"));
            while (true)
            {
                tempStartDt = DateTime.Parse(tempStartDt.AddMonths(1).ToString("yyyy-MM"));
                if (tempStartDt <= tempEndDt) // 开始时间加了一个月比结束时间还-*小，加一个
                {
                    res.Add(GetFinalTableName(tempStartDt, prefix));
                    // 这里加完就可以退出了！因为大于当月的其他月份的是完全不存在的
                    if (tempStartDt.Month >= DateTime.Now.Month && tempStartDt.Year == DateTime.Now.Year) break;
                }
                else break;
            }
            return res;
        }

        /// <summary>
        /// 主要用于单表的查询等,获取两个时间之间的所有分表的查询语句，如果是当月的话那么就不会加时间后缀
        /// </summary>
        /// <param name="sql">基本的查询语句，带需要替换表名的查询语句</param>
        /// <param name="startDateTime">开始时间</param>
        /// <param name="endDateTime">结束时间</param>
        /// <param name="prefix">表名前缀</param>
        /// <returns></returns>
        public static List<string> GetQueryStrs(string sql, DateTime startDateTime, DateTime endDateTime, string prefix)
        {
            List<string> res = new List<string>();
            res.Add(String.Format(sql, GetFinalTableName(startDateTime, prefix)));

            DateTime tempStartDt = DateTime.Parse(startDateTime.ToString("yyyy-MM"));
            DateTime tempEndDt = DateTime.Parse(endDateTime.ToString("yyyy-MM"));
            while (true)
            {
                tempStartDt = DateTime.Parse(tempStartDt.AddMonths(1).ToString("yyyy-MM"));
                if (tempStartDt <= tempEndDt) // 开始时间加了一个月比结束时间还-*小，加一个
                {
                    res.Add(String.Format(sql, GetFinalTableName(tempStartDt, prefix)));
                    // 这里加完就可以退出了！因为大于当月的其他月份的是完全不存在的
                    if (tempStartDt.Month >= DateTime.Now.Month && tempStartDt.Year == DateTime.Now.Year) break;
                }
                else break;
            }
            return res;
        }

        /// <summary>
        /// 主要用于查询语句中存在多张日期表的查询等,获取两个时间之间的所有分表的查询语句，如果是当月的话那么就不会加时间后缀
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="startDateTime"></param>
        /// <param name="endDateTime"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public static List<string> GetQueryStrsOnlyReplaceDate(string sql, DateTime startDateTime, DateTime endDateTime)
        {
            List<string> res = new List<string>();
            res.Add(String.Format(sql, GetFinalDateTimeSuffix(startDateTime)));

            DateTime tempStartDt = DateTime.Parse(startDateTime.ToString("yyyy-MM"));
            DateTime tempEndDt = DateTime.Parse(endDateTime.ToString("yyyy-MM"));
            while (true)
            {
                tempStartDt = DateTime.Parse(tempStartDt.AddMonths(1).ToString("yyyy-MM"));
                if (tempStartDt <= tempEndDt) // 开始时间加了一个月比结束时间还-*小，加一个
                {
                    res.Add(String.Format(sql, GetFinalDateTimeSuffix(tempStartDt)));
                    // 这里加完就可以退出了！因为大于当月的其他月份的是完全不存在的
                    if (tempStartDt.Month >= DateTime.Now.Month && tempStartDt.Year == DateTime.Now.Year) break;
                }
                else break;
            }
            return res;
        }

        public static int[] Sort(int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// 处理Double值，精确到小数点后几位
        /// </summary>
        /// <param name="_value">值</param>
        /// <param name="Length">精确到小数点后几位</param>
        /// <returns>返回值</returns>
        public static double ManagerDoubleValue(double _value, int Length)
        {
            if (Length < 0)
            {
                Length = 0;
            }
            return System.Math.Round(_value, Length);
        }

        /// <summary>
        /// 获取指定驱动器的剩余空间总大小(单位为B)
        /// </summary>
        /// <param name="str_HardDiskName">只需输入代表驱动器的字母即可 </param>
        /// <returns> </returns>
        public static long GetHardDiskFreeSpace(string str_HardDiskName)
        {
            long freeSpace = new long();
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    freeSpace = drive.TotalFreeSpace / 1073741824;
                }
            }
            return freeSpace;
        }

        /// <summary>
        /// MD5字符串加密
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>加密后字符串</returns>
        public static string GenerateMD5(string txt)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(txt);
                //开始加密
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// 缺陷画框行数
        /// </summary>
        /// <param name="bitmap">原始bitmap</param>
        /// <param name="rect">Rectangle</param>
        /// <param name="ngType">缺陷类型</param>
        /// <returns></returns>
        public static Bitmap DrawRect(Bitmap bitmap, Rectangle rect, string ngType)
        {
            Graphics ghFront = Graphics.FromImage(bitmap);
            ghFront.DrawString(ngType, new Font("宋体", 10, FontStyle.Bold), Brushes.Red, rect.X, rect.Y - 15);
            ghFront.DrawRectangle(
                new Pen(Color.Red, 3),
                rect);
            return bitmap;
        }

        /// <summary>
        /// 缺陷画框行数
        /// </summary>
        /// <param name="bitmap">原始bitmap</param>
        /// <param name="rect">Rectangle</param>
        /// <param name="ngType">缺陷类型</param>
        /// <returns></returns>
        public static Bitmap DrawLine(Bitmap aa, Rectangle rect)
        {
            Bitmap bitmap = aa.Clone(new Rectangle(0, 0, aa.Width, aa.Height), aa.PixelFormat);
            Graphics ghFront = Graphics.FromImage(bitmap);
            Pen newPen = new Pen(Color.Yellow, 50);//定义一个画笔，黄色
            ghFront.DrawLine(newPen, new Point(rect.X, 0), new Point(rect.X, bitmap.Height));
            ghFront.DrawLine(newPen, new Point(0, rect.Y), new Point(bitmap.Width, rect.Y));
            return bitmap;
        }
        /// <summary>  
        /// 剪裁 -- 用GDI+   
        /// </summary>  
        /// <param name="b">原始Bitmap</param>  
        /// <param name="edge">需要增加的边沿像素</param>  
        /// <returns>剪裁后的Bitmap</returns>  
        public static Bitmap BitmapCut(Bitmap b, Rectangle rect, int edge)
        {
            int StartX = rect.X, StartY = rect.Y, iWidth = rect.Width, iHeight = rect.Height;
            if (b == null)
            {
                return null;
            }
            //int w = b.Width;
            //int h = b.Height;
            //if (StartX >= w || StartY >= h)
            //{
            //    return null;
            //}
            //if (StartX + iWidth > w)
            //{
            //    iWidth = w - StartX;
            //}
            //if (StartY + iHeight > h)
            //{
            //    iHeight = h - StartY;
            //}
            try
            {
                Bitmap b1 = new Bitmap(b.Width + edge, b.Height + edge); //新建bai位图dub1
                Graphics g1 = Graphics.FromImage(b1); //创建b1的Graphics
                g1.FillRectangle(Brushes.Black, new Rectangle(0, 0, b1.Width, b1.Height)); //把b1涂成红色
                g1.DrawImage(b, edge / 2, edge / 2, b.Width, b.Height);
                g1.Dispose();


                Bitmap bmpOut = new Bitmap(iWidth, iHeight, PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(bmpOut);
                g.DrawImage(b1, new Rectangle(0, 0, iWidth, iHeight), new Rectangle(StartX + edge / 2, StartY + edge / 2, iWidth, iHeight), GraphicsUnit.Pixel);

                g.Dispose();
                b.Dispose();
                b1.Dispose();
                return bmpOut;
            }
            catch
            {
                return null;
            }
        }
    }
}

