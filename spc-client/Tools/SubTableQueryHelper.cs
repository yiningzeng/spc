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
        public delegate void Callback(string sql, List<T> listRes, bool isDone);

        public int allQueryNum = 0; //指的是一共查询的月份个数
        public int currentNum = 0; // 标识当前运行了几个

        public delegate void FinalCallback(string sql, Dictionary<string, List<T>> finResDic);
        private Dictionary<string, List<T>> finResDic;
        public SubTableQueryHelper()
        {

        }

        public void Run(List<string> listQueryStr, FinalCallback callback)
        {
            finResDic = new Dictionary<string, List<T>>();
            currentNum = 0;
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
                        lock (finResDic)
                        {
                            finResDic.Add(sql, res);
                            currentNum++;
                        }
                        if (currentNum >= allQueryNum)
                        {
                            callback(sql, finResDic);
                        }
                    }
                }, qStr);
            }
        }

        public void Run(List<string> listQueryStr, Callback callback)
        {
            currentNum = 0;
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
                        currentNum++;
                        callback(sql, res, currentNum == allQueryNum);
                        spcModel.Dispose();
                    }
                }, qStr);
            }
        }
    }
}
