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
    public partial class StdCalcControl : UserControl
    {
        public StdCalcControl()
        {
            InitializeComponent();
        } // StdCalcControl() 끝

        
        // 상수 선언 
        const int MAX_LENGTH = 16; // textBoxResult 최대 자리수 지정
        
        // 전역 변수(필드) 선언 --------------------
        StandardCalc std = new StandardCalc(); //StandardCalc에서 정의한 메서드 사용하기 위해 객체 생성

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
            if (lenth >= 10 && lenth <= 12)
            { // textBoxresult의 Text속성값의 길이가 10~12일 때 실행
                result.Font = ChangeFont(result.Font.FontFamily, 28f);
            }
            else if (lenth >= 13 && lenth <= 14)
            { //13~14
                result.Font = ChangeFont(result.Font.FontFamily, 24f);
            }
            else if (lenth >= 15 && lenth <= 16)
            { // 15~16
                result.Font = ChangeFont(result.Font.FontFamily, 21f);
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

            // 0인 상태에서는 0이 없어지고 새로씀
            if (textBoxResult.Text == "0")
            {

                textBoxResult.Text = btn.Text;

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
    }
}
