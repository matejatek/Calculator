using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public float first;
        public float second;
        public char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void b_0_Click(object sender, EventArgs e)
        {
            sc.Text += "0";
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            sc.Text += "1";
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            sc.Text += "2";
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            sc.Text += "3";
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            sc.Text += "4";
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            sc.Text += "5";
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            sc.Text += "6";
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            sc.Text += "7";
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            sc.Text += "8";
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            sc.Text += "9";
        }

        private void b_p_Click(object sender, EventArgs e)
        {
            if (sc.Text.Contains('.'))
            { }
            else
            { sc.Text += '.'; }
            
        }
        private void b_e_Click(object sender, EventArgs e)
        {
            second = float.Parse(sc.Text);
            switch(op)
            {
                case '+':sc.Text = (first + second).ToString();break;
                case '-': sc.Text = (first - second).ToString(); break;
                case '*': sc.Text = (first * second).ToString(); break;
                case '/': sc.Text = (first / second).ToString(); break;
            }
        }

        private void b_pl_Click(object sender, EventArgs e)
        {
            first = float.Parse(sc.Text);
            op = '+';
            sc.Text = "";
        }

        private void b_m_Click(object sender, EventArgs e)
        {
            first = float.Parse(sc.Text);
            op = '-';
            sc.Text = "";
        }

        private void b_k_Click(object sender, EventArgs e)
        {
            first = float.Parse(sc.Text);
            op = '*';
            sc.Text = "";
        }

        private void b_d_Click(object sender, EventArgs e)
        {
            first = float.Parse(sc.Text);
            op = '/';
            sc.Text = "";
        }

        private void b_c_Click(object sender, EventArgs e)
        {
            sc.Text = "";
            first = 0;
            second = 0;
        }
    }
}
