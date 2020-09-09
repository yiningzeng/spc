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
    [Table(name: "aoi_user_groups")]
    public class AoiUserGroups
    {
        [Description("主键")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Column(name: "group_name")]
        [Description("组名")]
        public string group_name { get; set; }

        [Column(name: "type")]
        [Description("组类型 0禁止登录 1可以登录")]
        public int type { get; set; }

        [Column(name: "create_time")]
        [Description("创建时间")]
        public DateTime create_time { get; set; }
    }
}
