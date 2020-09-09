using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spc_client.SqlPar
{
    public static class QueryPars
    {
        public static DateTime startTime { get; set; }
        public static DateTime endTime { get; set; }

        public static bool enablePcbNumber { get; set; }
        public static string pcbNumber { get; set; }
   
        public static bool enableSoftware { get; set; } //true那么下面的参数生效
        public static string softwareId { get; set; } // 这里关联单面双面和缺陷的名称表
        public static bool enableResult { get; set; }
        public static string resultId { get; set; } //对应的缺陷id， 因为name能存在修改的原因造成后续查询出问题 如果= -1那么就查询所有

        public static string GetPcbsQueryStr()
        {
            string queryStr = String.Format("SELECT * FROM aoi_pcbs WHERE aoi_pcbs.create_time BETWEEN '{0}' AND '{1}'",
                startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                 endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            if (enableResult)
            { //这里上面语句都要改成join
                //queryStr += " AND aoi_pcbs.pcb_number LIKE '%" + pcbNumber + "%'";
            }
            if (enablePcbNumber)
            {
                queryStr += " AND aoi_pcbs.pcb_number LIKE '%" + pcbNumber + "%'";
            }
            if (enableSoftware)
            {
                queryStr += " AND aoi_pcbs.software_id = " + softwareId;
            }
            return String.Format("SELECT * FROM ({0}) ap " +
                "LEFT JOIN (SELECT * from (SELECT id as software_id,  pc_id FROM aoi_softwares) temp " +
                "LEFT JOIN aoi_pcs ON temp.pc_id = aoi_pcs.id) t2 ON ap.software_id = t2.software_id", queryStr);
        }
    }
}
