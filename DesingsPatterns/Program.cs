
using DesingsPatterns.command.editor;
using DesingsPatterns.observer;
using DesingsPatterns.templateExcercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Observer Pattern
            var dataSource = new DataSource();
            var sheet1 = new SpreadSheet();
            var sheet2 = new SpreadSheet();
            var chart = new Chart();

            dataSource.addObserver(sheet1);
            dataSource.addObserver(sheet2);
            dataSource.addObserver(chart);

            dataSource.setValue(1);


            Console.ReadLine();

        }
    }
}
