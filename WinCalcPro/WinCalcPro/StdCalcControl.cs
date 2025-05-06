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
        StandardCalc std = new StandardCalc();

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

            if (textBoxResult.Text.Replace(",", "").Length >= MAX_LENGTH)
            {//텍스트박스 문자열의 ,를 제거해서 길이를 구함
                return; //MAX_LENGTH 이상이면 클릭이벤트 함수 종료
            }

            // 0인 상태에서는 0이 없어지고 새로씀
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = btn.Text;
            }
            else
            { // textBoxResult가 0이 아니면 실행

                textBoxResult.Text += btn.Text; //기존 문자열에 덧붙힘
                // 눌린 버튼(btn)의 Text속성을 가져와서 기존 결과창에 덧붙임
                // decimal타입으로 변환(double타입은 정밀도에 한계가 있어서 변경함)
                decimal.TryParse(textBoxResult.Text, out decimal result);
                textBoxResult.Text = result.ToString("N"); //천단위구분기호형식으로 출력
            }

            // 입력창에 맞게 폰트 사이즈 조절(안그럼 표시가 안되고 짤림)
            //천단위구분쉼표를 제거하고 길이를 셈
            int lenth = textBoxResult.Text.Replace(",", "").Length;
            if (lenth >= 10 && lenth <= 12)
            { // textBoxresult의 Text속성값의 길이가 10~12일 때 실행
                textBoxResult.Font = ChangeFont(textBoxResult.Font.FontFamily, 28f);
            }
            else if (lenth >= 13 && lenth <= 14)
            { //13~14
                textBoxResult.Font = ChangeFont(textBoxResult.Font.FontFamily, 24f);
            }
            else if (lenth >= 15 && lenth <= 16)
            { // 15~16
                textBoxResult.Font = ChangeFont(textBoxResult.Font.FontFamily, 21f);
            }

        }// 0~9 숫자 클릭 이벤트 끝

        // 소수점(.)버튼 클릭 이벤트
        private void btnDecipoint_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = std.DecimalPoint(textBoxResult.Text);
        }
    }
}
