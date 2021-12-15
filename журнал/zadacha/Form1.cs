using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { textBox1.Text = "3";
                textBox3.Text = "Информационные сети";
            }
            if (comboBox1.SelectedIndex == 1)
            { textBox1.Text = "3";
                textBox3.Text = "Компьютерные сети";
            }
            else
            { textBox1.Text = "3";
                textBox3.Text = "Электрические сети";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
