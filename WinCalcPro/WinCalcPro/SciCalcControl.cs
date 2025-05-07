using System;
using System.Windows.Forms;

namespace WinCalcPro
{
    public partial class SciCalcControl : UserControl
    {
        public SciCalcControl()
        {
            InitializeComponent();
            textBox_input.KeyPress += new KeyPressEventHandler(textBox_input_KeyPress);
            // 숫자만 입력받도록 이벤트 핸들러 추가

            textBox_input.TextChanged += textBox_input_TextChanged;
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            btn_ce.Text = "CE";

            //앞에 0이 있으면 지우기
            if (textBox_input.Text.Length > 1 && textBox_input.Text.StartsWith("0"))
            {
                textBox_input.Text = textBox_input.Text.Substring(1);
            }
        }

        /// <summary>
        /// 키보드 숫자만 입력 받도록 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 키보드 입력 버튼으로 처리
            switch (e.KeyChar)
            {
                case '0':
                    btn_0_Click(sender, e);
                    break;
                case '1':
                    btn_1_Click(sender, e);
                    break;
                case '2':
                    btn_2_Click(sender, e);
                    break;
                case '3':
                    btn_3_Click(sender, e);
                    break;
                case '4':
                    btn_4_Click(sender, e);
                    break;
                case '5':
                    btn_5_Click(sender, e);
                    break;
                case '6':
                    btn_6_Click(sender, e);
                    break;
                case '7':
                    btn_7_Click(sender, e);
                    break;
                case '8':
                    btn_8_Click(sender, e);
                    break;
                case '9':
                    btn_9_Click(sender, e);
                    break;
                case '.':
                    btn_decimalPoint_Click(sender, e);
                    break;
                case '+':
                    btn_plus_Click(sender, e);
                    break;
                case '-':
                    btn_minus_Click(sender, e);
                    break;
                case '*':
                    btn_multiplication_Click(sender, e);
                    break;
                case '/':
                    btn_sharing_Click(sender, e);
                    break;
                case '(':
                    btn_openParentheses_Click(sender, e);
                    break;
                case ')':
                    btn_parenthesesEnd_Click(sender, e);
                    break;
                case '=':
                    btn_equal_Click(sender, e);
                    break;
                case (char)Keys.Back:
                    btn_back_Click(sender, e);
                    break;

                case (char)Keys.Enter:
                    btn_equal_Click(sender, e);
                    break;
                default:
                    break;
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
                textBox_input.Text = "";
                return 0;
            }
        }






        private void btn_nd2_Click(object sender, EventArgs e)
        {

        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Pi().ToString();

        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.E().ToString();

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0 && textBox_preview.Text.Length > 0)
            {
                textBox_input.Text = "";
                btn_ce.Text = "C";
            }
            else if (btn_ce.Text == "C")
            {
                textBox_input.Text = "";
                textBox_preview.Text = "";
            }
            else
            {
                textBox_input.Text = "";
                textBox_preview.Text = "";
                btn_ce.Text = "C";
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // 뒤로 한 글자 지우기
            if (textBox_input.Text.Length > 0)
            {
                textBox_input.Text = textBox_input.Text.Substring(0, textBox_input.Text.Length - 1);
            }
        }

        private void btn_square_Click(object sender, EventArgs e)
        {

            textBox_input.Text = sc.Pow(UserInput(textBox_input.Text), 2).ToString();
        }

