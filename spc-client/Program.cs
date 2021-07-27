﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.XtraSplashScreen;
using System.Threading;
using spc_client.Tools;
using HalconDotNet;

namespace spc_client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HOperatorSet.SetSystem("do_low_error", "false"); ///少报错
            HOperatorSet.SetSystem("clip_region", "false"); //region在图像外不切掉
            HOperatorSet.SetSystem("border_shape_models", "true"); //依然匹配边缘的图形
            HOperatorSet.SetSystem("use_window_thread", "true");
            //Snowflake snowflake = new Snowflake(1);
            //for (int i = 0;i < 20; i++){
            //    Console.WriteLine(snowflake.nextId().ToString());
            //}
            bool Exist;//定义一个bool变量，用来表示是否已经运行
                       //创建Mutex互斥对象
            System.Threading.Mutex newMutex = new System.Threading.Mutex(true, "power-spc", out Exist);
            if (Exist)//如果没有运行
            {
                newMutex.ReleaseMutex();//运行新窗体
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainView());
            }
            else
            {
                MessageBox.Show("本程序一次只能运行一个实例！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹出提示信息
            }

        }
    }
}
