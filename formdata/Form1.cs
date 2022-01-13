using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(@"C:\Users\dawoon101\Desktop\새 폴더 (2)\data.csv");
            sw.WriteLine($"{NameTxt.Text}, {AgeTxt.Text}, {PhoneTxt.Text}, {BirthDatepicker.Value.ToShortTimeString()}");
            sw.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            NameTxt.Text = null;
            AgeTxt.Text = null;
            PhoneTxt.Text = null;
            BirthDatepicker.Value = DateTime.Now;
        }
    }
}
