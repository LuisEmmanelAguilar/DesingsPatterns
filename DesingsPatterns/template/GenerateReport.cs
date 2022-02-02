using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.template
{
    public class GenerateReport
    {
        private AuditTrail auditTrail;
        public GenerateReport(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void execute()
        {
            auditTrail.record();
            Console.WriteLine("Generating report");
        }
    }
}
