using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_13
{
    public partial class Form1 : Form
    {
        MyArray2 myObj = new MyArray2();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            myObj.Add(x);
            richTextBox1.Text = myObj.toString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myObj.undo();
            richTextBox1.Text=myObj.toString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myObj.clear();
            richTextBox1.Text=myObj.toString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Count = ";
            textBox2.Text = "" + myObj.count();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = myObj.toStringLong();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myObj.assign1234();
            richTextBox1.Text = myObj.toString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            myObj.assign1248();
            richTextBox1.Text = myObj.toString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
            label1.Text = "Sum = ";
            textBox2.Text = ""+ myObj.sum();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            label1.Text = "Avg =";(
            textBox2.Text="" + myObj.avg();
        }

        private void button11_Click(object sender, EventArgs e)
        {
           label1.Text = "Max =";
            textBox2.Text = "" + myObj.max();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "Min =";
            textBox2.Text=""+myObj.min();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "Grade =";
            textBox2.Text=""+myObj.grade();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            myObj.cash4();
            label1.Text = "Cash 4 =";
            textBox2.Text =myObj.toString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox3.Text);
            int Index = myObj.search(x);
            label1.Text = "Search: ";
            textBox2.Text = "" + Index;
        }
    }
}
