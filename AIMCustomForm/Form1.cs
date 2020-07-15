using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIMCustomForm
{
    public partial class Form1 : Form
    {

        private string aimStatus;

        public Form1()
        {
            InitializeComponent();
        }

        public void setStatus(string aimStatusXml)
        {
            aimStatus = aimStatusXml;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText(aimStatus);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
