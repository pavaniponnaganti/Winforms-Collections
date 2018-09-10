using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskforms
{
    public static class Database
    {
        public static List<Employee> Permanent;
        public static List<Employee> Contract;
        public static List<Employee> Trainee;

        public static void AddPermantEmp(Employee emp)
        {
            if (Permanent == null)
            {
                Permanent = new List<Employee>();
            }
            Permanent.Add(emp);
        }

        public static void AddContractEmp(Employee emp)
        {
            if (Contract == null)
            {
                Contract = new List<Employee>();
            }
            Contract.Add(emp);
        }

        public static void AddTraineeEmp(Employee emp)
        {
            if(Trainee == null)
            {
                Trainee = new List<Employee>();
            }
            Trainee.Add(emp);
        }


    }
}