        private void btn_reciprocal_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Inverse(UserInput(textBox_input.Text)).ToString();

        }

        private void btn_abs_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Abs(UserInput(textBox_input.Text)).ToString();

        }

        private void btn_exp_Click(object sender, EventArgs e)
        {

            textBox_input.Text = sc.Exp(UserInput(textBox_input.Text)).ToString();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + "mod";
                textBox_input.Text = "";
            }
            else
            {
                textBox_input.Text = sc.Mod(UserInput(textBox_preview.Text), UserInput(textBox_input.Text)).ToString();
            }
        }

        private void btn_squareRoot_Click(object sender, EventArgs e)
        {

            textBox_input.Text = sc.Sqrt(UserInput(textBox_input.Text)).ToString();
        }

        private void btn_openParentheses_Click(object sender, EventArgs e)
        {
            textBox_input.Text = "";
            textBox_preview.Text += "(";

        }

        private void btn_factorial_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Fatory(UserInput(textBox_input.Text)).ToString();

        }

        private void btn_parenthesesEnd_Click(object sender, EventArgs e)
        {
            textBox_preview.Text += textBox_input.Text + ")";
            textBox_input.Text = "";
        }

        private void btn_sharing_Click(object sender, EventArgs e)
        {
            // /가 있으면 연산
            if (textBox_preview.Text.Contains("/")&&!textBox_preview.Text.Contains("("))
            {
                btn_equal_Click(sender, e);
            }

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " / " ;
                textBox_input.Text = "";
            }

        }

        private void btn_power_Click(object sender, EventArgs e)
        {
            // ^가 있으면 연산
            if (textBox_preview.Text.Contains("^"))
            {
                var parts = textBox_preview.Text.Split('^');
                if (parts.Length == 2)
                {
                    textBox_input.Text = sc.Pow(UserInput(parts[0]), UserInput(textBox_input.Text)).ToString();
                }
            }
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " ^ " + textBox_preview.Text;
                textBox_input.Text = "";
            }

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "7";

        }

        private void btn_8_Click(object sender, EventArgs e)
        {

            textBox_input.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {

            textBox_input.Text += "9";
        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            // *가 있으면 연산
            if (textBox_preview.Text.Contains("*")&&!textBox_preview.Text.Contains("("))
            {
                btn_equal_Click(sender, e);
            }
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text += textBox_input.Text + " * ";
                textBox_input.Text = "";
            }
        }

        private void btn_pow10_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.SquareOfTen(UserInput(textBox_input.Text)).ToString();

        }

        private void btn_5_Click(object sender, EventArgs e)
        {

            textBox_input.Text += "5";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "4";

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "6";

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            // -가 있으면 연산
            if (textBox_preview.Text.Contains("-")&&!textBox_preview.Text.Contains("("))
            {
                btn_equal_Click(sender, e);
            }

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text += textBox_input.Text + " - " ;
                textBox_input.Text = "";
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Log(UserInput(textBox_input.Text), 10).ToString();

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "1";

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "2";

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "3";

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            // +가 있으면 연산
            if (textBox_preview.Text.Contains("+")&&!textBox_preview.Text.Contains("("))
            {
                btn_equal_Click(sender, e);
            }
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text += textBox_input.Text + " + ";
                textBox_input.Text = "";
            }

        }

        private void but_in_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Inverse(UserInput(textBox_input.Text)).ToString();

        }

        private void btn_conversion_Click(object sender, EventArgs e)
        {
            // 문자 열 앞에 부호 붙이기
            textBox_input.Text = textBox_input.Text.StartsWith("-") ? textBox_input.Text.Substring(1) : "-" + textBox_input.Text;

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "0";

        }

        private void btn_decimalPoint_Click(object sender, EventArgs e)
        {
            decimal userNumber = UserInput(textBox_input.Text);
            //. 추가
            if (userNumber == 0)
            {
                textBox_input.Text = "0.";
            }
            else
            {
                // 이미 소수점이 있는지 확인
                if (!textBox_input.Text.Contains("."))
                {
                    textBox_input.Text += ".";
                }
            }

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {

            string code = textBox_preview.Text;
            decimal result = 0;

            if (code.Contains("("))
            {
                result = sc.Calculate(code + textBox_input.Text);

                // 결과 표시
                textBox_input.Text = result.ToString();
                sc.AddToHistory(code + " = " + result.ToString());
                textBox_preview.Text = ""; // 연산 완료 후 preview 초기화
                return;
            }

            // 연산자와 숫자 분리
            if (code.Contains("+"))
            {
                var parts = code.Split('+');
                if (parts.Length == 2)
                {
                    result = sc.Add(UserInput(parts[0]), UserInput(textBox_input.Text));
                }
            }
            else if (code.Contains("-"))
            {
                var parts = code.Split('-');
                if (parts.Length == 2)
                {
                    result = sc.Sub(UserInput(parts[0]), UserInput(textBox_input.Text));
                }
            }
            else if (code.Contains("*"))
            {
                var parts = code.Split('*');
                if (parts.Length == 2)
                {
                    result = sc.Mul(UserInput(parts[0]), UserInput(textBox_input.Text));
                }
            }
            else if (code.Contains("/"))
            {
                var parts = code.Split('/');
                if (parts.Length == 2)
                {
                    result = sc.Div(UserInput(parts[0]), UserInput(textBox_input.Text));
                }
            }
            else if (code.Contains("mod"))
            {
                var parts = code.Split(new[] { "mod" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    result = sc.Mod(UserInput(parts[0]), UserInput(textBox_input.Text));
                }
            }
            else if (code.Contains("^"))
            {
                var parts = code.Split('^');
                if (parts.Length == 2)
                {
                    result = sc.Pow(UserInput(parts[0]), UserInput(textBox_input.Text));
                }
            }
             

            
            // 결과 표시
            textBox_input.Text = result.ToString();
            sc.AddToHistory(code + " = " + result.ToString());
            textBox_preview.Text = ""; // 연산 완료 후 textBox_preview 초기화
        }

        private void ToolStripMenuItem_2nd_Click(object sender, EventArgs e)
        {


        }

        private void ToolStripMenuItem_sin_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Sin(UserInput(textBox_input.Text)).ToString();
        }

        private void ToolStripMenuItem_cos_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Cos(UserInput(textBox_input.Text)).ToString();

        }

        private void ToolStripMenuItem_tan_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Tan(UserInput(textBox_input.Text)).ToString();

        }

        private void ToolStripMenuItem_hyp_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Hyp(UserInput(textBox_input.Text)).ToString();

        }

        private void ToolStripMenuItem_sec_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Sec(UserInput(textBox_input.Text)).ToString();

        }

        private void ToolStripMenuItem_csc_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Csc(UserInput(textBox_input.Text)).ToString();

        }

        private void ToolStripMenuItem_cot_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Cot(UserInput(textBox_input.Text)).ToString();

        }
    }
}
