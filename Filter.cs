using System;
using System.Drawing;
using System.Windows.Forms;

namespace Кукина
{
    public partial class Filter : Form
    {
        MainForm mf;
        bool t;

        public Filter(MainForm f, bool type)
        {
            mf = f;
            t = type;
            InitializeComponent();
            MinimumSize = MaximumSize = Size;
        }

        //Получение параметра фильтрации
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") //Если поле пустое, окрасить в красный и сообщить об ошибке
            {
                textBox1.BackColor = Color.Tomato;
                MessageBox.Show("Нельзя оставить поле пустым");
            }
            else //Иначе наложить фильтр
            {
                textBox1.BackColor = Color.White;
                mf.doFilter(textBox1.Text, t);
                this.Close();
            }
        }
    }
}
