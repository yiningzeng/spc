﻿using spc_client.Tools;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace spc_client.Model
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class SpcModel : DbContext
    {
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“AoiModel”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“power_aoi.Models.AoiModel”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“AoiModel”
        //连接字符串。
        //public SpcModel()
        //    : base("name=Spc")
        //{
        //}
        public SpcModel()
            : base(GetDbConnectionStr())
        {
        }

        public static string GetDbConnectionStr()
        {
            string host = INIHelper.Read("db", "host", Application.StartupPath + "/config.ini");
            string port = INIHelper.Read("db", "port", Application.StartupPath + "/config.ini");
            string user = INIHelper.Read("db", "user", Application.StartupPath + "/config.ini");
            string pass = INIHelper.Read("db", "password", Application.StartupPath + "/config.ini");
            string database = INIHelper.Read("db", "database", Application.StartupPath + "/config.ini");
            return "Data Source=" + host + ";user id=" + user + ";Password=" + pass + ";database=" + database + ";port=" + port + ";Character Set=utf8;Allow User Variables=True";
        }


        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。
        public DbSet<AoiUsers> users { get; set; }
        public DbSet<AoiUserGroups> userGroups { get; set; }
        public DbSet<AoiPcs> pcs { get; set; }
        public DbSet<AoiSoftwares> softwares { get; set; }
        public DbSet<AoiNgTypes> ngTypes { get; set; }
        public DbSet<AoiPcbs> pcbs { get; set; }
        public DbSet<AoiResults> results { get; set; }
        //public DbSet<Marker> markers { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
}
