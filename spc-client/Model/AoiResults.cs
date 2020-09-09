using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace spc_client.Model
{
    [Serializable]
    [Table(name: "aoi_results")]
    public class AoiResults
    {
        [Description("主键")]
        [Key]
        [StringLength(50)]
        [Column(name: "id", TypeName = "varchar")]
        public string id { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_back")]
        [Description("是否反面,0不是，1是")]
        public int is_back { get; set; }

        [DefaultValue(0)]
        [Column(name: "score")]
        [Description("缺陷置信度")]
        public float score { get; set; }

        [Column(name: "pcb_id", TypeName = "varchar")]
        [StringLength(50)]
        [Description("对应的pcb板id")]
        public string pcb_id { get; set; } 

        [Column(name: "area", TypeName = "varchar")]
        [StringLength(250)]
        [Description("区域")]
        public string area { get; set; }

        [Column(name: "region", TypeName = "varchar")]
        [StringLength(50)]
        [Description("范围 坐标")]
        public string region { get; set; }

        [Column(name: "ng_type_id", TypeName = "varchar")]
        [StringLength(50)]
        [Description("Ng种类")]
        public string ng_type_id { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_misjudge")]
        [Description("是否误判, 0否 1是")]
        public int is_misjudge { get; set; }
        
        [DefaultValue("NG")]
        [Column(name: "result_ng_type_id", TypeName = "varchar")]
        [Description("人工复验结果")]
        public string result_ng_type_id { get; set; }

        [Column(name: "part_image_path", TypeName = "varchar")]
        [StringLength(250)]
        [Description("缺陷的局部图相对于FTP路径的地址")]
        public string part_image_path { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime create_time { get; set; }

    }
}

