using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.template
{
    public abstract class Task
    {
        private AuditTrail auditTrail;
        public Task()
        {
            auditTrail = new AuditTrail();
        }


        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }


        public void execute()
        {
            auditTrail.record();

            doExecute();
        }

        protected abstract void doExecute();


    }
}
