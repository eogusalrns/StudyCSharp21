using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControlsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                comboBox1.Items.Add(font.Name);

            }
        }

        private void ChangeFont()
        {
            if (comboBox1.SelectedIndex < 0) return;

            FontStyle style = FontStyle.Regular;
            if (checkBox1.Checked) style |= FontStyle.Bold;//00000001
            if (checkBox2.Checked) style |= FontStyle.Italic;//00000010
            textBox1.Font = new Font((string)comboBox1.SelectedItem,14,style);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TrB1_Scroll(object sender, EventArgs e)
        {
            PrG1.Value = TrB1.Value;
        }
    }
}
