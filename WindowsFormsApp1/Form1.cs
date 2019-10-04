using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object btnOK;
        private object colorDialog1;

        public Form1()
        {
            InitializeComponent();

         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         textBox3.Text = (int.Parse(textBox2.Text) + int.Parse(textBox1.Text)).ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
             

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            BackColor = colorDialog2.Color;
        }
    }
}
