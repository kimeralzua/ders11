using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("A-Z");
            comboBox1.Items.Add("Z-A");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int eleman = listBox1.Items.Count;
            string[] listele = new string[eleman];
            for (int i = 0; i < eleman; i++)
            {
                listele[i] = listBox1.Items[i].ToString();
            }
            Array.Sort(listele);
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < listele.Length; i++)
                {
                    listBox1.Items.Add(listele[i]);
                }
            }
            else
            {
                Array.Reverse(listele);
                listBox1.Items.Clear();
                for (int i = 0; i < listele.Length; i++)
                {
                    listBox1.Items.Add(listele[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}

