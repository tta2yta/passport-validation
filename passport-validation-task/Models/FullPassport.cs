using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passport_validation_task.Models
{
    public class FullPassport : IFullPassport
    {
     
        public string fullPassport(string sereis, string number)
        {
            return sereis + number;
        }
    }
}
