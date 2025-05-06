using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinCalcPro
{
    public partial class ProgCalcControl : UserControl
    {
        public ProgCalcControl()
        {
            InitializeComponent();
            // 10진수로
            btn_DEC_Click(this, EventArgs.Empty);

            // textBox_input의 TextChanged 이벤트에 핸들러 추가
            textBox_input.TextChanged += InputNumber_TextChanged;
        }
        private void InputNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // 입력값이 유효한 정수인지 확인
                if (long.TryParse(textBox_input.Text, out long number))
                {
                    // 각 진수로 변환하여 텍스트 박스에 표시
                    textBox_HEX.Text = Convert.ToString(number, 16).ToUpper(); // 16진수
                    textBox_DEC.Text = Convert.ToString(number, 10);          // 10진수
                    textBox_OCT.Text = Convert.ToString(number, 8);           // 8진수
                    textBox_BIN.Text = Convert.ToString(number, 2);           // 2진수
                    // C를 CE로 변경
                    btn_clearAll.Text = "CE";
                }
                else
                {
                    // 유효하지 않은 입력일 경우 초기화
                    textBox_HEX.Text = string.Empty;
                    textBox_DEC.Text = string.Empty;
                    textBox_OCT.Text = string.Empty;
                    textBox_BIN.Text = string.Empty;
                }
                //앞에 0이 있으면 지우기
                if (textBox_input.Text.Length > 1 && textBox_input.Text.StartsWith("0"))
                {
                    textBox_input.Text = textBox_input.Text.Substring(1);
                }
            }
            catch (Exception ex)
            {
                // 예외 처리 (필요시 로그 추가)
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        ProgrammerCalc pc = new ProgrammerCalc();
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


        private void btn_BEX_Click(object sender, EventArgs e)
        {
            // Abtn 활성화
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_E.Enabled = true;
            btn_F.Enabled = true;
            // 10진수 버튼 활성화
            btn_0.Enabled = true;
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
        }

        private void btn_DEC_Click(object sender, EventArgs e)
        {
            // 10진수 버튼 활성화 및 16진수 버튼 비활성화
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_0.Enabled = true;
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;

        }

        private void btn_OCT_Click(object sender, EventArgs e)
        {
            // 8진수 버튼 활성화 및 16진수 버튼 비활성화
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_0.Enabled = true;
            btn_1.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = false;
            btn_9.Enabled = false;



        }

        private void btn_BIN_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_0.Enabled = true;
            btn_1.Enabled = true;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;

        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            // 16진수 A 10
            textBox_input.Text += 0xA;

        }

        private void btn_leftShift_Click(object sender, EventArgs e)
        {
            //<< 가 있으면 연산
            if(textBox_preview.Text.Contains("<<"))
            {
                var parts = textBox_preview.Text.Split(new[] { "<<" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    long result = pc.Left(long.Parse(parts[0]), int.Parse(textBox_input.Text));
                    textBox_input.Text = result.ToString();
                    textBox_preview.Text = "";
                }
            }
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " << " + textBox_preview.Text;
                textBox_input.Text = "";
            }

        }

        private void btn_rightShift_Click(object sender, EventArgs e)
        {
            //>> 가 있으면 연산
            if (textBox_preview.Text.Contains(">>"))
            {
                var parts = textBox_preview.Text.Split(new[] { ">>" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    long result = pc.Right(long.Parse(parts[0]), int.Parse(textBox_input.Text));
                    textBox_input.Text = result.ToString();
                    textBox_preview.Text = "";
                }
            }

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " >> " + textBox_preview.Text;
                textBox_input.Text = "";
            }

        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0 && textBox_preview.Text.Length > 0)
            {
                textBox_input.Text = "";
                btn_clearAll.Text = "C";
            }
            else if (btn_clearAll.Text == "C")
            {
                textBox_input.Text = "";
                textBox_preview.Text = "";
            }
            else
            {
                textBox_input.Text = "";
                textBox_preview.Text = "";
                btn_clearAll.Text = "C";
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

        private void btn_B_Click(object sender, EventArgs e)
        {
            textBox_input.Text += 0xB;

        }

        private void btn_openParentheses_Click(object sender, EventArgs e)
        {
            // textBox_input.Text 끝에 기호가 없다면 * 추가
            if (textBox_input.Text.Length > 0  && !textBox_input.Text.EndsWith("+") && !textBox_input.Text.EndsWith("-") && !textBox_input.Text.EndsWith("*") && !textBox_input.Text.EndsWith("/") && !textBox_input.Text.EndsWith("%"))
            {
                textBox_preview.Text = textBox_input.Text + " * " + textBox_preview.Text;
            }
            textBox_preview.Text = textBox_input.Text + " ( " ;
            textBox_input.Text = "";

        }

        private void btn_parenthesesEnd_Click(object sender, EventArgs e)
        {
            textBox_preview.Text = textBox_input.Text +textBox_preview+ " ) ";
            textBox_input.Text = "";

        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " % " + textBox_preview.Text;
                textBox_input.Text = "";
            }

        }

        private void btn_sharing_Click(object sender, EventArgs e)
        {
            // /가 있으면 연산
            if (textBox_preview.Text.Contains("/"))
            {
                var parts = textBox_preview.Text.Split('/');
                if (parts.Length == 2)
                {
                    decimal result = pc.Div(UserInput(parts[0]), UserInput(textBox_input.Text));
                    textBox_input.Text = result.ToString();
                    textBox_preview.Text = "";
                }
            }
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " / " + textBox_preview.Text;
                textBox_input.Text = "";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox_input.Text += 0xC;

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
            // * 가 있으면 연산
            if (textBox_preview.Text.Contains("*"))
            {
                var parts = textBox_preview.Text.Split('*');
                if (parts.Length == 2)
                {
                    decimal result = pc.Mul(UserInput(parts[0]), UserInput(textBox_input.Text));
                    textBox_input.Text = result.ToString();
                    textBox_preview.Text = "";
                }
            }
            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " * " + textBox_preview.Text;
                textBox_input.Text = "";
            }

        }

        private void btn_D_Click(object sender, EventArgs e)
        {

            textBox_input.Text += 0xD;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {

            textBox_input.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {

            textBox_input.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {

            textBox_input.Text += "6";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            // - 가 있으면 연산
            if (textBox_preview.Text.Contains("-"))
            {
                var parts = textBox_preview.Text.Split('-');
                if (parts.Length == 2)
                {
                    decimal result = pc.Sub(UserInput(parts[0]), UserInput(textBox_input.Text));
                    textBox_input.Text = result.ToString();
                    textBox_preview.Text = "";
                }
            }

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " - " + textBox_preview.Text;
                textBox_input.Text = "";
            }
        }

        private void btn_E_Click(object sender, EventArgs e)
        {

            textBox_input.Text += 0xE;
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
            // + 가 있으면 연산
            if (textBox_preview.Text.Contains("+"))
            {
                var parts = textBox_preview.Text.Split('+');
                if (parts.Length == 2)
                {
                    decimal result = pc.Add(UserInput(parts[0]), UserInput(textBox_input.Text));
                    textBox_input.Text = result.ToString();
                    textBox_preview.Text = "";
                }
            }

            if (textBox_input.Text.Length > 0)
            {
                textBox_preview.Text = textBox_input.Text + " + " + textBox_preview.Text;
                textBox_input.Text = "";
            }
        }

        private void btn_F_Click(object sender, EventArgs e)
        {

            textBox_input.Text += 0xF;

        }

        private void btn_conversion_Click(object sender, EventArgs e)
        {

            textBox_input.Text = textBox_input.Text.StartsWith("-") ? textBox_input.Text.Substring(1) : "-" + textBox_input.Text;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox_input.Text += "0";

        }

        private void btn_decimalPoint_Click(object sender, EventArgs e)
        {
            if (!textBox_input.Text.Contains("."))
            {
                textBox_input.Text += ".";
            }

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            string code = textBox_preview.Text;
            decimal result = 0;

            try
            {
                // 연산자와 숫자 분리
                if (code.Contains("+"))
                {
                    var parts = code.Split('+');
                    if (parts.Length == 2)
                    {
                        result = pc.Add(UserInput(parts[0]), UserInput(textBox_input.Text));
                        
                    }
                }
                else if (code.Contains("-"))
                {
                    var parts = code.Split('-');
                    if (parts.Length == 2)
                    {
                        result = pc.Sub(UserInput(parts[0]), UserInput(textBox_input.Text));
                    }
                }
                else if (code.Contains("*"))
                {
                    var parts = code.Split('*');
                    if (parts.Length == 2)
                    {
                        result = pc.Mul(UserInput(parts[0]), UserInput(textBox_input.Text));
                    }
                }
                else if (code.Contains("/"))
                {
                    var parts = code.Split('/');
                    if (parts.Length == 2)
                    {
                        result = pc.Div(UserInput(parts[0]), UserInput(textBox_input.Text));
                    }
                }
                else if (code.Contains("^"))
                {
                    var parts = code.Split('^');
                    if (parts.Length == 2)
                    {
                        result = pc.Pow(UserInput(parts[0]), UserInput(textBox_input.Text));
                    }
                }
                else if (code.Contains("<<"))
                {
                    var parts = code.Split(new[] { "<<" }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        result = pc.Left(long.Parse(parts[0]), int.Parse(textBox_input.Text));
                    }
                }
                else if (code.Contains(">>"))
                {
                    var parts = code.Split(new[] { ">>" }, StringSplitOptions.None);
                    if (parts.Length == 2)
                    {
                        result = pc.Right(long.Parse(parts[0]), int.Parse(textBox_input.Text));
                    }
                }
                else if (code.Contains("%"))
                {
                    var parts = code.Split('%');
                    if (parts.Length == 2)
                    {
                        result = pc.Percent(UserInput(parts[0]));
                    }
                }
                else if (code.Contains("("))
                {
                    var parts= EvaluateExpression(textBox_preview.Text+textBox_input.Text);
                    result = parts;
                }
                else if (code.Contains(")"))
                {
                    var parts = EvaluateExpression(textBox_preview.Text + textBox_input.Text);
                    result = parts;
                }
                else
                {
                    // 단순 숫자 연산
                    result = UserInput(code);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            // 결과 표시
            textBox_input.Text = result.ToString();
            pc.AddToHistory(code + " = " + result.ToString());
            textBox_preview.Text = ""; // 연산 완료 후 preview 초기화


            //try
            //{
            //    string expression = textBox_preview.Text + textBox_input.Text;
            //    decimal result = EvaluateExpression(expression);

            //    // 결과 표시
            //    textBox_input.Text = result.ToString();
            //    textBox_preview.Text = ""; // 연산 완료 후 preview 초기화
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


















        private decimal CalculatePostfix(List<string> postfix)
        {
            var stack = new Stack<decimal>();

            foreach (var token in postfix)
            {
                if (decimal.TryParse(token, out decimal number)) // 숫자
                {
                    stack.Push(number);
                }
                else // 연산자
                {
                    var b = stack.Pop();
                    var a = stack.Pop();

                    switch (token)
                    {
                        case "+": stack.Push(a + b); break;
                        case "-": stack.Push(a - b); break;
                        case "*": stack.Push(a * b); break;
                        case "/": stack.Push(a / b); break;
                        default: throw new InvalidOperationException($"알 수 없는 연산자: {token}");
                    }
                }
            }

            return stack.Pop();
        }
        private List<string> ConvertToPostfix(List<string> tokens)
        {
            var output = new List<string>();
            var operators = new Stack<string>();

            var precedence = new Dictionary<string, int>
            {
                { "+", 1 }, { "-", 1 },
                { "*", 2 }, { "/", 2 },
                { "(", 0 } // '('는 우선순위가 가장 낮음
            };

            foreach (var token in tokens)
            {
                if (decimal.TryParse(token, out _)) // 숫자
                {
                    output.Add(token);
                }
                else if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Pop(); // '(' 제거
                }
                else // 연산자
                {
                    while (operators.Count > 0 && precedence[operators.Peek()] >= precedence[token])
                    {
                        output.Add(operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                output.Add(operators.Pop());
            }

            return output;
        }
        private List<string> TokenizeExpression(string expression)
        {
            var tokens = new List<string>();
            var number = new StringBuilder();

            foreach (char c in expression)
            {
                if (char.IsDigit(c) || c == '.') // 숫자 또는 소수점
                {
                    number.Append(c);
                }
                else
                {
                    if (number.Length > 0)
                    {
                        tokens.Add(number.ToString());
                        number.Clear();
                    }

                    if (!char.IsWhiteSpace(c)) // 연산자 또는 괄호
                    {
                        tokens.Add(c.ToString());
                    }
                }
            }

            if (number.Length > 0)
            {
                tokens.Add(number.ToString());
            }

            return tokens;
        }
        private decimal EvaluateExpression(string expression)
        {
            // 1. 수식을 토큰화
            var tokens = TokenizeExpression(expression);

            // 2. 중위 표기법을 후위 표기법으로 변환
            var postfix = ConvertToPostfix(tokens);

            // 3. 후위 표기법을 계산
            return CalculatePostfix(postfix);
        }




    }
}
