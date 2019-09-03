using System;
using System.Windows.Forms;

namespace Кукина
{
    public partial class NumberOfLines : Form
    {
        MainForm mf;
        string p;
        public NumberOfLines(MainForm mainForm, string path)
        {
            InitializeComponent();
            MinimumSize = MaximumSize = Size;
            mf = mainForm;
            p = path;
            try
            {
                numericUpDown1.Maximum = System.IO.File.ReadAllLines(path).Length - 1; //Получить количество строк
            }
            catch { Close(); }
        }

        //Если пользователь сам задает количество строк
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }

        //Если выводить все строки
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
        }

        //Получение количества выводимых строк
        private void button1_Click(object sender, EventArgs e)
        {
            int GetNumberOfLines;
            if (radioButton2.Checked)
                GetNumberOfLines = (int)numericUpDown1.Value;
            else GetNumberOfLines = (int)numericUpDown1.Maximum;
            mf.ParseFile(p, GetNumberOfLines);
            Close();
        }
    }
}
