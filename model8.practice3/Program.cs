using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model8.practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 过去五个月的销量数据（示例数据）
            double[] salesData = { 100, 120, 140, 160, 180 };

            // 计算月份（1至5表示过去五个月）
            double[] months = { 1, 2, 3, 4, 5 };

            // 使用最小二乘法拟合线性趋势线（y = mx + b）
            int n = salesData.Length;
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;
            for (int i = 0; i < n; i++)
            {
                sumX += months[i];
                sumY += salesData[i];
                sumXY += months[i] * salesData[i];
                sumX2 += months[i] * months[i];
            }

            double m = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            double b = (sumY - m * sumX) / n;

            // 使用线性趋势线预测未来三个月的销量（6、7、8）
            double[] futureMonths = { 6, 7, 8 };
            Console.WriteLine("Прогноз продаж на ближайшие три месяца：");
            foreach (double month in futureMonths)
            {
                double predictedSales = m * month + b;
                Console.WriteLine($"месяц {month}: Прогноз продаж {predictedSales}");
            }
        }
    }
}
