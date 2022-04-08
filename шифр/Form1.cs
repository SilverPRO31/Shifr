using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace шифр
{
    public partial class Form1 : Form
    {
        string s, s2, key;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            key = textBox3.Text;
            char[] vr = s.ToArray();
            for (int j = 0; j < vr.Length; j++)
            {
                for (int i = 0; i < 34; i++)
                {
                    if (vr[j] == DataBase.ru1[i])
                    {
                        textBox2.Text += DataBase.mor1[i].ToString() + "/";
                    }
                    if (vr[j] == DataBase.ru2[i])
                    {
                        textBox2.Text += DataBase.mor2[i].ToString() + "/";
                    }
                }
            }
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (key == textBox3.Text)
            {
                s2 = textBox1.Text;
                string[] vr2 = s2.Split('/');
                for (int j = 0; j < vr2.Length; j++)
                {
                    for (int i = 0; i < 34; i++)
                    {
                        if (vr2[j] == DataBase.mor1[i])
                        {
                            textBox2.Text += DataBase.ru1[i].ToString();
                        }
                        if (vr2[j] == DataBase.mor2[i])
                        {
                            textBox2.Text += DataBase.ru2[i].ToString();
                        }
                    }
                }
            }
            else
            {
                textBox2.Text += "Неправильно введен ключ.";
            }
        }
    }
}
