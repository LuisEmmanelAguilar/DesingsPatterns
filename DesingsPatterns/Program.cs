
using DesingsPatterns.command;
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
            // Command Pattern
            var service = new CustomerService();
            var command = new AddCustomerCommand(service);
            var button = new Button(command);
            button.click();


            Console.ReadLine();

        }
    }
}
