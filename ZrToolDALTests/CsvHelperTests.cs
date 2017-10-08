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
    public class CsvHelperTests
    {
        [TestMethod()]
        public void ParseCsvTest()
        {
            string mypath = @"E:\ZrTool\db\9.9.csv";
            List<String[]> li = CsvHelper.ReadCSV(mypath);
            //DataTable dt= CsvHelper.OpenCSV(mypath);
            foreach (string[] le in li)
            {
                Console.WriteLine(le[0]);

            }
            //Console.ReadKey();
        }
    }
}