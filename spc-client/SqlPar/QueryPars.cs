﻿using System;
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
        public static bool enableResult { get; set; } // 根据结果检索
        public static string resultId { get; set; } //对应的缺陷id， 因为name能存在修改的原因造成后续查询出问题 如果= -1那么就查询所有
        public static string ng_type { get; set; }
        public static string GetPcbsQueryStr()
        {
            string queryStr = String.Format("SELECT * FROM {{0}} WHERE create_time BETWEEN '{0}' AND '{1}'",
                startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                 endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            if (enableResult)
            { //这里上面语句都要改成join
                //queryStr += " AND aoi_pcbs.pcb_number LIKE '%" + pcbNumber + "%'";
            }
            if (enablePcbNumber)
            {
                queryStr += " AND pcb_number LIKE '%" + pcbNumber + "%'";
            }
            if (enableSoftware)
            {
                queryStr += " AND software_id = " + softwareId;
            }
            return String.Format("SELECT * FROM ({0}) ap " +
                "LEFT JOIN (SELECT * from (SELECT id as software_id, software_name, pc_id FROM aoi_softwares) temp " +
                "LEFT JOIN aoi_pcs ON temp.pc_id = aoi_pcs.id) t2 ON ap.software_id = t2.software_id", queryStr);
        }
        public static string GetAllInfoQueryStr()
        {
            string queryStr = String.Format("SELECT *, FORMAT(score,2) AS score_final FROM all_info_pcbs WHERE all_info_pcbs.create_time BETWEEN '{0}' AND '{1}'",
                startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                 endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            if (enableResult)
            { //这里上面语句都要改成join
                //queryStr += " AND aoi_pcbs.pcb_number LIKE '%" + pcbNumber + "%'";
            }
            if (enablePcbNumber)
            {
                queryStr += " AND all_info_pcbs.pcb_number LIKE '%" + pcbNumber + "%'";
            }
            if (enableSoftware)
            {
                queryStr += " AND all_info_pcbs.software_id = " + softwareId;
            }
            return queryStr + " ORDER BY create_time DESC";
            //return String.Format("SELECT * FROM ({0}) ap " +
            //    "LEFT JOIN (SELECT * from (SELECT id as software_id, software_name, pc_id FROM aoi_softwares) temp " +
            //    "LEFT JOIN aoi_pcs ON temp.pc_id = aoi_pcs.id) t2 ON ap.software_id = t2.software_id", queryStr);
        }

        public static string GetMainStatisticalStr()
        {
            string queryStr = String.Format("SELECT DISTINCT" +
                                            "	software_id," +
                                            "   pc_name," +
                                            "	pc_id," +
                                            "	software_name," +
                                            "	( SELECT COUNT( * ) FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id AND create_time BETWEEN '{0}' AND '{1}') AS 'count_pcb'," +
                                            "	( SELECT SUM( is_error = 1 ) FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id  AND create_time BETWEEN '{0}' AND '{1}') AS 'count_error_pcb'," +
                                            "	( SELECT SUM( is_misjudge = 1 ) FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id  AND create_time BETWEEN '{0}' AND '{1}') AS 'count_warning_pcb'," +
                                            "	( SELECT SUM( is_error = 0 ) FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id  AND create_time BETWEEN '{0}' AND '{1}') AS 'count_good_pcb'," +
                                            "	( SELECT SUM( is_misjudge = 1 ) / COUNT( * ) FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id  AND create_time BETWEEN '{0}' AND '{1}') AS 'pcb_ppm'," +
                                            "	( SELECT concat(truncate(SUM( is_error = 1 ) / COUNT( * ) * 100,2),'%') FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id  AND create_time BETWEEN '{0}' AND '{1}') AS 'defect_rate'," +
                                            "	( SELECT concat(truncate(SUM( is_error = 0 ) / COUNT( * ) * 100,2),'%') FROM aoi_pcbs WHERE software_id = pcs_softwares_pcbs_view.software_id  AND create_time BETWEEN '{0}' AND '{1}') AS 'pass_rate' " +
                                            "FROM" +
                                            "   pcs_softwares_pcbs_view " +
                                            "WHERE" +
                                            "	create_time BETWEEN '{0}' AND '{1}' " +
                                            "ORDER BY" +
                                            "	software_id",
                startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                 endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            return queryStr;
        }


        /// <summary>
        /// 单个月份的统计查询语句
        /// </summary>
        /// <param name="dateSuffix"></param>
        /// <returns></returns>
        public static string GetMainStatisticalStrV2(string dateSuffix)
        {
            string whereStr = String.Format(" WHERE software_id = `aoi_softwares`.`id` AND create_time BETWEEN '{0}' AND '{1}'",
                startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                 endTime.ToString("yyyy-MM-dd HH:mm:ss"));

            string queryStr = String.Format("SELECT DISTINCT" +
                                            "	`{0}`.`id` AS `pcb_id`," +
                                            "	`aoi_pcs`.`id` AS `pc_id`," +
                                            "	`aoi_pcs`.`pc_name` AS `pc_name`," +
                                            "	`aoi_pcs`.`pc_ip` AS `pc_ip`," +
                                            "	`aoi_softwares`.`software_name` AS `software_name`," +
                                            "	`aoi_softwares`.`side_number` AS `side_number`," +
                                            "	`{0}`.`pcb_number` AS `pcb_number`," +
                                            "	`{0}`.`pcb_name` AS `pcb_name`," +
                                            "	`{0}`.`carrier_width` AS `carrier_width`," +
                                            "	`{0}`.`carrier_height` AS `carrier_height`," +
                                            "	`{0}`.`pcb_width` AS `pcb_width`," +
                                            "	`{0}`.`pcb_height` AS `pcb_height`," +
                                            "	`{0}`.`pcb_childen_number` AS `pcb_childen_number`," +
                                            "	`{0}`.`pcb_path` AS `pcb_path`," +
                                            "	`{0}`.`ng_count` AS `ng_count`," +
                                            "	`{0}`.`is_misjudge` AS `is_misjudge`," +
                                            "	`{0}`.`is_error` AS `is_error`," +
                                            "	`{0}`.`create_time` AS `create_time`," +
                                            "	`aoi_softwares`.`id` AS `software_id`," +
                                            "	( SELECT COUNT( * ) FROM `{0}` {3}) AS 'count_pcb'," +
                                            "	( SELECT SUM( is_error = 1 ) FROM `{0}` {3}) AS 'count_error_pcb'," +
                                            "	( SELECT SUM( is_misjudge = 1 ) FROM `{0}` {3}) AS 'count_warning_pcb'," +
                                            "	( SELECT SUM( is_error = 0 ) FROM `{0}` {3}) AS 'count_good_pcb' " +
                                            " FROM" +
                                            "	(" +
                                            "	( `aoi_softwares` JOIN `{0}` ON ( `{0}`.`software_id` = `aoi_softwares`.`id` ) )" +
                                            "	JOIN `aoi_pcs` ON ( `aoi_softwares`.`pc_id` = `aoi_pcs`.`id` ) " +
                                            "	)" +
                                            " WHERE {0}.create_time BETWEEN '{1}' AND '{2}'",
                                             
                                            "aoi_pcbs" + dateSuffix,
                                            startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            endTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            whereStr);
            return queryStr;
        }
    }
}
