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
            return String.Format(" SELECT " +
                                "  	*  " +
                                "  FROM " +
                                "  	( " +
                                "  SELECT " +
                                "  	pc_id, " +
                                "  	pc_name, " +
                                "  	pc_ip, " +
                                "  	software_name, " +
                                "  	ap.*  " +
                                "  FROM " +
                                "  	( {0}) ap " +
                                "  	LEFT JOIN ( " +
                                "  SELECT " +
                                "  	*  " +
                                "  FROM " +
                                "  	( SELECT id AS software_id_2, software_name, pc_id FROM aoi_softwares ) temp " +
                                "  	LEFT JOIN aoi_pcs ON temp.pc_id = aoi_pcs.id  " +
                                "  	) t2 ON ap.software_id = t2.software_id_2  " +
                                "  	) aa  " +
                                "  ORDER BY " +
                                "  	create_time DESC ",
                                queryStr);
        }

        public static string GetPcbsQueryStrExport()
        {
            string queryStr = String.Format(" SELECT " +
                                             " aoi_softwares.id AS software_id, " +
                                             " aoi_softwares.software_name AS software_name, " +
                                             " aoi_softwares.pc_id AS pc_id, " +
                                             " aoi_softwares.side_number AS side_number, " +
                                             " aoi_pcbs{{0}}.id AS pcb_id, " +
                                             " aoi_pcbs{{0}}.pcb_number AS pcb_number, " +
                                             " aoi_pcbs{{0}}.pcb_name AS pcb_name, " +
                                             " aoi_pcbs{{0}}.carrier_width AS carrier_width, " +
                                             " aoi_pcbs{{0}}.carrier_height AS carrier_height, " +
                                             " aoi_pcbs{{0}}.pcb_width AS pcb_width, " +
                                             " aoi_pcbs{{0}}.pcb_height AS pcb_height, " +
                                             " aoi_pcbs{{0}}.pcb_childen_number AS pcb_childen_number, " +
                                             " aoi_pcbs{{0}}.pcb_path AS pcb_path, " +
                                             " aoi_pcbs{{0}}.ng_count AS ng_count, " +
                                             " aoi_pcbs{{0}}.is_misjudge AS all_is_misjudge, " +
                                             " aoi_pcbs{{0}}.is_error AS is_error, " +
                                             " aoi_results{{0}}.is_back AS is_back, " +
                                             " aoi_results{{0}}.score AS score, " +
                                             " aoi_results{{0}}.area AS area, " +
                                             " aoi_results{{0}}.region AS region, " +
                                             " aoi_results{{0}}.ng_type_id AS ng_type_id, " +
                                             " aoi_results{{0}}.is_misjudge AS is_misjudge, " +
                                             " aoi_results{{0}}.result_ng_type_id AS result_ng_type_id, " +
                                             " aoi_results{{0}}.part_image_path AS part_image_path, " +
                                             " aoi_results{{0}}.create_time AS create_time, " +
                                             " aoi_ng_types.ng_str AS ng_str, " +
                                             " (SELECT ng_str FROM aoi_ng_types WHERE id = result_ng_type_id) as result_ng_str, " +
                                             " aoi_pcs.pc_name AS pc_name, " +
                                             " aoi_pcs.pc_ip AS pc_ip " +
                                             " FROM " +
                                             " ((((aoi_results{{0}} " +
                                             " JOIN aoi_pcbs{{0}} ON (aoi_results{{0}}.pcb_id = aoi_pcbs{{0}}.id)) " +
                                             " JOIN aoi_softwares ON (aoi_pcbs{{0}}.software_id = aoi_softwares.id)) " +
                                             " JOIN aoi_ng_types ON (aoi_ng_types.software_id = aoi_softwares.id AND aoi_results{{0}}.ng_type_id = aoi_ng_types.id)) " +
                                             " JOIN aoi_pcs ON (aoi_softwares.pc_id = aoi_pcs.id)) " +
                                             " WHERE " +
                                             " aoi_results{{0}}.create_time BETWEEN '{0}' AND '{1}'",
                                             startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                             endTime.ToString("yyyy-MM-dd HH:mm:ss"));
            return queryStr;
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
        /// <returns></returns>
        public static string GetMainStatisticalStrV2()
        {
            string whereStr = String.Format(" WHERE software_id = `aoi_softwares`.`id` AND create_time BETWEEN '{0}' AND '{1}'",
                startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                 endTime.ToString("yyyy-MM-dd HH:mm:ss"));

            string queryStr = String.Format("SELECT DISTINCT" +
                                            "	`aoi_pcs`.`id` AS `pc_id`," +
                                            "	`aoi_pcs`.`pc_name` AS `pc_name`," +
                                            "	`aoi_pcs`.`pc_ip` AS `pc_ip`," +
                                            "	`aoi_softwares`.`software_name` AS `software_name`," +
                                            "	`aoi_softwares`.`id` AS `software_id`," +
                                            "	( SELECT COUNT( * ) FROM `{{0}}` {2}) AS 'count_pcb'," +
                                            "	( SELECT SUM( is_error = 1 ) FROM `{{0}}` {2}) AS 'count_error_pcb'," +
                                            "	( SELECT SUM( is_misjudge = 1 ) FROM `{{0}}` {2}) AS 'count_warning_pcb'," +
                                            "	( SELECT SUM( is_error = 0 ) FROM `{{0}}` {2}) AS 'count_good_pcb'," +
                                            "	( SELECT SUM( is_misjudge = 1 ) / COUNT( * ) FROM `{{0}}` {2}) AS 'pcb_ppm'," +
                                            "	0.00 AS 'defect_rate'," +
                                            "	0.00 AS 'pass_rate'" +
                                            " FROM" +
                                            "	(" +
                                            "	( `aoi_softwares` JOIN `{{0}}` ON ( `{{0}}`.`software_id` = `aoi_softwares`.`id` ) )" +
                                            "	JOIN `aoi_pcs` ON ( `aoi_softwares`.`pc_id` = `aoi_pcs`.`id` ) " +
                                            "	)" +
                                            " WHERE {{0}}.create_time BETWEEN '{0}' AND '{1}' ORDER BY software_id desc",

                                            startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            endTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                            whereStr);
            return queryStr;
        }

        /// <summary>
        /// 获取查询页面饼图的单表查询语句
        /// </summary>
        /// <returns></returns>
        public static string GetChartPieBaseSql_AI(string oneSoftwareId)
        {
            //"# 这里left join on 加了if主要是如果result_ng_type_id =''表示为ok的数据" + 
            return String.Format(" SELECT" +
                                    "	*," +
                                    "	COUNT( * ) AS 'count' " +
                                    " FROM" +
                                    "	(" +
                                    " SELECT" +
                                    "	aoi_ng_types.software_id," +
                                    "	ng_type_id," +
                                    "	result_ng_type_id," +
                                    " IF" +
                                    "	( result_ng_type_id = '', 'OK', ng_str ) AS 'result_ng_str'," +
                                    "	{{0}}.create_time" +
                                    " FROM" +
                                    "	{{0}}" +
                                    "	LEFT JOIN aoi_ng_types ON aoi_ng_types.id =" +
                                    " IF" +
                                    "	( {{0}}.result_ng_type_id = '', {{0}}.ng_type_id, {{0}}.result_ng_type_id ) " +
                                    " WHERE" +
                                    "	! ISNULL( result_ng_type_id ) " +
                                    "   AND  {{0}}.is_misjudge != -1 " +
                                    "	AND ! ISNULL( ng_type_id ) " +
                                    "	AND software_id = '{0}' AND {{0}}.create_time BETWEEN '{1}' AND '{2}'" +
                                    "	) AS fin " +
                                    " GROUP BY" +
                                    "	result_ng_type_id," +
                                    "	software_id",

                                    oneSoftwareId,
                                    startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                    endTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        /// <summary>
        /// 获取查询页面饼图的单表查询语句
        /// </summary>
        /// <returns></returns>
        public static string GetChartPieBaseSql_2D(string oneSoftwareId)
        {
            //"# 这里left join on 加了if主要是如果result_ng_type_id =''表示为ok的数据" + 
            return String.Format(" SELECT" +
                                    "	*," +
                                    "	COUNT( * ) AS 'count' " +
                                    " FROM" +
                                    "	(" +
                                    " SELECT" +
                                    "	software_id," +
                                    "	ng_type," +
                                    "	IF(result_string != '', result_string, 'OK') AS 'result_ng_str'," +
                                    "	{{0}}.create_time" +
                                    " FROM" +
                                    "	{{0}}" +
                                    "	LEFT JOIN aoi_pcbs ON aoi_results_2d_detail.pcb_id = aoi_pcbs.id" +
                                    " WHERE" +
                                    "	! ISNULL( ng_type ) " +
                                    "   AND  {{0}}.is_misjudge != -1 " +
                                    "	AND software_id = '{0}' AND {{0}}.create_time BETWEEN '{1}' AND '{2}'" +
                                    "	) AS fin " +
                                    " GROUP BY" +
                                    "	result_ng_str," +
                                    "	software_id",
                                    oneSoftwareId,
                                    startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                    endTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
