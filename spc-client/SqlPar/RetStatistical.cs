using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spc_client.SqlPar
{
    class RetStatistical
    {
        #region 2D的数据
        public int part_all_count { get; set; } // 总元件数
        public int sub_ng_count { get; set; } // 错误的子板数目
        public int sub_good_count { get; set; } // 好的的子板数目
        public int sub_all_count { get; set; } // 总的子板数目
        public double ppm_2d { get; set; } // 2d ppm
        public int dppm_2d { get; set; } // 2d dppm 弃用

        public string defect_rate_sub { get; set; } // 子板不良率
        public string pass_rate_sub { get; set; } // 子板直通率
        #endregion

        public string software_id { get; set; }
        public string pc_id { get; set; }
        public string pc_name { get; set; }
        public string software_name { get; set; }
        public int count_pcb { get; set; }
        public int count_error_pcb { get; set; }
        public int count_warning_pcb { get; set; }
        public int count_good_pcb { get; set; }
        public double pcb_ppm { get; set; }
        public string defect_rate { get; set; }
        public string pass_rate { get; set; }
        public DateTime create_time { get; set; }
    }
}
