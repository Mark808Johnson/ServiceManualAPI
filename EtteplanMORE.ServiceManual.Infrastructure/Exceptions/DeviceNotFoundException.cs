using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtteplanMORE.ServiceManual.ApplicationCore.Exceptions
{
    public class DeviceNotFoundException : Exception
    {
        public DeviceNotFoundException(string message)
            : base(message)
        {
        }
    }
}
