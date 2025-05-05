using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalcPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            input_number.KeyPress += new KeyPressEventHandler(input_number_KeyPress);
            // 숫자만 입력받도록 이벤트 핸들러 추가
        }

        /// <summary>
        /// 키보드 숫자만 입력 받도록 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 제어 문자만 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 입력을 무시
            }
            // 엔터
            if (e.KeyChar == (char)Keys.Enter)
            {
                // 엔터 키를 눌렀을 때의 동작을 여기에 추가
                // 예: 계산 수행
                equal_Click(sender,e);
            }

        }
        ScientificCalc sc = new ScientificCalc();
        decimal UserInput(string input)
        {
            decimal number;
            if (decimal.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                input_number.Text = "";
                return 0;
            }
        }

        private void nd2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// nd2 와 동일한 기능
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nd2_2_Click(object sender, EventArgs e)
        {

        }
        private void sin_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Sin(UserInput(input_number.Text)).ToString();
        }
        private void cos_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Cos(UserInput(input_number.Text)).ToString();
        }

        private void tan_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Tan(UserInput(input_number.Text)).ToString();
        }

        private void hyp_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Hyp(UserInput(input_number.Text)).ToString();
        }

        private void sec_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Sec(UserInput(input_number.Text)).ToString();
        }

        private void csc_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Csc(UserInput(input_number.Text)).ToString();
        }

        private void cot_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Cot(UserInput(input_number.Text)).ToString();
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            input_number.Text += "9";
        }
        private void number_8_Click(object sender, EventArgs e)
        {
            input_number.Text += "8";
        }
        private void number_7_Click(object sender, EventArgs e)
        {
            input_number.Text += "7";
        }
        private void number_6_Click(object sender, EventArgs e)
        {
            input_number.Text += "6";
        }
        private void number_5_Click(object sender, EventArgs e)
        {
            input_number.Text += "5";
        }
        private void number_4_Click(object sender, EventArgs e)
        {
            input_number.Text += "4";
        }

        private void numbere_3_Click(object sender, EventArgs e)
        {
            input_number.Text += "3";
        }
        private void number_2_Click(object sender, EventArgs e)
        {
            input_number.Text += "2";
        }

        private void number_1_Click(object sender, EventArgs e)
        {
            input_number.Text += "1";
        }
        private void zero_Click(object sender, EventArgs e)
        {
            input_number.Text += "0";
        }
        private void pi_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Pi().ToString();
        }

        private void e_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.E().ToString();
        }

        private void ce_Click(object sender, EventArgs e)
        {
            input_number.Text = "";
            preview.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                input_number.Text = input_number.Text.Substring(0, input_number.Text.Length - 1);
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            preview.Text = $"sqr({input_number.Text})";
            input_number.Text = sc.Pow(UserInput(input_number.Text),2).ToString();
        }

        private void reciprocal_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Inverse(UserInput(input_number.Text)).ToString();
        }

        private void abs_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Abs(UserInput(input_number.Text)).ToString();
        }

        private void exp_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Exp(UserInput(input_number.Text)).ToString();
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + "mod";
                input_number.Text = "";
            }
            else
            {
                input_number.Text = sc.Mod(UserInput(preview.Text), UserInput(input_number.Text)).ToString();
            }


        }

        private void squareRoot_Click(object sender, EventArgs e)
        {
            preview.Text = $"√({input_number.Text})";
            input_number.Text = sc.Sqrt(UserInput(input_number.Text)).ToString();
        }

        private void parentheses_Click(object sender, EventArgs e)
        {
            input_number.Text += "(";
        }

        private void parenthesesEnd_Click(object sender, EventArgs e)
        {
            input_number.Text += ")";
        }

        private void pectory_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.Fatory(UserInput(input_number.Text)).ToString();
        }

        private void sharing_Click(object sender, EventArgs e)
        {
            if(input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " / " + preview.Text;
                input_number.Text = "";
            }
            else
            {
                input_number.Text = sc.Div(UserInput(preview.Text), UserInput(input_number.Text)).ToString();
            }
        }

        private void power_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " ^ " + preview.Text;
                input_number.Text = "";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            string code = preview.Text;
            decimal result = 0;

            // 연산자와 숫자 분리
            if (code.Contains("+"))
            {
                var parts = code.Split('+');
                if (parts.Length == 2)
                {
                    result = sc.Add(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("-"))
            {
                var parts = code.Split('-');
                if (parts.Length == 2)
                {
                    result = sc.Sub(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("*"))
            {
                var parts = code.Split('*');
                if (parts.Length == 2)
                {
                    result = sc.Mul(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("/"))
            {
                var parts = code.Split('/');
                if (parts.Length == 2)
                {
                    result = sc.Div(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("mod"))
            {
                var parts = code.Split(new[] { "mod" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    result = sc.Mod(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("^"))
            {
                var parts = code.Split('^');
                if(parts.Length == 2)
                {
                    result = sc.Pow(UserInput(parts[0]),UserInput(input_number.Text));
                }
            }

            // 결과 표시
            input_number.Text = result.ToString();
            preview.Text = ""; // 연산 완료 후 preview 초기화
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " * " + preview.Text;
                input_number.Text = "";
            }

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " - " + preview.Text;
                input_number.Text = "";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " + " + preview.Text;
                input_number.Text = "";
            }
        }

        private void squareOfTen_Click(object sender, EventArgs e)
        {
            input_number.Text=sc.SquareOfTen(UserInput(input_number.Text)).ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            input_number.Text=sc.Log(UserInput(input_number.Text),10).ToString();
        }

        private void naturalLog_Click(object sender, EventArgs e)
        {
            input_number.Text = sc.naturalLog(UserInput(input_number.Text)).ToString();
        }

        private void conversion_Click(object sender, EventArgs e)
        {
            // 문자 열 앞에 부호 붙이기
            input_number.Text= input_number.Text.StartsWith("-") ? input_number.Text.Substring(1) : "-" + input_number.Text;
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            decimal userNumber = UserInput(input_number.Text);
            //. 추가
            if (userNumber == 0)
            {
                input_number.Text = "0.";
            }
            else
            {
                // 이미 소수점이 있는지 확인
                if (!input_number.Text.Contains("."))
                {
                    input_number.Text += ".";
                }
            }
        }
    }
}
