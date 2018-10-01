using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class newStudentForm : Form
    {
        int catSelect;
        string programSelect;
        public newStudentForm()
        {
            InitializeComponent();
            studentID_lbl.Hide();
            label8.Hide();
            updateBtn.Hide();
            deleteBtn.Hide();
        }
        public newStudentForm(int intUser_ID)
        {
            InitializeComponent();
            Student temp = new Student();
            SqlDataReader dataRead = temp.FindOnePerson(intUser_ID);

            studentID_lbl.Show();
            label8.Show();
            updateBtn.Show();
            deleteBtn.Show();
            btnSub.Hide();

            while (dataRead.Read())
            {
                firstTxt.Text = dataRead["FirstName"].ToString();
                lastTxt.Text = dataRead["LastName"].ToString();
                dobDateTime.Text = dataRead["DateOB"].ToString();
                startDateTime.Text = dataRead["StartDate"].ToString();
                txtGPA.Text = dataRead["GradePA"].ToString();
                txtCredits.Text = dataRead["Credits"].ToString();
                studentID_lbl.Text = dataRead["Student_ID"].ToString();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            catSelect = listBox1.SelectedIndex;
            String[] origin = new String[9] {"Architecture and Design", "Automotive and Transportation", "Building Technologies", "Communications", "Engineering","Information Technology", "Law Enforcement", "Health Sciences", "Veterinary", };
            DegreeList temp = new DegreeList();
            String checker = listBox1.SelectedItem.ToString();
            if (checker == "Back")
            {
                listBox1.Items.Clear();
                for (int i = 0; i < origin.Count(); i++)
                {
                    listBox1.Items.Add(origin[i]);
                }
            }
            else
            {
                switch (catSelect)
                {
                    case 0:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Architecture.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Architecture[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 1:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Automotive.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Automotive[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 2:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Building.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Building[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 3:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Communications.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Communications[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 4:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Engineering.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Engineering[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 5:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.InfoTech.Count(); i++)
                        {
                            listBox1.Items.Add(temp.InfoTech[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 6:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Law.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Law[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 7:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Health.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Health[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                    case 8:
                        listBox1.Items.Clear();
                        for (int i = 0; i < temp.Veterinary.Count(); i++)
                        {
                            listBox1.Items.Add(temp.Veterinary[i].Category);
                        }
                        listBox1.Items.Add("Back");
                        break;

                }
            }
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Student temp = new Student();
            DegreeList degree = new DegreeList();
            string record;
            temp.ErrorLog = "";

            temp.FirstName = firstTxt.Text;
            temp.LastName = lastTxt.Text;
            temp.DateOB = dobDateTime.Value;
            temp.StartDate = startDateTime.Value;
            temp.GradePA = double.Parse(txtGPA.Text);
            temp.Credits = Int32.Parse(txtCredits.Text);
            temp.Degree = listBox1.SelectedItem.ToString();
            int selecter = listBox1.SelectedIndex;

            temp.Student_ID += "00";
            if (temp.StartDate.Month > 9 && temp.StartDate.Month < 11)
            {
                temp.Student_ID += "1";
            }
            if (temp.StartDate.Month > 12 && temp.StartDate.Month < 2)
            {
                temp.Student_ID += "2";
            }
            if (temp.StartDate.Month > 3 && temp.StartDate.Month < 5)
            {
                temp.Student_ID += "3";
            }
            if (temp.StartDate.Month > 6 && temp.StartDate.Month < 8)
            {
                temp.Student_ID += "4";
            }
            temp.Student_ID += temp.DateOB.Month;
            temp.Student_ID += temp.DateOB.Day;
            switch (catSelect)
            {
                case 0:
                    programSelect = degree.Architecture[selecter].Class_ID.ToString();
                    break;

                case 1:
                    programSelect = degree.Automotive[selecter].Class_ID.ToString();
                    break;

                case 2:
                    programSelect = degree.Building[selecter].Class_ID.ToString();
                    break;

                case 3:
                    programSelect = degree.Communications[selecter].Class_ID.ToString();
                    break;

                case 4:
                    programSelect = degree.Engineering[selecter].Class_ID.ToString();
                    break;

                case 5:
                    programSelect = degree.InfoTech[selecter].Class_ID.ToString();
                    break;

                case 6:
                    programSelect = degree.Law[selecter].Class_ID.ToString();
                    break;

                case 7:
                    programSelect = degree.Health[selecter].Class_ID.ToString();
                    break;

                case 8:
                    programSelect = degree.Veterinary[selecter].Class_ID.ToString();
                    break;

            }
            temp.Student_ID += programSelect;
            
            if (temp.ErrorLog.Contains("ERROR: "))
            {
                MessageBox.Show(temp.ErrorLog);
            }
            else
            {
                Form1 main = new Form1();
                record = temp.AddARecord();
                MessageBox.Show(record);
                this.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Student temp = new Student();
            temp.FirstName = firstTxt.Text;
            temp.LastName = lastTxt.Text;
            temp.DateOB = dobDateTime.Value;
            temp.StartDate = startDateTime.Value;
            temp.GradePA = double.Parse(txtGPA.Text);
            temp.Credits = Int32.Parse(txtCredits.Text);
            temp.Degree = listBox1.SelectedItem.ToString();
            temp.Student_ID = studentID_lbl.Text;

            if (temp.ErrorLog.Contains("Error: "))
                MessageBox.Show(temp.ErrorLog);
            else
            {
                temp.updateARecord();
                this.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String User_ID = studentID_lbl.Text;
            Student temp = new Student();
            DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                String feedBack = temp.DeleteOnePerson(User_ID);
                MessageBox.Show(feedBack);
                this.Close();
            }
        }
    }
}
