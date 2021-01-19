using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spc_client.SqlPar
{
    class RetStatistical
    {
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
