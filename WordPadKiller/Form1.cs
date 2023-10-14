#nullable disable

using System.Windows.Forms;

namespace WordPadKiller
{
    public partial class Form1 : Form
    {
        FontDialog fontDialog1 = new();
        ColorDialog colorDialog1 = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Font_btn_Click(object sender, EventArgs e)
        {
            var result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void Color_btn_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    if (File.Exists(filePath))
                    {
                        string textToLoad = File.ReadAllText(filePath);
                        richTextBox1.Text = textToLoad;
                    }
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string textToSave = richTextBox1.Text;
                    File.WriteAllText(filePath, textToSave);
                }
            }
        }
    }
}