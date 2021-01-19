using spc_client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spc_client.Tools
{
    public class SubTableQueryHelper<T>
    {
        public delegate void Callback(List<T> listRes, bool isDone);
        private int allQueryNum = 0; // 指的是一共查询的月份个数
        private int currentNum = 0; // 标识当前运行了几个
        public SubTableQueryHelper()
        {

        }

        public void Run(List<string> listQueryStr, Callback callback)
        {
            allQueryNum = listQueryStr.Count;
            foreach (var qStr in listQueryStr)
            {
                MySmartThreadPool.Instance().QueueWorkItem((sql) =>
                {
                    SpcModel spcModel = DB.Instance();
                    List<T> res = new List<T>();
                    try
                    {
                        res = spcModel.Database.SqlQuery<T>(sql).ToList();
                    }
                    catch (Exception er)
                    {

                    }
                    finally
                    {
                        spcModel.Dispose();
                        currentNum++;
                        callback(res, currentNum == allQueryNum);
                    }
                }, qStr);
            }
        }
    }
}
