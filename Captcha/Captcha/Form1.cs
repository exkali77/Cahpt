using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol = {"A","B","C","X","G","E","F","T","K","R","O","I" };
            string[] sembol2 = { ">", "#", "%", "?", "-","&","|","<","+","é" };
            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(1, sembol.Length);
            s2 = rnd.Next(1, sembol2.Length);
            s3 = rnd.Next(1, 40);
            label1.Text = sembol[s1].ToString() + sembol2[s2].ToString() + s3.ToString();

        }
    }
}
