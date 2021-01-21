using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spc_client.SqlPar
{
    public class RetAllInfoPcbs
    {
        public string software_id { get; set; }
        public string pc_id { get; set; }
        public string pc_name { get; set; }
        public string software_name { get; set; }

        public string pcb_number { get; set; }
        public string pcb_name { get; set; }
        public int pcb_childen_number { get; set; }
        public int ng_count { get; set; }
        //is_back,score,area,region,ng_str,result_string,pc_ip,pcb_path,part_image_path, pcb_id
        public int? is_back { get; set; }
        public float? score { get; set; }
        //int PassPcbNums = "(select count(*) from pcbs where is_misjudge = 0 and is_error = 0)";
        public string area { get; set; }
        public string region { get; set; }
        public string ng_str { get; set; }
        public string result_ng_str { get; set; }
        public string result_ng_type_id { get; set; }
        public string ng_type_id { get; set; }
        public string NG { get; set; }
        public string pc_ip { get; set; }
        public string pcb_path { get; set; }
        public string part_image_path { get; set; }
        public string pcb_id { get; set; }
        public DateTime create_time { get; set; }

        public string PathConcatenate(string s1, string s2)
        {
            if (s1.EndsWith("\\")) s1 = s1.Substring(0, s1.Length - 1);
            if (!s2.StartsWith("\\")) s2 = "\\" + s2;
            return String.Format("{0}{1}", s1, s2);
        }
        public string GetBasePath()
        {
            if(pc_ip.Contains("Ftp://"))
            {
                pc_ip = pc_ip.Replace("Ftp://", "").Replace("/", "");
            }
            if (!pcb_path.StartsWith("\\")) pcb_path += "\\";
            return String.Format("\\\\{0}{1}", pc_ip, pcb_path);
        }
    }
}
