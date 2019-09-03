using System;

namespace Кукина
{
    static class Checker
    {        
        //Проверка корректности номера телефона
        public static bool TelephoneIsCorrect(string s)
        {
            int i = 0;
            bool possibleOneMore = true;
            while (i < s.Length)
            {
                //Если это возможный символ
                if ((s[i] >= '0' && s[i] <= '9') || s[i] == '(' || s[i] == ')' || s[i] == ' ' || s[i] == '-' || s[i] == ';')
                {
                    while (s[i] == ' ') i += 1; //пропускаем пробелы
                    switch (s[i])
                    {
                        case '(': //если это скобка, значит, это может быть телефон вида (ххх) ххх-хх-хх
                            if (possibleOneMore)
                            {
                                if (CheckPhoneType1(s, ref i)) possibleOneMore = false;
                                else return false;
                            }
                            else return false;
                            break;
                        case ';': //Означает, что в строке может быть еще один телефон
                            if (s[i] == ';')
                            {
                                possibleOneMore = true;
                                i++;
                            }
                            break;
                        default: //телефон вида ххх-хх-хх
                            if (possibleOneMore)
                            {
                                if (CheckPhoneType2(s, ref i)) possibleOneMore = false;
                                else return false;
                            }
                            else return false;
                            break;
                    }
                }
                else return false;
            }
            if (!possibleOneMore)
                return true;
            return false;
        }

        private static bool CheckPhoneType1(string s, ref int i)
        {
            if (s[i] == '(' && s[i + 4] == ')') //Type1 (xxx) xxx-xx-xx
            {
                int n;
                if (int.TryParse(s.Substring(i + 1, 3), out n)
                    && Array.TrueForAll(s.Substring(i + 1, 3).ToCharArray(), (char ch) => ch <= '9' && ch >= '0'))
                {
                    i += 5;
                    while (s[i] == ' ') i += 1;
                    return CheckPhoneType2(s, ref i);
                }
            }
            return false;
        }

        private static bool CheckPhoneType2(string s, ref int i)
        {
            try
            {
                int n;
                if (int.TryParse(s.Substring(i, 3), out n)
                    && Array.TrueForAll(s.Substring(i, 2).ToCharArray(), (char ch) => ch <= '9' && ch >= '0')) //xxx
                {
                    i += 3;
                    while (s[i] == ' ') i += 1;
                    if (s[i] == '-')
                    {
                        i++;
                        while (s[i] == ' ') i += 1;
                        if (int.TryParse(s.Substring(i, 2), out n)
                            && Array.TrueForAll(s.Substring(i, 2).ToCharArray(), (char ch) => ch <= '9' && ch >= '0')) //-xx
                        {
                            i += 2;
                            while (s[i] == ' ') i += 1;
                            if (s[i] == '-')
                            {
                                i++;
                                while (s[i] == ' ') i += 1;
                                if (int.TryParse(s.Substring(i, 2), out n)
                                    && Array.TrueForAll(s.Substring(i, 2).ToCharArray(), (char ch) => ch <= '9' && ch >= '0')) //-xx
                                {
                                    i += 2;
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch { return false; }
            return false;
        }

        //Проверка на корректность почты *@*.*
        public static bool MailIsCorrect(string s)
        {
            bool isCorrect = false;
            try
            {
                int k = -1;
                int i = 0;
                while (s[i] == ' ') { i++; } //пропуск пробелов
                while (i < s.Length)
                {
                    if (s[i] == '@')
                    {
                        if (i == 0) //если @ - первый символ
                            return false;
                        else
                        {
                            if (k == -1)
                                k = i++; //запоминаем позицию @
                            else
                                return false; //если встречается второй символ @
                        }
                    }
                    else if (s[i] == '.') 
                    {
                        if (i == 0) return false; //если . первый символ
                        if (i > k + 1)
                        {
                            if (s[i + 1] != ' ' && s[i - 1] != '.' && s[i + 1] != '.') //если . не последний символ и подряд не стоит несколько .
                            {
                                isCorrect = true;
                                i++;
                            }
                        }
                        else
                        {
                            if (s[i - 1] != '.' && s[i + 1] != '.' && s[i - 1] != '@' && s[i + 1] != '@') //если не .. и не .@ @.
                            {
                                i++;
                            }
                            else return false;
                        }
                    }
                    else if ((s[i] < 'a' || s[i] > 'z') && (s[i] < 'A' || s[i] > 'Z') &&
                        (s[i] < '0' || s[i] > '9') &&
                        Array.TrueForAll(new char[] { '-', '_' }, (ch) => s[i] != ch))
                        return false; //если встречаются недопустимые символы
                    else if (i == 0 && ((s[i] >= '0' && s[i] <= '9') || s[i] == '-')) //если начинается не с буквы
                        return false;
                    else { i++; }
                }
            } 
            catch
            {
                return false;
            }
            if (isCorrect)
                return true;
            return false;
        }

        //Проверка на корректность координат
        public static bool CoordinateIsCorrect(string s)
        {
            double a = 0;
            bool res = double.TryParse(s, out a);
            if (!res) return false;
            if (a < -180 || a > 180)
                return false;
            return true;
        }

        //Проверка на корректность id
        public static bool IdIsCorrect(string s)
        {
            ulong a;
            return ulong.TryParse(s, out a);
        }
    }
}
