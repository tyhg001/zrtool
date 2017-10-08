using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZrTool.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ZrTool.DAL.Tests
{
    [TestClass()]
    public class ExcelHelperTests
    {

        [TestMethod()]
        public void OpenCSVTest()
        {
            string mypath = @"E:\ZrTool\db\9.9.csv";
            List<List<string>> dt = CsvHelper.ParseCsv(mypath);

        }
    }
}