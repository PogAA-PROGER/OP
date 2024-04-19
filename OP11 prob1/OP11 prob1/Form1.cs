using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Windows.Forms;

namespace _11._2
{
    public struct Znak
    {
        public string fio;
        public string znaks;
        public string date;

        public override string ToString()
        {
            return $"{fio} - {znaks} - {date}";
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            File.WriteAllText(filePath, string.Empty);
            GeneratePeople();
            Files(filePath, birthdateList);
            FileRead(filePath);
        }
        string filePath = @"C:\Users\Саша\Desktop\1.txt";
        List<string> fnameList = new List<string> { "Георгий", "Кирилл", "Евгений", "Александр", "Артём", "Павел", "Сергей", "Антон", "Игорь", "Ярослав" };
        List<Znak> noteNumber = new List<Znak>();
        List<Znak> birthdateList = new List<Znak>();
        List<string> lnameList = new List<string> { "Воронин", "Погодин", "Пупкин", "Попов", "Пуджев", "Купец", "Дирихле", "Брагин", "Забейворота", "Нам"    };
        List<string> zodiac = new List<string> { "Лев", "Рак", "Козерог", "Водолей", "Близнецы", "Рыбы", "Телец", "Овен", "Скорпион", "Дева", "Весы", "Стрелец" };
        private void GeneratePeople()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                string FIO = fnameList[rand.Next(0, fnameList.Count)] + " " + lnameList[rand.Next(0, lnameList.Count)];
                string birthdate = (rand.Next(1, 28)).ToString() + "." + (rand.Next(1, 12)).ToString() + "." + (rand.Next(1950, 2023)).ToString();
                string Znakz = zodiac[rand.Next(0, zodiac.Count)];

                Znak person = new Znak { fio = FIO, znaks = Znakz, date = birthdate };
                birthdateList.Add(person);
            }
        }
        private void Search(string person, List<Znak> sortedBirthdateList)
        {
            IOrderedEnumerable<Znak> sortedList = birthdateList.Where(a => a.znaks == person).OrderBy(a => a.fio);
            List<Znak> listResult = new List<Znak>();
            if (sortedList.Any())
            {
                listResult = sortedList.ToList();
                resulted.DataSource = listResult;
                resulted.DisplayMember = "{fio} - {znaks} - {date}";
            }
            else
            {
                MessageBox.Show($"{person} не существует");
            }
        }
        private void Files(string filePath, List<Znak> birthdateList)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Znak person in birthdateList)
                {
                    writer.WriteLine($"{person.fio}, Знак зодиака: {person.znaks}, Дата рождения: {person.date}");
                }
            }
        }
        private void FileRead(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                all.Items.Add(line);
            }
        }
        private void labelPlaneModel_Click(object sender, EventArgs e)
        {

        }

        private void resulted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phonenubmer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Znak> sortedBirthdateList = birthdateList.OrderBy(a => a.fio).ToList();

            all.DataSource = sortedBirthdateList;
            resulted.DisplayMember = "{fio} - {number} - {date}";
        }

        private void all_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            string person = zodiact.Text;
            List<Znak> sortedBirthdateList = birthdateList.OrderBy(a => a.fio).ToList();
            Search(person, sortedBirthdateList);
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}