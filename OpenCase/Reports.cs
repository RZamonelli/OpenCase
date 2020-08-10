using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCase
{

    public interface IReports
    {
        void CreateReport(IReportContext ReportContext);
    }

    public class HemoReport : IReports
    {
        public void CreateReport(IReportContext ReportContext)
        {
            ReportContext.nomeReport = "Hemo Report";
        }
    }

    public class VitalsReport : IReports
    {
        public void CreateReport(IReportContext ReportContext)
        {
            ReportContext.nomeReport = "Vitals Report";
        }
     }
 
    public class CaseReport : IReports
    {
        public void CreateReport(IReportContext ReportContext)
        {
            ReportContext.nomeReport = "Case Report";
        }
    }
}
