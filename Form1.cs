using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form

    {
        readonly Dictionary<char, char> m = new Dictionary< char, char>();
        public Form1()
        {
            InitializeComponent();
            m['а'] = 'a';
            m['б'] = 'b';
            m['в'] = 'v'; 
            m['г'] = 'g';
            m['д'] = 'd';
            m['е'] = 'e';
            m['ё'] = 'y';
            m['ж'] = 'z';
            m['з'] = 'z';
            m['и'] = 'i';
            m['й'] = 'j';
            m['к'] = 'k';
            m['л'] = 'l';
            m['м'] = 'm';
            m['н'] = 'n';
            m['о'] = 'o';
            m['п'] = 'p';
            m['р'] = 'r';
            m['с'] = 's';
            m['т'] = 't';
            m['у'] = 'u';
            m['ф'] = 'f';
            m['х'] = 'x';
            m['ц'] = 'c';
            m['ч'] = 'h';
            m['ш'] = 'w';
            m['ъ'] = 'ъ';
            m['ы'] = 'ы';
            m['ь'] = 'ь';
            m['э'] = 'e';
            m['ю'] = 'ю';
            m['я'] = 'я';

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach (char c in textBox1.Text)
                textBox2.Text += (m[c]); 
        }
    }
}
