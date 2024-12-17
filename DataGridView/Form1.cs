using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text!=""&& label5.Text!=""&&numericUpDown1.Value!=0 &&label6.Text!="")
            dataGridView1.Rows.Add(comboBox1.Text, label5.Text, numericUpDown1.Value, label6.Text);
            comboBox1.Text = "";
            label5.Text =label6.Text= "";
            numericUpDown1.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                label5.Text = "40";
            else if (comboBox1.SelectedIndex == 1)
                label5.Text = "35";
            else if (comboBox1.SelectedIndex == 2)
                label5.Text = "45";
            else if (comboBox1.SelectedIndex == 3)
                label5.Text = "40";
            else if (comboBox1.SelectedIndex == 4)
                label5.Text = "45";
            else if (comboBox1.SelectedIndex == 5)
                label5.Text = "45";
            else if (comboBox1.SelectedIndex == 6)
                label5.Text = "50";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                label6.Text=(int.Parse(label5.Text)*numericUpDown1.Value).ToString();
            }
            catch { }
        }
    }
}
