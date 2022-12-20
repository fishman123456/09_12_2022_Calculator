using System.Security.Cryptography;
using System.Windows.Forms;

namespace _09_12_2022_Calculator
{
    public partial class Form1 : Form
    {


        private double result;
        public double a ;
        char last_char;
       
        public Form1()
        {
            InitializeComponent();
            maskedTextBox1.Text = a.ToString();
        }
        private void button1_Click(object sender, EventArgs e)// TODO файл справки
        {
            MessageBox.Show("Программа калькулятор создан 12-12-2022");
        }

        private void button2_Click(object sender, EventArgs e)// TODO очистка строки
        {
            maskedTextBox1.Text = null;
           
        }

        private void button3_Click(object sender, EventArgs e)// TODO удаление последнего символа
        {
            if (maskedTextBox1.Text.Length > 0)
            {
                maskedTextBox1.Text = maskedTextBox1.Text.Remove(maskedTextBox1.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)// TODO Exit
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)// TODO +
        {
            maskedTextBox1.Text = ProvLastChar('+');
           // maskedTextBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)// TODO -
        {
            maskedTextBox1.Text = ProvLastChar('-');
           // maskedTextBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)// TODO *
        {
            maskedTextBox1.Text = ProvLastChar('*');
           // maskedTextBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)// TODO /
        {
            maskedTextBox1.Text = ProvLastChar('/');
            //maskedTextBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)// TODO 1
        {
            maskedTextBox1.Text += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)// TODO 2
        {
            maskedTextBox1.Text += button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)// TODO 3
        {
            maskedTextBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)// TODO 4
        {
            maskedTextBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)// TODO 5
        {
            maskedTextBox1.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)// TODO 6
        {
            maskedTextBox1.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)// TODO 7
        {
            maskedTextBox1.Text += button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)// TODO 8
        {
            maskedTextBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)// TODO 9
        {
            maskedTextBox1.Text += button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)// TODO 0
        {
            maskedTextBox1.Text += button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)// TODO Резерв2
        {
            maskedTextBox1.Text += button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)// TODO знак "="
        {
            Schet();
            maskedTextBox1.Text = result.ToString();
        }
        public void Schet() // функция для проведения действий с элементами в строке
        {
            string[] b = maskedTextBox1.Text.Split('+', '-', '/', '*');
            try
            {
                if (maskedTextBox1.Text.Contains("+"))
                    result = Convert.ToDouble(b[0]) + Convert.ToDouble(b[1]);

                if (maskedTextBox1.Text.Contains("-"))
                    result = Convert.ToDouble(b[0]) - Convert.ToDouble(b[1]);

                if (maskedTextBox1.Text.Contains("/"))
                    result = Convert.ToDouble(b[0]) / Convert.ToDouble(b[1]);

                if (maskedTextBox1.Text.Contains("*"))
                    result = Convert.ToDouble(b[0]) * Convert.ToDouble(b[1]);

            }
            catch (Exception)
            {
                MessageBox.Show("Так не работает удаляем последний символ!");
                int StartPosDel = maskedTextBox1.SelectionStart;
                int LenSelection = maskedTextBox1.SelectionLength;
                maskedTextBox1.Text = maskedTextBox1.Text.Remove(StartPosDel, LenSelection);

            }
            finally { maskedTextBox1.Text = result.ToString("ghgh"); }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string ProvLastChar(char j) // функция проверки на второй знак действия + - * /
        {
            char[] chars = maskedTextBox1.Text.ToCharArray();
            int numLastChar = chars.Length;
            try
            {
                 last_char = chars[numLastChar - 1];
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число");
                maskedTextBox1.Text.DefaultIfEmpty();

            }

        if (last_char != '+' && last_char != '-' && last_char != '/' && last_char != '*')
            {
                return maskedTextBox1.Text += j;
            }
            else
            {
                return maskedTextBox1.Text;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            maskedTextBox1.SelectAll();

            maskedTextBox1.SelectedText = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

}