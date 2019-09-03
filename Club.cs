using System;
using System.Windows.Forms;

namespace Кукина
{
    public class Club
    {
        public string name;
        public string adress;
        public string form_of_incorporation;
        public string submission;
        public string tip_uchrezhdeniya;
        public string vid_uchrezhdeniya;
        public string telephone;
        public string web_site;
        public string e_mail;
        public string global_id;
        public Place place;

        //Проверка на корректность и присваивание значений
        public Club(string _name, string _adress, string okrug, string rayon, string _form_of_incorporation,
            string _submission, string _tip_uchrezhdeniya, string _vid_uchrezhdeniya, string _telephone,
            string _web_site, string _e_mail, string x, string y, string _global_id)
        {
            place = new Place();

            if (_name == "" || Array.TrueForAll(_name.ToCharArray(), (ch) => (ch < 'А' || ch > 'Я') && (ch < 'а' || ch > 'я') &&
            (ch < 'A' || ch > 'Z') && (ch < 'a' || ch > 'z')))
            {
                MessageBox.Show("Имя не может быть пустым или состоять только из символов.");
                throw new Exception("0");
            }
            else
                name = _name;
            if (_adress == "")
                adress = "<Null>";
            else
                adress = _adress;

            if (okrug == "")
                place.okrug = "<Null>";
            else
                place.okrug = okrug;

            if (rayon == "")
                place.rayon = "<Null>";
            else
                place.rayon = rayon;

            if (_form_of_incorporation == "")
                form_of_incorporation = "<Null>";
            else
                form_of_incorporation = _form_of_incorporation;

            if (_submission == "")
                submission = "<Null>";
            else
                submission = _submission;

            if (_tip_uchrezhdeniya == "")
                tip_uchrezhdeniya = "<Null>";
            else
                tip_uchrezhdeniya = _tip_uchrezhdeniya;

            if (_vid_uchrezhdeniya == "")
                vid_uchrezhdeniya = "<Null>";
            else
                vid_uchrezhdeniya = _vid_uchrezhdeniya;


            if (Checker.TelephoneIsCorrect(_telephone) || _telephone == "<Null>")
            {
                telephone = _telephone;
            }
            else if (_telephone == "")
                telephone = "<Null>";
            else
            {
                MessageBox.Show("Телефон имеет вид (ххх) ххх-хх-хх; ххх-хх-хх");
                throw new Exception("8");
            }

            if (_web_site == "")
                web_site = "<Null>";
            else
                web_site = _web_site;

            if (Checker.MailIsCorrect(_e_mail) || _e_mail == "<Null>")
            {
                e_mail = _e_mail;
            }
            else if (_e_mail == "")
                e_mail = "<Null>";
            else
            {
                MessageBox.Show("E-mail имеет вид *@*.*");
                throw new Exception("10");
            }

            if (Checker.CoordinateIsCorrect(x))
            {
                place.X = double.Parse(x);
            }
            else
            {
                MessageBox.Show("Координаты - вещественные числа из интервала (-180, 180)\nПоля с координатами не могут оставаться пустыми");
                throw new Exception("11");
            }
            if (Checker.CoordinateIsCorrect(y))
            {
                place.Y = double.Parse(y);
            }
            else
            {
                MessageBox.Show("Координаты - вещественные числа из интервала (-180, 180)\nПоля с координатами не могут оставаться пустыми");
                throw new Exception("12");
            }

            if (Checker.IdIsCorrect(_global_id))
            {
                global_id = _global_id;
            }
            else
            {
                MessageBox.Show($"id - целое положительное число из интервала ({UInt64.MinValue},{UInt64.MaxValue}\nПоле с id не может оставаться пустыми");
                throw new Exception("13");
            }
        }

        //Создать строку в формате csv, которая описывает данный кружок
        public string MakeString()
        {
            string s = "";
            s += MakeWord(name);
            s += MakeWord(adress);
            s += MakeWord(place.okrug);
            s += MakeWord(place.rayon);
            s += MakeWord(form_of_incorporation);
            s += MakeWord(submission);
            s += MakeWord(tip_uchrezhdeniya);
            s += MakeWord(vid_uchrezhdeniya);
            s += MakeWord(telephone);
            s += MakeWord(web_site);
            s += MakeWord(e_mail);
            s += MakeWord(place.X.ToString());
            s += MakeWord(place.Y.ToString());
            s += MakeWord(global_id);
            return s;
        }

        //Создать слово в формате csv, являющееся частью строки
        private string MakeWord(string word)
        {
            string s = "";
            foreach (char ch in word)
            {
                if (ch == '"')
                    s += "\"\"";
                else
                    s += ch;
            }
            return "\"" + s + "\";";
        }

        //Проверка на корректность и присваивание значений
        public Club(string[] words)
        {
            place = new Place();
            int i = 1;
            name = words[i++];
            adress = words[i++];
            place.okrug = words[i++];
            place.rayon = words[i++];
            form_of_incorporation = words[i++];
            submission = words[i++];
            tip_uchrezhdeniya = words[i++];
            vid_uchrezhdeniya = words[i++];

            if (Checker.TelephoneIsCorrect(words[i]) || words[i] == "<Null>")
            {
                telephone = words[i++];
            }
            else
            {
                throw new Exception();
            }

            web_site = words[i++];

            if (Checker.MailIsCorrect(words[i]) || words[i] == "<Null>")
            {
                e_mail = words[i++];
            }
            else
            {
                throw new Exception();
            }

            try
            {
                place.X = double.Parse(words[i++]);
                place.Y = double.Parse(words[i++]);
            }
            catch
            {
                throw new Exception();
            }

            if (Checker.IdIsCorrect(words[i]) || words[i] == "<Null>")
            {
                global_id = words[i++];
            }
            else
            {
                throw new Exception();
            }
        }

        //Сравнение двух кружков по району
        public static int RayonSort(Club a, Club b)
        {
            return a.place.rayon.CompareTo(b.place.rayon);
        }

        //Сравнение двух кружков по виду учреждения
        public static int VidUchSort(Club a, Club b)
        {
            return a.vid_uchrezhdeniya.CompareTo(b.vid_uchrezhdeniya);
        }

        //Получить расстояние от данного кружка до переданной точки
        public double GetDist(double x, double y)
        {
            return Math.Sqrt((place.X - x) * (place.X - x) + (place.Y - y) * (place.Y - y));
        }


        public static string[] mySplit(string input, int len) //Сплит строки
        {
            string[] output = new string[len];
            int index = 0;
            int j = 0;
            while (input[j] != ';')  //Считать ROWNUM
            {
                output[index] += input[j];
                j++;
            }
            index++;
            for (int i = ++j; i < input.Length; i++)
            {
                if (input[i] == '"')
                {
                    if (input[i + 1] == ';') //Случий, когда встречается ";"
                    {
                        index++;
                        if (i + 2 < input.Length)
                            i += 2;
                        else break;
                    }
                    else if (input[i + 1] == '"') //Случий, когда встречается ""
                    {
                        output[index] += input[i];
                        if (i + 1 < input.Length)
                            i += 1;
                        else break;
                    }
                }
                else
                {
                    output[index] += input[i]; //Добавить букву к слову
                }
            }
            return output;
        }

        //true если кружок удовлетворяет параметру фильтра
        public bool Filter(string s, bool type)
        {
            if (type)
                return form_of_incorporation.ToLower().Contains(s.ToLower()); //f - true
            return vid_uchrezhdeniya.ToLower().Contains(s.ToLower()); //v - false

        }
    }
}
