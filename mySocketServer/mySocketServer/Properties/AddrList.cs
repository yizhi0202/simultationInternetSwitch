using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySocketServer.Properties
{
    /// <summary>
    /// 转发表的数据结构
    /// </summary>
    class AddrList
    {
        string MAC;
        string EndPoint;        //Record Pysical Port
        DateTime LST;           //Last send time     
        public string GetMac()
        {
            return MAC;
        }
        public void SetMac(string str)
        {
            MAC = str;
        }
        public string GetEndPoint()
        {
            return EndPoint;
        }
        public void SetEndPoint(string str)
        {
            EndPoint = str;
        }
        public DateTime GetDateTime()
        {
            return LST;
        }
        public void SetDateTime(DateTime dt)
        {
            LST = dt;
        }
    }

    /// <summary>
    /// TTL时间阈值类
    /// </summary>
    class ThreshHold
    {
        private static double threshhold = 0.015;             //定义有效期阈值一分钟不到，单位小时
        /// <summary>
        /// 设置阈值
        /// </summary>
        /// <param name="time"></param>
        public void SetThreshHold(double time)
        {
            threshhold = time;
        }

        /// <summary>
        /// 获取阈值
        /// </summary>
        /// <returns></returns>
        public double GetThreshHold()
        {
            return threshhold;
        }

        //计算已经经过的时间单位小时
        public bool IsTimeOut(DateTime t1)
        {
            double timediff;    //存放时间差
            int days;           //临时存放时间差的天数
            int hours;          //临时存放时间差的小时数
            double mins;           //存放分钟
            double temp;
            DateTime timenow = DateTime.Now;
            TimeSpan ts = timenow - t1;
            days = ts.Days;
            hours = ts.Hours;
            mins = ts.Minutes;
            temp = Math.Round(mins/60, 2);               //分钟转换成小时保留两位小数
            timediff = (double)(days * 24 + hours) + temp;
            if (timediff >= threshhold) return true;
            else return false;
        }
    }

    
}
