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

        private Double Temp_result=0;
        private string Operation_input;
        bool is_Operation = false;

        // 숫자 버튼 + '.' 버튼 입력 생성.
        private void Numbutton_Click(object sender, EventArgs e)
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

        // Operation 버튼 입력 생성
        private void Optbutton_Click(object sender, EventArgs e)
        {
            Button operation_button = (Button)sender;

            if (this.text_result.Text == string.Empty)
                return;

            if(is_Operation == false)
            {
                this.Operation_input = operation_button.Text;
                this.Temp_result = Double.Parse(this.text_result.Text);
                this.text_result.Text = string.Empty;
                this.is_Operation = true;
            }
            else
            {
                Equalbutton.PerformClick();
                this.Operation_input = operation_button.Text;
                this.text_result.Text = string.Empty;
                this.is_Operation = true;
            }
        }

        // = 버튼 클릭 시 이벤트 생성
        private void Equalbutton_Click(object sender, EventArgs e)
        {
            if (this.Temp_result == Double.MinValue)
                return;

            if (this.Operation_input == string.Empty)
                return;

            if (this.text_result.Text == string.Empty)
                return;

            list.Items.Add(Temp_result + Operation_input + text_result.Text);

            switch (this.Operation_input)
            {
                case "+":
                    this.text_result.Text = (this.Temp_result + Double.Parse(this.text_result.Text)).ToString();
                    break;
                case "-":
                    this.text_result.Text = (this.Temp_result - Double.Parse(this.text_result.Text)).ToString();
                    break;
                case "*":
                    this.text_result.Text = (this.Temp_result * Double.Parse(this.text_result.Text)).ToString();
                    break;
                case "/":
                    if (this.text_result.Text == "0")
                        return;

                    this.text_result.Text = (this.Temp_result / Double.Parse(this.text_result.Text)).ToString();
                    break;
            }
            Temp_result = Double.Parse(this.text_result.Text);
            is_Operation = false;
        }

        // 1/x Operation 클릭 시 이벤트 생성
        private void Reversebutton_Click(object sender, EventArgs e)
        {
            this.text_result.Text = (1 / Double.Parse(this.text_result.Text)).ToString();
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.text_result.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
