using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal Temp_result;
        private string Operation_input;

        // 숫자 버튼 + '.' 버튼 입력 생성.
        private void button1_Click(object sender, EventArgs e)
        {
            Button number_button = (Button)sender;
            if(number_button.Text == ".")
            {
                if (!this.text_result.Text.Contains("."))
                    this.text_result.Text += number_button.Text;
            }
            else
                this.text_result.Text += number_button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button _Button;

            if (this.text_result.Text == string.Empty)
                return;

            _Button = (Button)sender;

            this.Operation_input = _Button.Text;

            this.Temp_result = decimal.Parse(this.text_result.Text);

            this.text_result.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Numbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
