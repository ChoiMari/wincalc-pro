using System;
using System.Drawing;
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

        //테마 ---------------------
        public void ChangeTheme(AppTheme theme)
        {
            if (theme == AppTheme.Light)
            {

                // 테마를 적용하는 함수 호출
                LightTheme();


            }
            else if (theme == AppTheme.Dark)
            {

                // 테마를 적용하는 메서드 호출
                DarkTheme();
            }
        }

        // 테마 적용
        void LightTheme() { 
        
        }
        void DarkTheme() { 
            this.BackColor = Color.FromArgb(26, 34, 39);
            textBox_input.BackColor = Color.FromArgb(26, 34, 39);
            textBox_preview.BackColor = Color.FromArgb(26, 34, 39);
            toolStrip_trigonometry.BackColor = Color.FromArgb(26, 34, 39);
            toolStripSplitButton.BackColor = Color.FromArgb(26, 34, 39);
            panel_hr.BackColor = Color.FromArgb(26, 34, 39);
            btn_0.BackColor = Color.FromArgb(81, 78, 78);
            btn_1.BackColor = Color.FromArgb(81, 78, 78);
            btn_2.BackColor = Color.FromArgb(81, 78, 78);
            btn_3.BackColor = Color.FromArgb(81, 78, 78);
            btn_4.BackColor = Color.FromArgb(81, 78, 78);
            btn_5.BackColor = Color.FromArgb(81, 78, 78);
            btn_6.BackColor = Color.FromArgb(81, 78, 78);
            btn_7.BackColor = Color.FromArgb(81, 78, 78);
            btn_8.BackColor = Color.FromArgb(81, 78, 78);
            btn_9.BackColor = Color.FromArgb(81, 78, 78);
            btn_decimalPoint.BackColor = Color.FromArgb(81, 78, 78);
            btn_conversion.BackColor = Color.FromArgb(81, 78, 78);

            btn_abs.BackColor = Color.FromArgb(56, 48, 49);
            btn_plus.BackColor = Color.FromArgb(56, 48, 49);
            btn_minus.BackColor = Color.FromArgb(56, 48, 49);
            btn_multiplication.BackColor = Color.FromArgb(56, 48, 49);
            btn_sharing.BackColor = Color.FromArgb(56, 48, 49);
            btn_mod.BackColor = Color.FromArgb(56, 48, 49);
            btn_back.BackColor = Color.FromArgb(56, 48, 49);
            btn_ce.BackColor = Color.FromArgb(56, 48, 49);
            btn_e.BackColor = Color.FromArgb(56, 48, 49);
            btn_pi.BackColor = Color.FromArgb(56, 48, 49);
            btn_nd2.BackColor = Color.FromArgb(56, 48, 49);
            btn_square.BackColor = Color.FromArgb(56, 48, 49);
            btn_reciprocal.BackColor = Color.FromArgb(56, 48, 49);
            btn_exp.BackColor = Color.FromArgb(56, 48, 49);
            btn_squareRoot.BackColor = Color.FromArgb(56, 48, 49);
            btn_parenthesesEnd.BackColor = Color.FromArgb(56, 48, 49);
            btn_pow10.BackColor = Color.FromArgb(56, 48, 49);
            btn_openParentheses.BackColor = Color.FromArgb(56, 48, 49);
            btn_factorial.BackColor = Color.FromArgb(56, 48, 49);
            btn_power.BackColor = Color.FromArgb(56, 48, 49);
            btn_log.BackColor = Color.FromArgb(56, 48, 49);
            but_in.BackColor = Color.FromArgb(56, 48, 49);

            textBox_input.ForeColor = Color.White;
            textBox_preview.ForeColor = Color.White;
            toolStripSplitButton.ForeColor = Color.DarkGray;
            btn_0.ForeColor = Color.White;
            btn_1.ForeColor = Color.White;
            btn_2.ForeColor = Color.White;
            btn_3.ForeColor = Color.White;
            btn_4.ForeColor = Color.White;
            btn_5.ForeColor = Color.White;
            btn_6.ForeColor = Color.White;
            btn_7.ForeColor = Color.White;
            btn_8.ForeColor = Color.White;
            btn_9.ForeColor = Color.White;
            btn_conversion.ForeColor = Color.White;
            btn_decimalPoint.ForeColor = Color.White;

            btn_abs.ForeColor = Color.White;
            btn_plus.ForeColor = Color.White;
            btn_minus.ForeColor = Color.White;
            btn_multiplication.ForeColor = Color.White;
            btn_sharing.ForeColor = Color.White;
            btn_mod.ForeColor = Color.White;
            btn_back.ForeColor = Color.White;
            btn_ce.ForeColor = Color.White;
            btn_e.ForeColor = Color.White;
            btn_pi.ForeColor = Color.White;
            btn_nd2.ForeColor = Color.White;
            btn_square.ForeColor = Color.White;
            btn_exp.ForeColor = Color.White;
            btn_squareRoot.ForeColor = Color.White;
            btn_parenthesesEnd.ForeColor = Color.White;
            btn_pow10.ForeColor = Color.White;
            btn_openParentheses.ForeColor = Color.White;
            btn_factorial.ForeColor = Color.White;
            btn_power.ForeColor = Color.White;
            btn_log.ForeColor = Color.White;
            but_in.ForeColor = Color.White;
            btn_reciprocal.ForeColor = Color.White;

            btn_0.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_1.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_2.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_3.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_4.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_5.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_6.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_7.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_8.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_9.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_conversion.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_decimalPoint.FlatAppearance.MouseOverBackColor = Color.Brown;

            btn_nd2.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_pi.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_e.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_ce.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_back.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_mod.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_exp.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_abs.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_sharing.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_minus.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_multiplication.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_plus.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_factorial.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_parenthesesEnd.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_openParentheses.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_squareRoot.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_pow10.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_power.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_log.FlatAppearance.MouseOverBackColor = Color.Brown;
            but_in.FlatAppearance.MouseOverBackColor = Color.Brown;
            btn_square.FlatAppearance.MouseOverBackColor = Color.Brown;

        }
    }
}
