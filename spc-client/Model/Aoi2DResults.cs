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
    [Table(name: "aoi_results_2d")]
    public class Aoi2DResults
    {
        [Description("主键")]
        [Key]
        [StringLength(50)]
        [Column(name: "id", TypeName = "varchar")]
        public string Id { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_back")]
        [Description("是否反面,0不是，1是")]
        public int IsBack { get; set; }

        [Column(name: "pcb_id", TypeName = "varchar")]
        [StringLength(50)]
        [Description("对应的pcb板id")]
        public string PcbId { get; set; }

        [Column(name: "lot_name", TypeName = "varchar")]
        [StringLength(50)]
        [Description("对应的part料号name")]
        public string LotName { get; set; }

        [Column(name: "part_name", TypeName = "varchar")]
        [StringLength(50)]
        [Description("对应的part元件name")]
        public string PartName { get; set; }

        [DefaultValue(1)]
        [Column(name: "sub_board")]
        [Description("子基板板号")]
        public int SubBoard { get; set; }

        [DefaultValue(0)]
        [Column(name: "angle")]
        [Description("元件角度")]
        public int Angle { get; set; }

        [Column(name: "area", TypeName = "varchar")]
        [StringLength(250)]
        [Description("区域, [0]表示全局大图的x,[1]表示全局大图的y")]
        public string Area { get; set; }

        [Column(name: "ng_type", TypeName = "varchar")]
        [StringLength(100)]
        [Description("Ng种类")]
        public string NgType { get; set; }

        [DefaultValue(0)]
        [Column(name: "is_misjudge")]
        [Description("是否误判, 0否 1是")]
        public int IsMisjudge { get; set; }

        [StringLength(5)]
        [DefaultValue("NG")]
        [Column(name: "result_string", TypeName = "varchar")]
        [Description("人工复验结果")]
        public string ResultString { get; set; }

        [Column(name: "part_image_path", TypeName = "varchar")]
        [StringLength(250)]
        [Description("缺陷的局部图相对于FTP路径的地址")]
        public string PartImagePath { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime CreateTime { get; set; }

        [JsonProperty("ngDetails")]
        public List<Aoi2DResultsDetail> ngDetails;
    }
}
