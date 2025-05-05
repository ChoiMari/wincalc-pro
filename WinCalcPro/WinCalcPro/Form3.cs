using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinCalcPro
{
    public partial class Form3 : Form
    {
        ProgrammerCalc pc=new ProgrammerCalc();
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
        public Form3()
        {
            InitializeComponent();
            // 10진수로
            Dec_Click(this, EventArgs.Empty);

            // input_number의 TextChanged 이벤트에 핸들러 추가
            input_number.TextChanged += InputNumber_TextChanged;
        }
        private void InputNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // 입력값이 유효한 정수인지 확인
                if (long.TryParse(input_number.Text, out long number))
                {
                    // 각 진수로 변환하여 텍스트 박스에 표시
                    textHex.Text = Convert.ToString(number, 16).ToUpper(); // 16진수
                    textDec.Text = Convert.ToString(number, 10);          // 10진수
                    textOct.Text = Convert.ToString(number, 8);           // 8진수
                    textBin.Text = Convert.ToString(number, 2);           // 2진수
                    // C를 CE로 변경
                    CEBtn.Name = "CE";
                }
                else
                {
                    // 유효하지 않은 입력일 경우 초기화
                    textHex.Text = string.Empty;
                    textDec.Text = string.Empty;
                    textOct.Text = string.Empty;
                    textBin.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                // 예외 처리 (필요시 로그 추가)
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hex_Click(object sender, EventArgs e)
        {
            // Abtn 활성화
            ABtn.Enabled = true;
            BBtn.Enabled = true;
            CBtn.Enabled = true;
            DBtn.Enabled = true;
            EBtn.Enabled = true;
            FBtn.Enabled = true;
            // 10진수 버튼 활성화
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = true;
            Number_3.Enabled = true;
            Number_4.Enabled = true;
            Number_5.Enabled = true;
            Number_6.Enabled = true;
            Number_7.Enabled = true;
            Number_8.Enabled = true;
            Number_9.Enabled = true;
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            // 10진수 버튼 활성화 및 16진수 버튼 비활성화
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            DBtn.Enabled = false;
            EBtn.Enabled = false;
            FBtn.Enabled = false;
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = true;
            Number_3.Enabled = true;
            Number_4.Enabled = true;
            Number_5.Enabled = true;
            Number_6.Enabled = true;
            Number_7.Enabled = true;
            Number_8.Enabled = true;
            Number_9.Enabled = true;

        }

        private void Oct_Click(object sender, EventArgs e)
        {
            // 8진수 버튼 활성화 및 16진수 버튼 비활성화
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            DBtn.Enabled = false;
            EBtn.Enabled = false;
            FBtn.Enabled = false;
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = true;
            Number_3.Enabled = true;
            Number_4.Enabled = true;
            Number_5.Enabled = true;
            Number_6.Enabled = true;
            Number_7.Enabled = true;
            Number_8.Enabled = false;
            Number_9.Enabled = false;

        }

        private void Bin_Click(object sender, EventArgs e)
        {
            // 2진수 버튼 활성화 및 16진수 버튼 비활성화
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            DBtn.Enabled = false;
            EBtn.Enabled = false;
            FBtn.Enabled = false;
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = false;
            Number_3.Enabled = false;
            Number_4.Enabled = false;
            Number_5.Enabled = false;
            Number_6.Enabled = false;
            Number_7.Enabled = false;
            Number_8.Enabled = false;
            Number_9.Enabled = false;


        }

        private void ABtn_Click(object sender, EventArgs e)
        {
            // 16진수 A 10
            input_number.Text += 0xA;
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            input_number.Text += 0xB; 
        }

        private void CBtn_Click(object sender, EventArgs e)
        {

        }

        private void DBtn_Click(object sender, EventArgs e)
        {

        }

        private void EBtn_Click(object sender, EventArgs e)
        {

        }

        private void FBtn_Click(object sender, EventArgs e)
        {

        }

        private void Number_9_Click(object sender, EventArgs e)
        {
            input_number.Text += "9";   
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            input_number.Text += "8";
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            input_number.Text += "7";
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            input_number.Text += "6";
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            input_number.Text += "5";
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            input_number.Text += "4";
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            input_number.Text += "3";
        }

        private void Number_2_Click(object sender, EventArgs e)
        {
            input_number.Text += "2";
        }

        private void Number_1_Click(object sender, EventArgs e)
        {
            input_number.Text += "1";
        }

        private void Number_0_Click(object sender, EventArgs e)
        {
            input_number.Text += "0";
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " << " + preview.Text;
                input_number.Text = "";
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " >> " + preview.Text;
                input_number.Text = "";
            }

        }

        private void CEBtn_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0 || preview.Text.Length > 0)
            {
                input_number.Text = "";
                CEBtn.Name = "C";
            }
            else if(CEBtn.Name == "C")
            {
                input_number.Text = "";
                preview.Text = "";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // 뒤로 한 글자 지우기
            if (input_number.Text.Length > 0)
            {
                input_number.Text = input_number.Text.Substring(0, input_number.Text.Length - 1);
            }
        }

        private void Parentheses_Click(object sender, EventArgs e)
        {
            input_number.Text += "(";
        }

        private void ParenthesesEnd_Click(object sender, EventArgs e)
        {
            input_number.Text += ")";
        }

        private void Percent_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " % " + preview.Text;
                input_number.Text = "";
            }
        }

        private void Sharing_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " / " + preview.Text;
                input_number.Text = "";
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " * " + preview.Text;
                input_number.Text = "";
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " - " + preview.Text;
                input_number.Text = "";
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (input_number.Text.Length > 0)
            {
                preview.Text = input_number.Text + " + " + preview.Text;
                input_number.Text = "";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = input_number.Text;
                decimal result1 = EvaluateExpression(expression);
                input_number.Text = result1.ToString();
                preview.Text = ""; // 연산 완료 후 preview 초기화
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string code = preview.Text;
            decimal result = 0;

            // 연산자와 숫자 분리
            if (code.Contains("+"))
            {
                var parts = code.Split('+');
                if (parts.Length == 2)
                {
                    result = pc.scientificCalc.Add(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("-"))
            {
                var parts = code.Split('-');
                if (parts.Length == 2)
                {
                    result = pc.scientificCalc.Sub(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("*"))
            {
                var parts = code.Split('*');
                if (parts.Length == 2)
                {
                    result = pc.scientificCalc.Mul(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if (code.Contains("/"))
            {
                var parts = code.Split('/');
                if (parts.Length == 2)
                {
                    result = pc.scientificCalc.Div(UserInput(parts[0]), UserInput(input_number.Text));
                }
            }
            else if(code.Contains("<<"))
            {
                var parts = code.Split(new string[] { "<<" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    result = pc.Left(int.Parse(parts[0]), int.Parse(input_number.Text));
                }
            }
            else if (code.Contains(">>"))
            {
                var parts = code.Split(new string[] { ">>" }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    result = pc.Right(int.Parse(parts[0]), int.Parse(input_number.Text));
                }
            }
            else if (code.Contains("%"))
            {
                var parts = code.Split('%');
                if (parts.Length == 2)
                {
                    result = int.Parse(parts[0])% int.Parse(input_number.Text);
                }
            }
            {
                
            }
            // 결과 표시
            input_number.Text = result.ToString();
            preview.Text = ""; // 연산 완료 후 preview 초기화
        }

        private void Conversion_Click(object sender, EventArgs e)
        {
            input_number.Text = input_number.Text.StartsWith("-") ? input_number.Text.Substring(1) : "-" + input_number.Text;
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
