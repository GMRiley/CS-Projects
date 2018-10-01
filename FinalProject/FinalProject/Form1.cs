using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Student temp = new Student();
            
            temp.FirstName = fNameText.Text;
            temp.LastName = lNameText.Text;
            DataSet data = temp.SearchPerson();
            gvResults.DataSource = data;
            gvResults.DataMember = data.Tables["Person_Temp"].ToString();
        }

        private void gvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore this
        }

        private void gvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strUser_ID = gvResults.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show(strUser_ID);

            int intUser_ID = Convert.ToInt32(strUser_ID);
            newStudentForm Editor = new newStudentForm(intUser_ID);
            Editor.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newStudentForm temp = new newStudentForm();
            temp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
