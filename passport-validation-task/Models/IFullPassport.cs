using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace passport_validation_task.Models
{
   public interface IFullPassport
    {
        public string fullPassport( string sereis, string number);
    }
}
