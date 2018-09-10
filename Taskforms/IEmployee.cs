using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskforms
{
    public interface IEmployee
    {
         string Emptype {
            get;
            set;
        }
        string firstname
        {
            get;
            set;
        }
        string lastname
        {
            get;
            set;
        }
        double salary
        {
            get;
            set;
        }
        int id
        {
            get;
            set;
        }
     //  double CalcSalary();
    }


}
