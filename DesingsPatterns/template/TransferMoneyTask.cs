using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.template
{
    public class TransferMoneyTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Transfer Money");
        }


    }
}
