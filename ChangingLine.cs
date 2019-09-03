using System;
using System.Drawing;
using System.Windows.Forms;

namespace Кукина
{
    public partial class ChangingLine : Form
    {
        MainForm mf;
        Club cl;
        int ind;
        public ChangingLine(MainForm f, Club club, int index)
        {
            InitializeComponent();
            MinimumSize = Size;

            //Заполнить поля уже существующими значениями
            textBox1.Text = club.name;
            textBox2.Text = club.adress;
            textBox3.Text = club.place.okrug;
            textBox4.Text = club.place.rayon;
            textBox5.Text = club.form_of_incorporation;
            textBox6.Text = club.submission;
            textBox7.Text = club.tip_uchrezhdeniya;
            textBox8.Text = club.vid_uchrezhdeniya;
            textBox9.Text = club.telephone;
            textBox10.Text = club.web_site;
            textBox11.Text = club.e_mail;
            textBox12.Text = club.place.X.ToString();
            textBox13.Text = club.place.Y.ToString();
            textBox14.Text = club.global_id;

            mf = f;
            cl = club;
            ind = index;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранение текстовых полей в массив
            TextBox[] tbs = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,
            textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14};
            try
            {
                //Изменить кружок
                mf.clubs[ind] = new Club(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,
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
                mf.clubs[ind] = cl;
            }
        }
    }
}
