using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace spc_client.Model
{
    [Table(name: "aoi_pcbs")]
    public class AoiPcbs
    {
        [Description("主键")]
        [Key]
        [Column(name: "id", TypeName = "varchar")]
        [StringLength(50)]
        [JsonProperty("Id")]
        public string id { get; set; }

        [Column(name: "software_id", TypeName = "varchar")]
        [StringLength(50)]
        public string software_id { get; set; }

        [Column(name: "pcb_number")]
        [StringLength(250)]
        [Description("板号")]
        public string pcb_number { get; set; }

        [Column(name: "pcb_name")]
        [StringLength(250)]
        [Description("PCB名称")]
        [JsonProperty("PcbName")]
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

        [Column(name: "pcb_part_number")]
        [Description("PCB元件数")]
        public int pcb_part_number { get; set; }

        [Column(name: "pcb_childen_number")]
        [Description("PCB名称")]
        [JsonProperty("PcbChildenNumber")]
        public int pcb_childen_number { get; set; }

        [Column(name: "pcb_path")]
        [StringLength(250)]
        [Description("对应的FTP保存的地址")]
        [JsonProperty("PcbPath")]
        public string pcb_path { get; set; }

        [Column(name: "ng_count_ai")]
        [Description("ai_ng计数")]
        public int ng_count_ai { get; set; }

        [Column(name: "ng_count_2d")]
        [Description("2d_ng计数")]
        public int ng_count_2d { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_misjudge_2d")]
        [Description("判断结果 , 0表示NG, 1表示OK")]
        public int is_misjudge_2d { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_misjudge_ai")]
        [Description("判断结果 , 0表示ng， 1表示nng(包含判错和误判), 2表示ok")]
        public int is_misjudge_ai { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_error")]
        [Description("是否报错, 0否 1是")]
        public int is_error { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        [JsonProperty("CreateTime")]
        public DateTime create_time { get; set; }

        //[NotMapped]
        public string pc_ip { get; set; }
        //[NotMapped]
        public string software_name { get; set; }
        //[NotMapped]
        public List<AoiResults> results { get; set; }
        //[NotMapped]
        public List<Aoi2DResults> results_2d { get; set; }
        
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

