using System;
using System.Windows.Forms;

namespace курсовой
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 

        private void Shifr1_Click()
        {
            int key = Convert.ToInt32(numericUpDown1.Value.ToString()); //количество сдвигов
            string s = richTextBox1.Text;//храню слово, которое будем шифровать
            string s1 = "";//храню результат шифрования
            string alf = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";//работаю с английским алфавитом
            string alfphabet = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";//работаю с русским алфавитом
            for (int i = 0; i < s.Length; i++)//цикл перебора букв шифруемого слова
            {
                if (s[i].ToString() == " " || s[i].ToString() == "." || s[i].ToString() == "," || s[i].ToString() == ":" || s[i].ToString() == ";" || s[i].ToString() == "?" || s[i].ToString() == "!") // эти знаки печатаются без зашифровки
                {
                    s1 = s1 + s[i];
                }
                for (int j = 0; j < alfphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
                {
                    if (s[i] == alfphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                    {
                        int temp = j + 2 * key;//номер буквы+сдвиг в темп
                        while (temp >= alfphabet.Length)//чтобы темп не уходил за рамки алфавита
                            temp -= alfphabet.Length;
                        s1 = s1 + alfphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                    }
                }
                for (int j = 0; j < alf.Length; j++)//цикл сравнения каждой буквы с алфавитом
                    if (s[i] == alf[j])
                    {
                        int temp = j + 2 * key;//номер буквы-сдвиг в темп
                        while (temp >= alf.Length)//чтобы темп не уходил за рамки алфавита
                            temp -= alf.Length;
                        s1 = s1 + alf[temp];//заношу зашифрованную букву в переменную для ее хранения
                    }
            }
            richTextBox2.Text = s1;
        }

        private void DeShifr1_Click()
        {
            int key = Convert.ToInt32(numericUpDown1.Value.ToString()); //количество сдвигов
            string s = richTextBox2.Text;//храню слово, которое будем шифровать
            string s1 = "";//храню результат шифрования
            string alf = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";//работаю с английским алфавитом
            string alfphabet = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";//работаю с русским алфавитом
            for (int i = 0; i < s.Length; i++)//цикл перебора букв шифруемого слова
            {
                if (s[i].ToString() == " " || s[i].ToString() == "." || s[i].ToString() == "," || s[i].ToString() == ":" || s[i].ToString() == ";" || s[i].ToString() == "?" || s[i].ToString() == "!") // эти знаки печатаются без зашифровки
                {
                    s1 = s1 + s[i];
                }
                for (int j = 0; j < alfphabet.Length; j++)//цикл сравнения каждой бкувы с алфавитом
                {
                    if (s[i] == alfphabet[j]) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                    {
                        int temp = j - 2 * key + 66;//номер буквы+сдвиг в темп
                        while (temp >= alfphabet.Length)//чтобы темп не уходил за рамки алфавита
                            temp -= alfphabet.Length;
                        s1 = s1 + alfphabet[temp];//заношу зашифрованную букву в переменную для ее хранения
                    }
                }
                for (int j = 0; j < alf.Length; j++)//цикл сравнения каждой буквы с алфавитом
                    if (s[i] == alf[j])
                    {
                        int temp = j - 2 * key;//номер буквы-сдвиг в темп
                        while (temp >= alf.Length)//чтобы темп не уходил за рамки алфавита
                            temp -= alf.Length;
                        s1 = s1 + alf[temp];//заношу зашифрованную букву в переменную для ее хранения
                    }
            }
            richTextBox5.Text = s1;
        }
        private void Shifr2_Click()
        {
            string abc1 = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
            string abc2 = "ЯяЮюЭэЬьЫыЪъЩщШшЧчЦцХхФфУуТтСсРрПпОоНнМмЛлКкЙйИиЗзЖжЁёЕеДдГгВвБбАа";
            string abc3 = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpRrSsTtUuVvWwXxYyZz";
            string abc4 = "ZzYyXxWwVvUuTtSsRrPpOoNnMmLlKkJjIiHhGgFfEeDdCcBbAa";
            string str1 = "";
            string str2 = richTextBox3.Text;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i].ToString() == " " || str2[i].ToString() == "." || str2[i].ToString() == "," || str2[i].ToString() == ":" || str2[i].ToString() == ";" || str2[i].ToString() == "?" || str2[i].ToString() == "!") // эти знаки печатаются без зашифровки
                {
                    str1 = str1 + str2[i];
                }
                for (int l = 0; l < abc1.Length; l++)
                    if (str2[i] == abc1[l])
                    {
                        str1 = str1 + abc2[l];
                    }
                for (int l = 0; l < abc4.Length; l++)
                    if (str2[i] == abc4[l])
                    {
                        str1 = str1 + abc3[l];
                    }
            }
            richTextBox4.Text = str1;
        }

       

        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void цезарьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void ашерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        /* private void о_программеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.Show();
        }*/

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shifr1_Click();
            DeShifr1_Click();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shifr2_Click();
            // Вызов дешифратора

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}