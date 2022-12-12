using System.Windows.Forms;

namespace _09_12_2022_Calculator
{
    public partial class Form1 : Form
    {
        public string last;
        bool flag_d = false;
        private double result;
        private double a = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = a.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)// TODO text
        {

        }

        private void button1_Click(object sender, EventArgs e)// TODO файл справки
        {
            MessageBox.Show("Программа калькулятор");
        }

        private void button2_Click(object sender, EventArgs e)// TODO очистка строки
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)// TODO удаление последнего символа
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)// TODO Exit
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)// TODO +
        {
                textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)// TODO -
        {
                textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)// TODO *
        {
                textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)// TODO /
        {
                textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)// TODO 1
        {
            textBox1.Text += button9.Text;
        }
        private void button10_Click(object sender, EventArgs e)// TODO 2
        {
            textBox1.Text += button10.Text;
        }
        private void button11_Click(object sender, EventArgs e)// TODO 3
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)// TODO 4
        {
            textBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)// TODO 5
        {
            textBox1.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)// TODO 6
        {
            textBox1.Text += button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)// TODO 7
        {
            textBox1.Text += button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)// TODO 8
        {
            textBox1.Text += button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)// TODO 9
        {
            textBox1.Text += button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)// TODO Резерв1
        {

        }

        private void button19_Click(object sender, EventArgs e)// TODO Резерв2
        {

        }

        private void button20_Click(object sender, EventArgs e)// TODO знак "="
        {

        }
        public bool Schet()
        {
            string[] b = textBox1.Text.Split('+', '-', '/', '*');

            if (textBox1.Text.Contains("+"))
                result = Convert.ToDouble(b[0]) + Convert.ToDouble(b[1]);

            if (textBox1.Text.Contains("-"))
                result = Convert.ToDouble(b[0]) - Convert.ToDouble(b[1]);

            if (textBox1.Text.Contains("/"))
                result = Convert.ToDouble(b[0]) / Convert.ToDouble(b[1]);

            if (textBox1.Text.Contains("*"))
                result = Convert.ToDouble(b[0]) * Convert.ToDouble(b[1]);

        }
       
        }
    public string ProvLastChar(char j)
    {
        char last_char = textBox1.Text[textBox1.Text.Length - 1];
        if (last_char != '+' && last_char != '-' && last_char != '/' && last_char != '*')
        {
            return textBox1.Text += j;
        }
        else
        {
            return textBox1.Text;
        }

    }
    private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}