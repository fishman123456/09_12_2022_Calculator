namespace _09_12_2022_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)// TODO text
        {

        }

        private void button1_Click(object sender, EventArgs e)// TODO ���� �������
        {
            MessageBox.Show("��������� �����������");
        }

        private void button2_Click(object sender, EventArgs e)// TODO ������� ������
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)// TODO �������� ���������� �������
        {
            if (textBox1.Text.Length >0)
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

        private void button18_Click(object sender, EventArgs e)// TODO ������1
        {
           
        }

        private void button19_Click(object sender, EventArgs e)// TODO ������2
        {
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }
    }
}