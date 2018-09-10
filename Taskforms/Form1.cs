using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskforms
{
    public partial class Form1 : Form
    {
        Employee employee;



        public class Item
        {
            public string Name;
            public int Value;

            public Item(string name, int value)
            {
                Name = name;
                Value = value;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public Form1()
        {
            InitializeComponent();

            cmbemptype.Items.Add(new Item("Permanent", 0));
            cmbemptype.Items.Add(new Item("Contract", 1));
            cmbemptype.Items.Add(new Item("Trainee", 2));

            cmbselectedemp.Items.Add(new Item("Permanent", 0));
            cmbselectedemp.Items.Add(new Item("Contract", 1));
            cmbselectedemp.Items.Add(new Item("Trainee", 2));

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbemptype.SelectedIndex == 0)
            {
                lblannual.Visible = true;
                txtannualsal.Visible = true;
                lblfix.Visible = false;
                txtfixedsal.Visible = false;
                lblmonthsal.Visible = false;
                txtmonthsal.Visible = false;

            }
            else if (cmbemptype.SelectedIndex == 1)
            {
                lblmonthsal.Visible = true;
                txtmonthsal.Visible = true;
                lblannual.Visible = false;
                txtannualsal.Visible = false;
                lblfix.Visible = false;
                txtfixedsal.Visible = false;
            }
            else
            {
                lblfix.Visible = true;
                txtfixedsal.Visible = true;
                lblannual.Visible = false;
                txtannualsal.Visible = false;
                lblmonthsal.Visible = false;
                txtmonthsal.Visible = false;


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbemptype.SelectedItem == null)
            {
                MessageBox.Show("Select EmployeeType");
                return;
            }

 

            if (!IsValidation())
            {
                return;
            }





       
            employee = new Employee();
            employee.Emptype = cmbemptype.SelectedItem.ToString();
            int i;

            bool isConversitoinSucedded = int.TryParse(txtempid.Text, out i);

            if (isConversitoinSucedded)
            {
                employee.id = i;
            }


            // employee.id = txtempid.Text;
            employee.firstname = txtfirstname.Text;
            employee.lastname = txtlastname.Text;

            if (employee.Emptype == "Permanent")
            {
                double d;
                bool Succeed = double.TryParse(txtannualsal.Text, out d);
                if (Succeed)
                {
                    employee.salary = d;
                }
                if (IsValid())
                {
                    Database.AddPermantEmp(employee);
                    Clear();
                    employee = null;
                    MessageBox.Show("Saved Successfully");

                }
                else
                {
                    MessageBox.Show("Not Valid");
                }
                
            }
            else if (employee.Emptype == "Contract")
            {
                double c;
                bool Success = double.TryParse(txtmonthsal.Text, out c);
                if (Success)
                {
                    employee.salary = c;
                }
                if (IsValid())
                {
                    Database.AddContractEmp(employee);
                    Clear();
                    employee = null;
                    MessageBox.Show("Saved Successfully");


                }
                else
                {
                    MessageBox.Show("Not Valid");
                }
            }
            else
            {
                double b;
                bool Successful = double.TryParse(txtfixedsal.Text, out b);
                if (Successful)
                {
                    employee.salary = b;
                }
                if (IsValid())
                {
                    Database.AddTraineeEmp(employee);
                    Clear();
                    MessageBox.Show("Saved Successfully");
                    employee = null;

                }
                else
                {
                    MessageBox.Show("Not Valid");
                }
            }

           // MessageBox.Show("your data stored successfully");
        }
        private void Clear()
        {
            cmbemptype.Text = string.Empty;
            txtempid.Text = string.Empty;
            txtfirstname.Text = string.Empty;
            txtlastname.Text = string.Empty;
            txtannualsal.Text = string.Empty;
            txtmonthsal.Text = string.Empty;
            txtfixedsal.Text = string.Empty;
        }

        private void ClrearData()
        {
            cmbselectedemp.Text = string.Empty;
            cmbFetchId.Text = string.Empty;
            dataGridView1.DataSource = null;
            
        }

        private bool IsValidation()
        {

            if (txtempid.Text == "")
            {
                form1ErrorProvider.SetError(txtempid, "empid field is required");
                //MessageBox.Show("this field cannot be left blank");
                // txtempid.Focus();
            }
            else
            {
                form1ErrorProvider.SetError(txtempid, "");
            }

            if (txtfirstname.Text == "")
            {
                form1ErrorProvider.SetError(txtfirstname, "empfirstname field is required");
            }
            else
            {
                form1ErrorProvider.SetError(txtfirstname, "");
            }

            if (txtlastname.Text == "")
            {
                form1ErrorProvider.SetError(txtlastname, "emplastname field is required");
            }
            else
            {
                form1ErrorProvider.SetError(txtlastname, "");
            }
            if (txtannualsal.Text == "")
            {
                form1ErrorProvider.SetError(txtannualsal, "empannualsal field is required");
            }
            else
            {
                form1ErrorProvider.SetError(txtannualsal, "");
            }
            if (txtmonthsal.Text == "")
            {
                form1ErrorProvider.SetError(txtmonthsal, "empmonthsal field is required");
            }
            else
            {
                form1ErrorProvider.SetError(txtmonthsal, "");
            }
            if (txtfixedsal.Text == "")
            {
                form1ErrorProvider.SetError(txtfixedsal, "empfixedsal field is required");
            }
            else
            {
                form1ErrorProvider.SetError(txtfixedsal, "");
            }
            return true;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(employee.id.ToString()) || (employee.id == 0) || (employee.salary == 0) ||
                    string.IsNullOrEmpty(employee.lastname.ToString()) ||
                    string.IsNullOrEmpty(employee.firstname.ToString()) || string.IsNullOrEmpty(employee.salary.ToString()))
            {
                return false;
            }
            else
            {
               
                return true;
            }
            
        }
        private void cmbselectedemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbselectedemp.Text == "Permanent")
            {
              var PId=  Database.Permanent.Select(s => s.id).ToList();
              cmbFetchId.DataSource = PId;
                dataGridView1.DataSource = Database.Permanent;

            }
            else if (cmbselectedemp.Text == "Contract")
            {
                var Cid = Database.Contract.Select(c => c.id).ToList();
                cmbFetchId.DataSource = Cid;
                dataGridView1.DataSource = Database.Contract;
            }
            else
            {
                dataGridView1.DataSource = Database.Trainee;
               var Tid= Database.Trainee.Select(t => t.id).ToList();
                cmbFetchId.DataSource = Tid;
              
                
            }
        }

        private void cmbFetchId_SelectedIndexChanged(object sender, EventArgs e)
        {
           //var emp= Database.Permanent.Where(s => s.id == Int32.Parse(cmbFetchId.SelectedItem.ToString())).FirstOrDefault();
           // dataGridView1.DataSource = emp as Employee;

        }

        private void Retrieve_Selected(object sender, TabControlEventArgs e)
        {
            ClrearData();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("enter id");
            }
            else
            {
                switch (cmbselectedemp.Text)
                {
                    case "Permanent":
                        {
                          //  var data = Database.Permanent..Select(s => s.id);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
