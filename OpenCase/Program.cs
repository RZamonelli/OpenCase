using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe número do EOC: ");
            int eoc = Convert.ToInt32(Console.ReadLine());
            GenerateReport(eoc);

            Console.ReadKey();
        }

        public static void GenerateReport(int reportType) {

            switch (reportType)
            {
                case (int)CoolingSystem.Hemo:
                    Console.Write("Hemo Report");//Show report
                    break;
                case (int)CoolingSystem.Vitals:
                    Console.Write("Vitals report");//Show report
                    break;
                case (int)CoolingSystem.Case:
                    Console.Write("Case report");//Show report
                    break;
                default:
                    break;
            }
        }

        public enum CoolingSystem
        {
            Hemo = 1,
            Vitals,
            Case
        }
    }
}
