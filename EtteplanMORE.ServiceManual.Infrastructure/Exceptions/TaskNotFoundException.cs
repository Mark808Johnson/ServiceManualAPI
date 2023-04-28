using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.Infrastructure.Exceptions
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException(string message)
            : base(message)
        {
        }
    }
}
