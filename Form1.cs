using System;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Кукина
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MinimumSize = Size;
        }

        public Club[] clubs = new Club[0]; //Массив кружков
        Club[] temp = new Club[0]; //Отфильтрованный массив кружков
        int filtered = 0; //1 - true(f), 2 - false(v)
        string filtString = ""; //параметр фильрации
        string savingPath = ""; //путь к файлу

        public string[] headers = new string[] { "ROWNUM", "name", "adress", "okrug", "rayon",
            "form_of_incorporation", "submission", "tip_uchrezhdeniya", "vid_uchrezhdeniya",
            "telephone", "web_site", "e_mail", "X", "Y", "global_id" }; //заголовки колонок

        //Метод для открытия файла
        private void Open_File(object sender, EventArgs e)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    savingPath = ofd.FileName;
                    NumberOfLines nol = new NumberOfLines(this, ofd.FileName); //Получение информации о  количестве выводимых строк
                    nol.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Сделать активными кнопки после открытия или создания файла
        private void EnableButtons()
        {
            filtered = 0;
            CancelFilters.Enabled = false;
            FiltersBut.Enabled = true;
            ChangeBut.Enabled = true;
            SortBut.Enabled = true;
            Save.Enabled = true;
            SaveAs.Enabled = true;
            Append.Enabled = true;

            SaveT.Enabled = true;
            SaveAsT.Enabled = true;
            AddT.Enabled = true;
            ChangeT.Enabled = true;
            DeleteT.Enabled = true;
            AppendT.Enabled = true;

        }

        //Преобразование файла в массив кружков и таблицу
        public void ParseFile(string path, int numOfLines)
        {
            try
            {
                clubs = new Club[numOfLines];
                string[] lines = File.ReadAllLines(path); //Считать файл
                if (lines.Length > 0)
                {
                    for (int i = 1; i <= numOfLines; i++)  //Пройтись по строкам файла
                    {
                        string[] words = Club.mySplit(lines[i], headers.Length); //Сплит строки
                        try
                        {
                            clubs[i - 1] = new Club(words);
                        }
                        catch
                        {
                            MessageBox.Show("Некорректные данные в файле");
                        }
                    }
                    FillTable(clubs); //Заполнить таблицу
                    EnableButtons(); //Активировать кнопки
                }
                else
                {
                    MessageBox.Show("Файл пустой");
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Сохранить в текущий файл
        private void SaveFile_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (savingPath == "")
                    SaveAs_Click(this, new EventArgs());
                else
                    SaveMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Сохранить в новый файл
        private void SaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                if (clubs.Length != 0)
                    SaveAsMethod();
                else
                    MessageBox.Show("Таблица пустая");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Метод для сохранения в новый файл
        private void SaveAsMethod()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.csv";
            sfd.DefaultExt = "csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                savingPath = sfd.FileName;
                using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
                {
                    sw.Write(MakeFile());
                }
            }
        }

        //Метод для сохранения в текущий файл
        private void SaveMethod()
        {
            using (StreamWriter sw = new StreamWriter(savingPath))
            {
                sw.Write(MakeFile());
            }
        }

        //Создать файл в формате csv
        private string MakeFile()
        {
            Club[] _clubs = null;
            if (filtered == 0)
                _clubs = clubs;
            else _clubs = temp;

            int k = 1;
            string str = "";
            foreach (string header in headers)
                str += header + ";";
            str += "\n";
            foreach (Club cl in _clubs)
            {
                str += k.ToString() + ";" + cl.MakeString() + "\n";
                k++;
            }
            return str;
        }

        //Создать файл в формате csv для дозаписи
        private string MakeFile(int k)
        {
            Club[] _clubs = null;
            if (filtered == 0)
                _clubs = clubs;
            else _clubs = temp;

            string str = "";
            foreach (Club cl in _clubs)
            {
                str += k.ToString() + ";" + cl.MakeString() + "\n";
                k++;
            }
            return str;
        }

        //Дабовить новую запись
        private void AddNewLine(object sender, EventArgs e)
        {
            AddingNewLine addingNewLine = new AddingNewLine(this);
            addingNewLine.ShowDialog();
        }

        int k1 = 0; //Какой раз была нажата кнопка сортировки

        //Сортировка по району
        private void SortRayon_Click(object sender, EventArgs e)
        {
            if (filtered == 0) //если массив не отфильтрован
            {
                Array.Sort(clubs, Club.RayonSort);
                if (k1 % 2 != 0)
                    Array.Reverse(clubs);
                k1++;
                FillTable(clubs);
            }
            else //при отфильтрованном массиве
            {
                Array.Sort(temp, Club.RayonSort);
                Array.Sort(clubs, Club.RayonSort);
                if (k1 % 2 != 0)
                {
                    Array.Reverse(temp);
                    Array.Sort(clubs, Club.RayonSort);
                }
                k1++;
                FillTable(temp);
            }
        }

        int k2 = 0; //Какой раз была нажата кнопка сортировки

        //Сортировка по виду учреждения
        private void SortVidUch_Click(object sender, EventArgs e)
        {
            if (filtered == 0) //если массив не отфильтрован
            {
                Array.Sort(clubs, Club.VidUchSort);
                if (k2 % 2 != 0)
                    Array.Reverse(clubs);
                k2++;
                FillTable(clubs);
            }
            else //при отфильтрованном массиве
            {
                Array.Sort(temp, Club.VidUchSort);
                Array.Sort(clubs, Club.VidUchSort);
                if (k2 % 2 != 0)
                {
                    Array.Reverse(temp);
                    Array.Sort(clubs, Club.VidUchSort);
                }
                k2++;
                FillTable(temp);
            }
        }

        //Получить координаты точки, относительно которой будет выполняться сортировка
        private void SortDist_Click(object sender, EventArgs e)
        {
            PointForm pointForm = new PointForm(this);
            pointForm.Show();
        }

        //Отсортировать массив по удаленности
        public void SortByDistance(double x, double y)
        {
            if (filtered == 0) //если массив не отфильтрован
            {
                SortByDistance1(x, y, clubs);
                FillTable(clubs);
            }
            else //при отфильтрованном массиве
            {
                SortByDistance1(x, y, temp);
                SortByDistance1(x, y, clubs);
                FillTable(temp);
            }
        }

        //реализует сортировку для определенного моссива относительно удаленности от переданной точки
        private void SortByDistance1(double x, double y, Club[] clubs)
        {
            double[] dists = new double[clubs.Length];
            double tempVal;
            Club t;
            for (int i = 0; i < clubs.Length; i++)
            {
                dists[i] = clubs[i].GetDist(x, y);
            }

            for (int i = 0; i < clubs.Length - 1; i++)
            {
                for (int j = i + 1; j < clubs.Length; j++)
                {
                    if (dists[i] < dists[j])
                    {
                        tempVal = dists[i];
                        dists[i] = dists[j];
                        dists[j] = tempVal;

                        t = clubs[i];
                        clubs[i] = clubs[j];
                        clubs[j] = t;
                    }
                }
            }
        }

        //Осуществляет фильтрацию по переданной строку по определенного типу
        public void doFilter(string s, bool type)
        {
            temp = new Club[0]; //новый массив, в котором хранятся записи, удовлетворяющие параметру сортировки
            int k = 0;
            filtString = s;
            for (int i = 0; i < clubs.Length; i++)
            {
                if (clubs[i].Filter(s, type)) //если кружок подходит, добавляем его в новый массив
                {
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[k++] = clubs[i];
                }
            }
            if (type) //отмечаем тип, по которому происходила фильтрация
                filtered = 1;
            else filtered = 2;
            FillTable(temp);
            CancelFilters.Enabled = true; //активируем кнопку для отмены фильтрации
        }

        //Фильтровать по форме регистрации
        private void FilterFormOfIncorpBut_Click(object sender, EventArgs e) //1
        {
            Filter f = new Filter(this, true); //Запросить параметр фильтра
            f.ShowDialog();
        }

        //Фильтровать по виду учреждения
        private void FilterVidUchrBut_Click(object sender, EventArgs e) //2
        {
            Filter f = new Filter(this, false); //Запросить параметр фильтра
            f.ShowDialog();
        }

        //Заполнить таблицу заголовками
        private void FillHeaders(ref DataTable dt)
        {
            foreach (string header in headers)
            {
                if (header != "")
                    dt.Columns.Add(new DataColumn(header));
            }
        }

        //Создать новый пустой файл
        private void CreateNew_Click(object sender, EventArgs e)
        {
            savingPath = "";
            clubs = new Club[0];
            FillTable(clubs);
            EnableButtons();
        }

        //При нажатии на кнопку отмены фильтров 
        private void CancelFilters_Click(object sender, EventArgs e)
        {
            CancelFiltersMethod();
        }

        //Отмена фильтров
        public void CancelFiltersMethod()
        {
            filtered = 0;
            CancelFilters.Enabled = false;
            FillTable(clubs);
        }

        //Заполнить таблицу элементами из переданного массива
        public void FillTable(Club[] clubs)
        {
            DataTable dt = new DataTable();
            FillHeaders(ref dt);
            for (int i = 0; i < clubs.Length; i++)
            {
                if (clubs[i] != null)
                {
                    int k = 0;
                    DataRow dr = dt.NewRow();
                    dr[k++] = dt.Rows.Count + 1;
                    dr[k++] = clubs[i].name;
                    dr[k++] = clubs[i].adress;
                    dr[k++] = clubs[i].place.okrug;
                    dr[k++] = clubs[i].place.rayon;
                    dr[k++] = clubs[i].form_of_incorporation;
                    dr[k++] = clubs[i].submission;
                    dr[k++] = clubs[i].tip_uchrezhdeniya;
                    dr[k++] = clubs[i].vid_uchrezhdeniya;
                    dr[k++] = clubs[i].telephone;
                    dr[k++] = clubs[i].web_site;
                    dr[k++] = clubs[i].e_mail;
                    dr[k++] = clubs[i].place.X;
                    dr[k++] = clubs[i].place.Y;
                    dr[k++] = clubs[i].global_id;
                    dt.Rows.Add(dr);
                }
            }
            dataGridView1.DataSource = dt;
        }

        //Удаление строки
        private void DeleteLine_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteClub(dataGridView1.CurrentCell.RowIndex);
            }
            catch
            {
                MessageBox.Show("Сначала выберите строку");
            }
        }

        //Реализация удаления строки
        private void DeleteClub(int index)
        {
            if (filtered == 0) //если массив не отфильрован
            {
                DeleteClub1(index);
                FillTable(clubs);
            }
            else if (filtered == 1) //если массив отфильтрован
            {
                DeleteClub2(index, true);
            }
            else
            {
                DeleteClub2(index, false);
            }
        }

        //Удаление элемента массива по переданному индексу и сдвиг всех последующих элементов массива
        private void DeleteClub1(int index)
        {
            for (int i = index; i < clubs.Length - 1; i++)
            {
                clubs[i] = clubs[i + 1];
            }
            Array.Resize(ref clubs, clubs.Length - 1);
        }

        //Удаление элемента отфильрованного массива по переданному индексу и сдвиг всех последующих элементов массива
        //То же самое с этим элементом в неотфильтрованном массиве
        private void DeleteClub2(int index, bool type)
        {
            for (int i = index; i < temp.Length - 1; i++)
            {
                temp[i] = temp[i + 1];
            }
            DeleteClub1(FindIndexOfFilteredList(index, type));
            Array.Resize(ref temp, temp.Length - 1);
            FillTable(temp);
        }

        //Получить индекс элемента отфильтрованного массива в нефильтрованном
        private int FindIndexOfFilteredList(int index, bool type)
        {
            int k = -1;
            for (int i = 0; i < clubs.Length; i++)
            {
                if (clubs[i].Filter(filtString, type))
                    k++;
                if (k == index)
                    return i;
            }
            return 0;
        }

        //Изменение записи
        private void ChangingTheLine(object sender, EventArgs e)
        {
            try
            {
                //Отмена фильтров и поиск данного элемента в нефильтрованном массиве
                int index = dataGridView1.CurrentCell.RowIndex;
                if (filtered == 1)
                {
                    index = FindIndexOfFilteredList(index, true);
                    CancelFiltersMethod();
                }
                else if (filtered == 2)
                {
                    index = FindIndexOfFilteredList(index, false);
                    CancelFiltersMethod();
                }

                //Изменение строки
                ChangingLine cl = new ChangingLine(this, clubs[index], index);
                cl.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Сначала выберите строку");
            }
        }

        //Дозаписать в файл
        private void Append_Click(object sender, EventArgs e)
        {
            if (clubs.Length != 0)
                SaveToMethod();
            else
                MessageBox.Show("Таблица пустая");
        }

        //Реализация дозаписи в файл
        private void SaveToMethod()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "*.csv";
            ofd.DefaultExt = "csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int k = File.ReadAllLines(ofd.FileName).Length - 1;

                using (StreamWriter sw = File.AppendText(ofd.FileName))
                {
                    sw.Write(MakeFile(k));
                }
            }
        }
    }
}