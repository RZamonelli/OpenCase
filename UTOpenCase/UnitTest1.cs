using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenCase;

namespace UTOpenCase
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestHemoReport()
        {
            IReportContext report = new ReportContext();
            report.Reports = new HemoReport();
            report.CreateReport();
            Assert.AreEqual("Hemo Report", report.nomeReport);
        }

        [TestMethod]
        public void TestVitalsReport()
        {
            IReports report = new VitalsReport();
            string result = report.CreateReport();
            Assert.AreEqual("Vitals Report",  result);
        }

        [TestMethod]
        public void TestCaseReport()
        {
            IReports report = new CaseReport();
            string result = report.CreateReport();
            Assert.AreEqual("Case Report", result);
        }
    }
}
