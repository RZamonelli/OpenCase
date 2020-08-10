using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCase
{
    public interface IReportContext
    {
        void CreateReport();
        string nomeReport { get;   set; }
        IReports Reports { get; set; }

    }

    public class ReportContext : IReportContext
    {
        public void CreateReport()
        {
            this.Reports.CreateReport(this);
        }

        public IReports Reports { get; set; }
        public string nomeReport { get; set; }
    }
}
