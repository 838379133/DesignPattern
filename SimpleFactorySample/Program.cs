using System;
using System.Configuration;

namespace SimpleFactorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            IChart chart;
            chart = ChartFactory.GetChart("histogram");
            chart.Display();
            //读取配置文件
            //string chartStr = ConfigurationManager.AppSettings["chartType"];
            //chart = ChartFactory.GetChart(chartStr);
            //chart.Display();

            Console.Read();
        }
    }
}
