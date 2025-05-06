/**************************************
 * WinCalcPro
 * StdCalcControl.cs
 * 작성자 : 최마리
 * 작성일 : 2025-05-06
 * 최종 수정일 : 2025-05-06
 * 설명 : 표준 계산기 사용자 정의 컨트롤 구현
 * 
 * 수정사항 : 
 * 
 * 
 *************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WinCalcPro
{
    public partial class StdCalcControl : UserControl
    {
        public StdCalcControl()
        {
            InitializeComponent();
        } // StdCalcControl() 끝

        
        // 상수 선언 
        const int MAX_LENGTH = 16; // textBoxResult 최대 자리수 지정(입력 제한)
        
        // 전역 변수(필드) 선언 --------------------
        StandardCalc std = new StandardCalc(); //StandardCalc에서 정의한 메서드 사용하기 위해 객체 생성
        decimal savedNum1 = 0; //= 클릭 시 맨 처음 textBoxRsult에 있던 값
        decimal savedNum2 = 0; //= 클릭 시 두 번째 textBoxRsult에 있던 값
        string op = ""; // 사칙연산을 위한 연산자
        bool isOpClicked = false; // 사칙연산 버튼 클릭 여부 확인하기 위한 변수
   
        // 메서드 정의 -----------------------
        /// <summary>
        /// 폰트(글꼴 + 글자 크기) 변경 메서드
        /// </summary>
        /// <param name="fontFamily">글꼴</param>
        /// <param name="size">글자 크기</param>
        /// <returns>폰트 객체를 반환</returns>
        Font ChangeFont(FontFamily fontFamily, float size) {
            if (fontFamily == null || size <= 0) { //예외처리
                return SystemFonts.DefaultFont; // 시스템기본폰트반환
            }
            return new Font(fontFamily, size);
        }

        /// <summary>
        /// 입력창에 맞게 폰트 사이즈 조절 하여 textBoxResult.Text에 저장하여(화면에 출력)
        /// </summary>
        /// <param name="result">textBox 객체(textBoxResult를 아규먼트로 넣길 원함)</param>
        void DrawTextWithFontSize(TextBox result) {
            // 입력창에 맞게 폰트 사이즈 조절(안그럼 표시가 안되고 짤림)
            
            //천단위구분쉼표와 소수점을 제거하고 길이를 셈
           int lenth = result.Text.Replace(",", "").Replace(".","").Length;
            if (lenth <= 9) //9 이하시
            {
                result.Font = ChangeFont(result.Font.FontFamily, 33.75f);
            }
            else if (lenth >= 10 && lenth <= 12)
            { // textBoxresult의 Text속성값의 길이가 10~12일 때 실행
                result.Font = ChangeFont(result.Font.FontFamily, 26f);
            }
            else if (lenth >= 13 && lenth <= 14)
            { //13~14
                result.Font = ChangeFont(result.Font.FontFamily, 22f);
            }
            else if (lenth >= 15 && lenth <= 16)
            { // 15~16
                result.Font = ChangeFont(result.Font.FontFamily, 20f);
            }
        }

        /// <summary>
        /// 정수 부분에만 천단위 구분 기호를 넣는 메서드
        /// .(소수점)을 기준으로 정수 부분과 소수점이하 부분으로 나눔
        /// </summary>
        /// <param name="tb">textBox 객체</param>
        void FormatWithCommaOnlyInt(TextBox tb) {
            
            string[] result = tb.Text.Split('.');
            // result[0] : 정수 부분, result[1] : 실수 부분
            
            if (result.Length == 1) { // 정수 부분만 있는 경우 
                decimal.TryParse(result[0], out decimal num1); //정수 부분에 천단위 구분기호 넣기 위해 decimal타입으로 변환
                result[0] = num1.ToString("N0");// 천단위 구분 쉼표 형식
                tb.Text = result[0];
                return; // 정수 부분만 있는 경우는 여기서 끝
            }
            decimal.TryParse(result[0], out decimal num2); //정수 부분에 천단위 구분기호 넣기 위해 decimal타입으로 변환
            result[0] = num2.ToString("N0");// 천단위 구분 쉼표 형식
            tb.Text = result[0] + "." + result[1]; // 정수 부분과 실수 부분 합치기
        }

        // 에러 발생 시 비활성화 되는 버튼
        void DisableButtons()
        {
            btnPercent.Enabled = false;
            btnRecip.Enabled = false;
            btnSquare.Enabled = false;
            btnSqrt.Enabled = false;
            btnDivision.Enabled = false;
            btnMultip.Enabled = false;
            btnSubtrac.Enabled = false;
            btnAdd.Enabled = false;
            btnPM.Enabled = false;
            btnEqual.Enabled = false;
            btnDecipoint.Enabled = false;
            btnBack.Enabled = false;
            btnEqual.BackColor = Color.WhiteSmoke; // 비활성화 시 버튼 색상 변경
        }

        // 비활성화 시켰던 버튼 다시 활성화
        void enableButtons()
        {
            btnPercent.Enabled = true;
            btnRecip.Enabled = true;
            btnSquare.Enabled = true;
            btnSqrt.Enabled = true;
            btnDivision.Enabled = true;
            btnMultip.Enabled = true;
            btnSubtrac.Enabled = true;
            btnAdd.Enabled = true;
            btnPM.Enabled = true;
            btnEqual.Enabled = true;
            btnDecipoint.Enabled = true;
            btnBack.Enabled = true;
            btnEqual.BackColor = Color.FromArgb(0, 103, 192); // 비활성화 시 버튼 색상 변경
        }


        // 버튼 클릭 이벤트 -------------------

        /// <summary>
        /// 0~9까지의 숫자 버튼 클릭 이벤트 
        /// </summary>
        /// <param name="sender">이벤트 발생 객체, 어떤 버튼이 클릭되었는지 알려준다</param>
        /// <param name="e">이벤트 추가 정보 담은 객체(마우스, 키보드, 클릭 횟수 등)</param>
        private void BtnNum(object sender, EventArgs e)
        {
            /// <summary>
            /// sender: 이벤트를 발생시킨 객체 (object 타입)
            /// as Button: sender를 Button 타입으로 안전하게 형변환 (실패 시 null 반환)
            /// 눌린 버튼의 정보를 Button 타입 변수 btn에 저장
            /// 참고: btn.Text(눌린 버튼의 텍스트) 또는 btn.Name(버튼의 Name 속성) 등으로 사용 가능
            /// </summary>
            Button btn = sender as Button;

            // 0인 상태에서는 0이 없어지고 새로씀 또는 사칙연산 버튼이 클릭된 직후에는 새로씀
            if (textBoxResult.Text == "0" || isOpClicked == true 
                || textBoxResult.Text == "0으로 나눌 수 없습니다."
                || textBoxExp.Text.Contains("="))
            {
                if (textBoxResult.Text == "0으로 나눌 수 없습니다." || textBoxExp.Text.Contains("=")) {
                    textBoxExp.Text = ""; // textBoxExp 초기화
                    textBoxResult.Text = "0"; // textBoxResult 초기화
                    enableButtons(); // 버튼 활성화
                    textBoxResult.Text = btn.Text;
                    DrawTextWithFontSize(textBoxResult); // 글자 크기 조절해서 화면에 출력
                }
                textBoxResult.Text = btn.Text; // 새로 쓰기 
                isOpClicked = false; // 사칙연산 버튼 클릭 여부 초기화
            }
            else
            { // textBoxResult가 0이 아니면 실행

                // textBoxResult에 ,(천단위구분쉼표)와 .(소수점) 제거하고 길이를 셈
                // Relace() 메서드는 바꿔줄 문자열이 없으면 원래 문자열을 반환
                int lenth = textBoxResult.Text.Replace(",", "").Replace(".", "").Length;
                // 입력 크기 제한(LENTH_MAX) : 정수만 입력했을 경우(MAX_LENTH까지)
                // 정수 + 소수점 입력했을 경우(MAX_LENTH까지)
                // 0.으로 시작하는 소수자리수만 표현했을 경우(소수점이하 MAX_LENTH까지) 전체 MAX_LENTH + 1
                if (!(textBoxResult.Text.Contains(".")))
                { //소수점이 없는경우(정수만 입력한 경우)
                    if (lenth >= MAX_LENGTH)
                    {
                        return; // 최대 자리수 이상시 입력 불가(클릭이벤트 종료)
                    }
                    textBoxResult.Text += btn.Text; // textBoxResult.Text에 덧붙임
                    // 천단위 구분 쉼표 출력 위해 decimal타입으로 변환
                    decimal.TryParse(textBoxResult.Text, out decimal num);
                    textBoxResult.Text = num.ToString("N0");// 천단위 구분 쉼표 형식
                }
                else if (textBoxResult.Text.Contains("."))
                { // 소수점이 있는 경우(실수인 경우)
                    //0.으로 시작하는 소수자리수만 표현했을 경우(소수점이하 MAX_LENTH까지) 전체 MAX_LENTH + 1
                    if (textBoxResult.Text.Contains("0.") && lenth >= MAX_LENGTH + 1)
                    {
                        return; // 입력제한, 클릭이벤트 종료
                    }
                    else if (textBoxResult.Text.Contains("0.") && lenth < MAX_LENGTH + 1)
                    {
                        textBoxResult.Text += btn.Text; // textBoxResult.Text에 덧붙임(이경우엔 천단위 구분쉼표 안붙임)

                    }
                    else if (lenth >= MAX_LENGTH)
                    { // 정수 + 소수점 입력했을 경우(입력제한 MAX_LENTH까지)
                        return; // 입력제한, 클릭이벤트 종료
                    }
                    else
                    { // 정수 + 실수이면서, MAX_LENTH보다 작을 경우
                        textBoxResult.Text += btn.Text; // textBoxResult.Text에 덧붙임
                        // 정수 부분, 실수 부분으로 나눠서(.을 기준으로) 정수 부분에는 천단위 구분 기호 표시한 다음에 합치기
                        string[] result = textBoxResult.Text.Split('.');
                        // result[0] : 정수 부분, result[1] : 실수 부분
                        decimal.TryParse(result[0], out decimal num); //정수 부분에 천단위 구분기호 넣기 위해 decimal타입으로 변환
                        result[0] = num.ToString("N0");// 천단위 구분 쉼표 형식
                        textBoxResult.Text = result[0] + "." + result[1]; // 정수 부분과 실수 부분 합치기
                    }
                }

                DrawTextWithFontSize(textBoxResult); // 글자 크기 조절해서 화면에 출력                  
            }// 0~9 숫자 클릭 이벤트 끝
    }
        // 소수점(.)버튼 클릭 이벤트
        private void btnDecipoint_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = std.DecimalPoint(textBoxResult.Text);
        }

        // +/- 버튼 클릭 이벤트
        private void btnPM_Click(object sender, EventArgs e)
        {
            // textBoxResult를 decimal타입으로 변환
            decimal.TryParse(textBoxResult.Text, out decimal num);
            textBoxResult.Text = std.ChangeSign(num).ToString(); // 부호를 바꿔서 textBoxResult에 저장
            
            //정수 + 소수점이하로 나눠서 정수부분에만 천단위 구분 기호 표시
            FormatWithCommaOnlyInt(textBoxResult);
        }


        // 사칙 연산(+, -, ×, ÷) 버튼 클릭 이벤트
        private void btnOperator(object sender, EventArgs e)
        {
            isOpClicked = true; // 사칙연산 버튼 클릭 여부 확인하기 위한 변수
            // true이면 사칙연산 버튼 클릭됨
            decimal.TryParse(textBoxResult.Text, out decimal num);
            // textBoxResult를 decimal타입으로 변환
            // decimal.TryParse() 메서드는 변환 성공 시 true, 실패 시 false 반환
            
            savedNum1 = num; // 연산자 클릭 시 원래 textBoxRsult에 있던 값 저장
            Button btn = sender as Button; // 클릭된 버튼을 Button 타입으로 형변환

            // btn.Text : 클릭된 버튼의 텍스트(+, -, ×, ÷)
            // 눌린 버튼의 text속성값
            switch (btn.Text)
            {
                case "＋":
                    op = "＋";
                    break;
                case "－":
                    op = "－";
                    break;
                case "×":
                    op = "×";
                    break;
                case "÷":
                    op = "÷";
                    break;
            }

            textBoxExp.Text = savedNum1.ToString() + " " + op;
            // textBoxExp.Text에 연산자와 함께 저장해서 표시함

        }


        // = 버튼 클릭 이벤트
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 현재 textBoxResult에 있는 값을 decimal타입으로 변환(num에 저장됨)
            // decimal.TryParse() 메서드는 변환 성공 시 true, 실패 시 false 반환
            decimal.TryParse(textBoxResult.Text, out decimal num);

            if (!(textBoxExp.Text.Contains("=")))
            { // = 버튼 클릭 한 적 없으면 실행
                savedNum2 = num;
                switch (op)
                {
                    case "＋":
                        textBoxExp.Text += " " + num.ToString() + " = ";
                        textBoxResult.Text = std.Add(savedNum1, num).ToString();
                        FormatWithCommaOnlyInt(textBoxResult); // 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                    case "－":
                        textBoxExp.Text += " " + num.ToString() + " = ";
                        textBoxResult.Text = std.Subtract(savedNum1, num).ToString();
                        FormatWithCommaOnlyInt(textBoxResult);// 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                    case "×":
                        textBoxExp.Text += " " + num.ToString() + " = ";
                        textBoxResult.Text = std.Multiply(savedNum1, num).ToString();
                        FormatWithCommaOnlyInt(textBoxResult);// 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                    case "÷":
                        decimal? result = std.Divide(savedNum1, num);
                        textBoxExp.Text += " " + num.ToString() + " = ";
                        if (result == null)
                        {
                            textBoxResult.Text = "0으로 나눌 수 없습니다.";
                            DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                            DisableButtons();// 비활성화 되는 버튼
                            break;//switch 문 전체에서 빠져나옴
                        }
                        textBoxResult.Text = result.ToString();
                        FormatWithCommaOnlyInt(textBoxResult);// 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                }
            }
            else if (textBoxExp.Text.Contains("="))
            { // = 버튼 클릭한 적 있으면 실행
                
                savedNum1 = num; // 연산자 클릭 시 원래 textBoxRsult에 있던 값 저장
                textBoxExp.Text 
                    = savedNum1.ToString() + " " + op + " " + savedNum2.ToString() + " = ";
                switch (op) {
                    case "＋":
                        textBoxResult.Text = std.Add(savedNum1, savedNum2).ToString();
                        FormatWithCommaOnlyInt(textBoxResult); // 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                    case "－":                  
                        textBoxResult.Text = std.Subtract(savedNum1, savedNum2).ToString();
                        FormatWithCommaOnlyInt(textBoxResult);// 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                    case "×":
                        textBoxResult.Text = std.Multiply(savedNum1, savedNum2).ToString();
                        FormatWithCommaOnlyInt(textBoxResult);// 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                    case "÷":
                        decimal? result = std.Divide(savedNum1, savedNum2);
                        if (result == null)
                        {
                            textBoxResult.Text = "0으로 나눌 수 없습니다.";
                            DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                            DisableButtons();// 비활성화 되는 버튼
                            break;//switch 문 전체에서 빠져나옴
                        }
                        textBoxResult.Text = result.ToString();
                        FormatWithCommaOnlyInt(textBoxResult);// 천단위 구분 기호 넣기
                        DrawTextWithFontSize(textBoxResult);// 입력길이에 맞춰 font size 조절
                        break;
                }

            }

        } // btnEqual_Click 이벤트 끝
    }
}
