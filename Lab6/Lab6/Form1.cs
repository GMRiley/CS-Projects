using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonLibV2;


namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String errorLog = "";
            object UserEntry = new object();
            PersonV2 temp = new PersonV2();
            temp.FirstName = fNameTxt.Text;
            temp.MiddleName = mNameTxt.Text;
            temp.LastName = lNametxt.Text;

            temp.StreetOne = addOneTxt.Text;
            temp.StreetTwo = addTwoTxt.Text;
            temp.CityStr = cityTxt.Text;
            temp.StateStr = stateTxt.Text;
            temp.ZipStr = zipTxt.Text;

            temp.PhoneStr = hPhoneTxt.Text;
            temp.CellPhone = cPhoneTxt.Text;
            temp.EmailStr = eMailTxt.Text;
            temp.FaceBook = fBookTxt.Text;

            foreach (int value in PersonV2)

        }
    }
}
