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
    [Table(name: "aoi_pcs")]
    public class AoiPcs
    {
        [Description("主键")]
        [Key]
        [Column(name: "id", TypeName = "varchar")]
        public string id { get; set; }

        [Column(name: "pc_name")]
        [Description("主机名")]
        public string pc_name { get; set; }

        [Column(name: "pc_ip")]
        [Description("主机Ip")]
        [StringLength(250)]
        public string pc_ip { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime create_time { get; set; }
    }
}
