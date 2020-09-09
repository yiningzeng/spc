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
    [Table(name: "aoi_ng_types")]
    public class AoiNgTypes
    {
        [Description("主键")]
        [Key]
        [Column(name: "id", TypeName = "varchar")]
        public string id { get; set; }

        [Column(name: "ng_str")]
        [Description("缺陷类型")]
        public string ng_str { get; set; }

        [Column(name: "software_id")]
        [Description("程序Id")]
        [StringLength(250)]
        public string software_id { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime create_time { get; set; }
    }
}
