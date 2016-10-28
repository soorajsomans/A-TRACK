using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            listBox1.Visible = false;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button1.Text;
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ButtonVisibility(false); 
        }

        public void ButtonVisibility(bool b)
        {
            button1.Visible = b;
            button2.Visible = b;
            button3.Visible = b;
            button4.Visible = b;
            button5.Visible = b;
            button6.Visible = b;
            button7.Visible = b;
            button8.Visible = b;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonVisibility(true);
            label1.Text = "";
            listBox1.Visible = false;
            groupBox1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
