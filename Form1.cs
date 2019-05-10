using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // funkcja pozwalająca wyszukać plik
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text; // wyświetla nazwe piosenki w odtwarzaczu
        }

        private void button2_Click(object sender, EventArgs e) // button pozwalający na odtwarzanie
        {
            Player.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e) // button pozwalajacy na zapauzowanie
        {
            Player.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e) // button pozwalający na zastopowanie
        {
            Player.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e) // button zamykający aplikacje
        {
            Close();
        }
    }
}
