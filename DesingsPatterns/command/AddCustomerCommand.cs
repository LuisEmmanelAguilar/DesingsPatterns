using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }

        public void execute()
        {
            service.addCustomer();
        }
    }
}
