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
        }
        /// <summary>
        /// 키보드 숫자만 입력 받도록 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_input_KeyPress(object sender, KeyPressEventArgs e)
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
                btn_equal_Click(sender, e);
            }
            btn_ce.Name = "CE";

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
            if (textBox_input.Text.Length > 0 || textBox_preview.Text.Length > 0)
            {
                textBox_input.Text = "";
                btn_ce.Name = "C";
            }
            else if (btn_ce.Name == "C")
            {
                textBox_input.Text = "";
                textBox_preview.Text = "";
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
            textBox_input.Text += "(";

        }

        private void btn_factorial_Click(object sender, EventArgs e)
        {
            textBox_input.Text = sc.Fatory(UserInput(textBox_input.Text)).ToString();

        }

        private void btn_parenthesesEnd_Click(object sender, EventArgs e)
        {

            textBox_input.Text += ")";

        }

        private void btn_sharing_Click(object sender, EventArgs e)
        {

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " / " + textBox_preview.Text;
                textBox_input.Text = "";
            }
            else
            {
                textBox_input.Text = sc.Div(UserInput(textBox_preview.Text), UserInput(textBox_input.Text)).ToString();
            }

        }

        private void btn_power_Click(object sender, EventArgs e)
        {
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

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " * " + textBox_preview.Text;
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

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " - " + textBox_preview.Text;
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
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " + " + textBox_preview.Text;
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
