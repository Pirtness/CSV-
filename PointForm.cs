using System;
using System.Drawing;
using System.Windows.Forms;

namespace Кукина
{
    public partial class PointForm : Form
    {
        MainForm mf;
        public PointForm(MainForm mainForm)
        {
            mf = mainForm;
            InitializeComponent();
            MinimumSize = MaximumSize = Size;
        }

        //Получение координат точки для сортировки по удаленности
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Checker.CoordinateIsCorrect(textBox1.Text))
                    throw new Exception("1");
                if (!Checker.CoordinateIsCorrect(textBox2.Text))
                    throw new Exception("2");
                mf.SortByDistance(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
                this.Close();
            }
            catch (Exception ex)
            {
                //При неверных координатах окрасить поля в красный и сообщить об ошибке
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                if (ex.Message == "1")
                    textBox1.BackColor = Color.Tomato;
                else if (ex.Message == "2")
                    textBox2.BackColor = Color.Tomato;
                MessageBox.Show("Координаты - вещественные числа из интервала (-180, 180)\nПоля с координатами не могут оставаться пустыми");
            }
        }
    }
}
