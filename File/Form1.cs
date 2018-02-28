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

namespace File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"C:\Users\HP Desire\Desktop\myFile.txt";
        FileStream fs;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(String.Format("{0}|{1}|{2}|{3}", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text));
            sw.Close();
            fs.Close();
            MessageBox.Show("Record Save");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path);
            int count = 0;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] myStudent = s.Split('|');

                if (textBox5.Text == myStudent[0])
                {
                    textBox1.Text = myStudent[0];
                    textBox2.Text = myStudent[1];
                    textBox3.Text = myStudent[2];
                    textBox4.Text = myStudent[3];
                    count = 1;
                }

            }
            if (count == 0)
            {
                MessageBox.Show("No Record Found");
            }
            sr.Close();
        }
    }
}
