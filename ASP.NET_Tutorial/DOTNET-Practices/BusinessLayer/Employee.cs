using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Employee:IEmployee
    {
        //Function defined of interface IEmployee here
        public int GetTotalEmployees()
        {
            return 50;
        }
    }
}
