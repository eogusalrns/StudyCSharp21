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
        Random random = new Random(37);
        public Form1()
        {
            InitializeComponent();
        }

        #region 이벤트핸들러 영역
        private void Form1_Load(object sender, EventArgs e)
        {
            LsvDummy.Columns.Add("Name");
            LsvDummy.Columns.Add("Depth");
            var FontsList = FontFamily.Families;
            foreach (var font in FontsList)
            {
                comboBox1.Items.Add(font.Name);
            }
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

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modal Form",
                Width = 300,
                Height = 100,
                BackColor = Color.Red
            };
            frm.ShowDialog();//모달창 띠우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form
            {
                Text = "Modaless From",
                Width = 300,
                Height = 300,
                BackColor = Color.Green
            };
            frm.Show();//모달리스창 띠우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //모달창 메시지박스
            MessageBox.Show(textBox1.Text, "타이틀", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //MessageBox.Show("누르지마시오","나는타이틀");
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(random.Next().ToString());
            DisplayTreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("선택된 노드가 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            TrvDummy.SelectedNode.Expand();
            DisplayTreeToList();
        }
        #endregion

        #region 사용자메서드 영역
        private void ChangeFont()
        {
            if (comboBox1.SelectedIndex < 0) return;

            FontStyle style = FontStyle.Regular;
            if (checkBox1.Checked) style |= FontStyle.Bold;//00000001
            if (checkBox2.Checked) style |= FontStyle.Italic;//00000010
            textBox1.Font = new Font((string)comboBox1.SelectedItem, 14, style);

        }

        private void DisplayTreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                DisplayTreeToList(node);
            }
        }

        private void DisplayTreeToList(TreeNode node)
        {
            LsvDummy.Items.Add(new ListViewItem(new string[] {node.Text,node.FullPath }));

            foreach (TreeNode item in node.Nodes)
            {
                DisplayTreeToList(item);
            }
        }

        #endregion




    }
}
