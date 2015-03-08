/****************************************************************************
 Name        : Naive-Encryptor
 Author      : Jayanth Prakash Kulkarni
 Copyright   : Copyright Mr Jayanth Prakash Kulkarni © 2015
 Description : Language c#
 ***************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace encryptor
{
    public partial class Form1 : Form
    {
        int i = new int();
        int num1 = new int();
        string s1 = "";
        string s2 = "";
        public Form1()
        {
            InitializeComponent();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            {
                num1 = textBox1.Text.Length;
                StringBuilder stringq = new StringBuilder();                 
                string s = textBox1.Text;
                foreach (char c in s)
                {
                    
                    int num = System.Convert.ToInt32(c);
                    if (num1 > 23)
                        num = num  - num1 + 22 ;
                    else
                        num = num - num1 - 4  ;
                    stringq.Append(char.ConvertFromUtf32(num));                        
                }
                s1 = stringq.ToString();
                StringBuilder stringm = new StringBuilder();
                foreach (char c in s1)
                {
                    int num = System.Convert.ToInt32(c);
                    if (num1 > 23)
                        num = num - num1 + 22;
                    else
                        num = num - num1 - 4;
                    stringm.Append(char.ConvertFromUtf32(num));
                }
                s2 = stringm.ToString();
                 textBox2.Text = s2;               
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder str1234 = new StringBuilder();
            StringBuilder str12345 = new StringBuilder();
            string st = "";
            string s1 = textBox2.Text;
            i = 0;
            num1 = textBox2.Text.Length;
            foreach (char c in s1)
            {
                i++;
                int num = System.Convert.ToInt32(c);
                if (num1 > 23)
                    num = num + num1 - 22 ;
                else
                   num = num + num1 + 4 ;
                 str12345.Append(char.ConvertFromUtf32(num));                
            }
            st = str12345.ToString();
            foreach (char c in st)
            {
                i++;
                int num = System.Convert.ToInt32(c);
                if (num1 > 23)
                    num = num + num1 - 22;
                else
                    num = num + num1 + 4;
                str1234.Append(char.ConvertFromUtf32(num));
            }
            st = str1234.ToString();
            
      if (textBox3.Text == textBox5.Text)
                {
                    textBox4.Text = st ;
                }
                else
                {
                    MessageBox.Show("THE ENTERED KEY IS WRONG", "ATTENTION", MessageBoxButtons.OK);
                }
        }
    }
}
