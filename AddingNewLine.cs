using System;
using System.Drawing;
using System.Windows.Forms;

namespace Кукина
{
    public partial class AddingNewLine : Form
    {
        MainForm mf;
        public AddingNewLine(MainForm f)
        {
            mf = f;
            InitializeComponent();
            MinimumSize = Size;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранение текстовых полей в массив
            TextBox[] tbs = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,
            textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14};
            Array.Resize(ref mf.clubs, mf.clubs.Length + 1);
            try
            {
                //Создание нового кружка
                mf.clubs[mf.clubs.Length - 1] = new Club(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
                    textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text,
                    textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text);

                mf.FillTable(mf.clubs);
                mf.CancelFiltersMethod();
                this.Close();
            }
            catch (Exception ex)
            {
                //Подсветить красным ошибочное поле и вывести указания об ошибке
                foreach (TextBox tb in tbs)
                    tb.BackColor = Color.White;
                int num;
                if (int.TryParse(ex.Message, out num))
                    tbs[num].BackColor = Color.Tomato;
                Array.Resize(ref mf.clubs, mf.clubs.Length - 1);
            }            
        }
    }
}
