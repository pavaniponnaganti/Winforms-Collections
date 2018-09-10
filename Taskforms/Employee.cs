using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskforms
{
   public class Employee : IEmployee
    {
        public string firstname
        {
            get;
            set;
        }
        public string lastname
        {
            get;
            set;
        }
        public double salary
        {
            get;
            set;
        }
        public int id
        {
            get;
            set;
        }
        public string Emptype {
            get ;
            set ;
        }

        //public virtual double CalcSalary()
        //{
        //    return 0;
        //}
    }
}
