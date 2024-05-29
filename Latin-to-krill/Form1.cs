using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_to_krill
{
    public partial class Form1 : Form
    {
        private string[] k = {
            " е", "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я",
            " Е", "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я"
        };

        // Lotincha harflar
        private string[] l = {
            "ye", "a", "b", "v", "g", "d", "e", "yo", "j", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "x", "ts", "ch", "sh", "shch", "", "i", "'", "e", "yu", "ya",
            "YE", "A", "B", "V", "G", "D", "E", "Yo", "J", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "X", "Ts", "Ch", "Sh", "Shch", "", "I", "'", "E", "Yu", "Ya"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            string output = ConvertText(input);
            richTextBox2.Text = output;
        }

        private string ConvertText(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                bool matched = false;
                for (int j = 0; j < k.Length; j++)
                {
                    if (input.Substring(i, Math.Min(k[j].Length, input.Length - i)) == k[j])
                    {
                        output += l[j];
                        i += k[j].Length - 1;
                        matched = true;
                        break;
                    }
                }
                if (!matched)
                {
                    output += input[i];
                }
            }
            return output;
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel2.Width = (int)(this.Width * 0.5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
