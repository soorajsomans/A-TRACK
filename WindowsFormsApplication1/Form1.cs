using System;
using System.IO;
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
        int subject = 0;
        int chapter = 0;
        static int index;
        static int end;
        static int start;
        int length;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            listBox1.Visible = false;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject = 1;
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button1.Text;
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonVisibility(false);
            if ((string)listBox1.SelectedItem == "Chapter 1")
            {
                chapter = 1;
               
            }
            else if((string)listBox1.SelectedItem == "Chapter 2")
            {
                chapter = 2;
            }
            index = 0;
            end = 0;
            
            showQues(subject, chapter);
        }
        private void showQues(int sub,int chap)
        {
            string[] lines = File.ReadLines(@"C:\Users\user\Desktop\IT\Chapter 1.txt").ToArray();
            length=lines.Length;
            if (!(end >= lines.Length))
            {
                label1.Text = lines[index];
                label2.Text = lines[index + 1];
                label3.Text = lines[index + 2];
                label4.Text = lines[index + 3];
                label5.Text = lines[index + 4];
                
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Text = button8.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!(index - 6 <= -1))
            {
                index -= 6;
                end -= 6;
                start += 6;
                showQues(subject, chapter);
                label6.Text = "" + index;
                label7.Text = "" + length;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!(index + 6 >= length))
            { 
                index += 6;
                end += 6;
                start -= 6;
                label6.Text =""+ index;
                label7.Text = "" + length;
                showQues(subject, chapter);
            }
        }
    }
}
