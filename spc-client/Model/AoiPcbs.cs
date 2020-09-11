using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace spc_client.Model
{
    [Table(name: "aoi_pcbs")]
    public class AoiPcbs
    {
        [Description("主键")]
        [Key]
        [Column(name: "id", TypeName = "varchar")]
        [StringLength(50)]
        public string id { get; set; }
        //[Column(name: "software_id", TypeName = "varchar")]
        //[StringLength(50)]
        //public string SoftwareId { get; set; }
        [Column(name: "pcb_number")]
        [StringLength(250)]
        [Description("板号")]
        public string pcb_number { get; set; }

        [Column(name: "pcb_name")]
        [StringLength(250)]
        [Description("PCB名称")]
        public string pcb_name { get; set; }

        [Column(name: "carrier_width")]
        [Description("载板长")]
        public int carrier_width { get; set; }

        [Column(name: "carrier_height")]
        [Description("载板宽")]
        public int carrier_height { get; set; }

        [Column(name: "pcb_width")]
        [Description("PCB名称")]
        public int pcb_width { get; set; }

        [Column(name: "pcb_height")]
        [Description("PCB名称")]
        public int pcb_height { get; set; }

        [Column(name: "pcb_childen_number")]
        [Description("PCB名称")]
        public int pcb_childen_number { get; set; }

        [Column(name: "pcb_path")]
        [StringLength(250)]
        [Description("对应的FTP保存的地址")]
        public string pcb_path { get; set; }

        [Column(name: "ng_count")]
        [Description("ng计数")]
        public int ng_count { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_misjudge")]
        [Description("是否误判, 0否 1是, 只要results下有一个误判，那该值就改为1")]
        public int is_misjudge { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_error")]
        [Description("是否报错, 0否 1是")]
        public int is_error { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime create_time { get; set; }

        public string pc_ip { get; set; }
        public string software_name { get; set; }
        public List<AoiResults> results { get; set; }

        public string PathConcatenate(string s1, string s2)
        {
            if (s1.EndsWith("\\")) s1 = s1.Substring(0, s1.Length - 1);
            if (!s2.StartsWith("\\")) s2 = "\\" + s2;
            return String.Format("{0}{1}", s1, s2);
        }
        public string GetBasePath()
        {
            if (!pcb_path.StartsWith("\\")) pcb_path += "\\";
            return String.Format("\\\\{0}{1}", pc_ip, pcb_path);
        }
        //public List<Marker> markers { get; set; }
    }
}

