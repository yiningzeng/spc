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
    [Table(name: "aoi_softwares")]
    public class AoiSoftwares
    {
        [Description("主键")]
        [Key]
        [Column(name: "id", TypeName = "varchar")]
        public string id { get; set; }

        [Column(name: "software_name")]
        [Description("程序名")]
        public string software_name { get; set; }

        [Column(name: "pc_id")]
        [Description("主机id")]
        [StringLength(250)]
        public string pc_id { get; set; }

        [Column(name: "side_number")]
        [Description("单双面 1 单面 2 双面")]
        public int side_number { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime create_time { get; set; }
    }
}
