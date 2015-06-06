using System;
using System.Data;
using System.Diagnostics;
namespace Assignments
{
    public class RandomNumberTimeCounter
    {
        Stopwatch stopwatch = new Stopwatch();
        RandomNumbers rn = new RandomNumbers();
        Random random = new Random();
        private static bool UserInputValidation(int userInput, int minRange, int maxRange)
        {
            return (userInput < minRange || userInput > maxRange) ? true : false;

        }

        DataTable dt = new DataTable(); 

        public void CountTime()
        {
            int noOfTrails = 0;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Range");
            dt.Columns.Add("TimeElapsed");

            for (int i = 10; i <= 100000; i = i * 10)
            {
                stopwatch.Start();
                noOfTrails = rn.CountTrails(random.Next(1, i), 1, i);
                stopwatch.Stop();
                //Console.WriteLine("Time taken to count trials in range {0} - {1}: is {2}", 1, i, stopwatch.Elapsed);
               
                var row = dt.NewRow();
                row[0] = string.Format("1 - {0}", i);
                row[1] = stopwatch.Elapsed.ToString();
                dt.Rows.Add(row);
                dt.AcceptChanges();
            }

            Console.WriteLine("Range        Time Elapsed");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write(row[i].ToString() + "     ");
                }
            }
            Console.ReadLine();

            #region SavingChartToExcel
            //Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            //if (xlApp == null)
            //{
            //    Console.WriteLine("Excel is not properly installed!!");
            //    return;
            //}

            //var xlWorkBook = xlApp.Workbooks.Add(timeChart.TableName);
            //xlWorkBook.Worksheets.Add(timeChart,"WorksheetName");

            //xlWorkBook.SaveAs("your-file-name.xls");
            #endregion
        }

    }
}