using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pr22_3
{
    class SportLIFE
    {
        public string name = "Пусто";
        public string surname = "Пусто";
        public string family = "Пусто";
        public string gender = "Не выбран";
        public int age;
        public short rost;
        public short ves;
        public string vidsport = "Пусто";
        public int idealvesb = 0;
        public double idealveskup = 0;
        public string Info(string gender1)
        {
            gender = gender1;
            string sportman = "Спортсмен: " + family + " " + name + " " + surname + "\n" + "Возраст: " + age + "\n" + "Рост: " + rost + "\n" + "Вес: " + ves + "\n" + "Вид спорта: " + vidsport + "\n" + "Пол: " + gender + "\n" + "Идеальный вес по формуле Брока: " + idealvesb + "\n" + "Идеальный вес по формуле Купера: " + Math.Round(idealveskup, 3);
            return sportman;
        }
        public int IdealVes()
        {
            if (age <= 40) idealvesb = rost - 110;
            else idealvesb = rost - 100;
            return idealvesb;
        }
        public double IdealVes2(string gender1)
        {
            gender = gender1;
            if (gender == "Мужской")
            {
                idealveskup = (rost * 4 / 2.54 - 128) * 0.453;
            }
            else idealveskup = (rost * 3.5 / 2.54 - 108) * 0.453;
            return idealveskup;
        }
        public bool Scan(string name1, string familyname1, string surname1, DateTime data, short rost1, short ves1, string vsport)
        {
            DateTime now = DateTime.Today;
            int age1 = now.Year - data.Year;
            if (data > now.AddYears(-age1)) age1--;
            bool scan = true;
            char[] scanname = name1.ToCharArray();
            char[] scanfamily = familyname1.ToCharArray();
            char[] scansurname = surname1.ToCharArray(); 
            char[] scanvsport = vidsport.ToCharArray();
            if (name1.Replace(" ", "") != "" && familyname1.Replace(" ", "") != "" && surname1.Replace(" ", "") != "" && vsport.Replace(" ", "") != "")
            {
                for (int i = 0; i < scanname.Length; i++)
                {
                    if (!Char.IsLetter(scanname[i]))
                    {
                        MessageBox.Show("Некорректный ввод имени", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }
                for (int i = 0; i < scanfamily.Length; i++)
                {
                    if (!Char.IsLetter(scanfamily[i]))
                    {
                        MessageBox.Show("Некорректный ввод фамилии", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;

                    }
                }
                for (int i = 0; i < scansurname.Length; i++)
                {
                    if (!Char.IsLetter(scansurname[i]))
                    {
                        MessageBox.Show("Некорректный ввод отчества", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }
                for (int i = 0; i < vsport.Length; i++)
                {
                    if (!Char.IsLetter(vsport[i]))
                    {
                        MessageBox.Show("Некорректный ввод строки (вид спорта)", "Сообщение", MessageBoxButtons.OK);
                        scan = false;
                        break;
                    }
                }
                if (rost1 > 0 && rost1 < 230)
                {
                    rost = rost1;
                }
                else
                {
                    MessageBox.Show("Рост введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }
                if (ves1 > 0 && ves1 < 150)
                {
                    ves = ves1;
                }
                else
                {
                    MessageBox.Show("Вес введен неправильно", "Сообщение", MessageBoxButtons.OK);
                    scan = false;
                }
                if (scan)
                {
                    name = name1;
                    surname = surname1;
                    family = familyname1;
                    vidsport = vsport;
                    age = age1;
                }
                return scan;
            }
            else
            {
                MessageBox.Show("Найдены пустая строка(и)", "Сообщение", MessageBoxButtons.OK);
                scan = false;
                return scan;
            }

        }
    }
}
