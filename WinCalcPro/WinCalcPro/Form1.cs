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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } // Form1 끝

        // 전역 변수(필드) 선언
        /// <summary>
        /// 메뉴 상태를 추적하는 변수 (true: 열림, false: 닫힘)
        /// </summary>
        private bool isMenuOpen = false;

        /// <summary>
        /// 메뉴를 보여주는 메서드
        /// </summary>
        private void ShowMenu() {
            isMenuOpen = true; // 메뉴 열림 상태로 변경
            panel_menu.BringToFront();// 패널을 앞면으로 가져옴
            button_menu.Visible = false; // 햄버거 버튼은 숨기기
            button_close.Visible = true; // 닫기 버튼 보이게

            // 타이머를 사용하여 메뉴 펼치기
            Timer timer = new Timer();
            timer.Interval = 10; // 타이머 간격
            timer.Tick += Timer_Tick; // 이벤트 핸들러를 메서드로 연결
            timer.Start();

        }

        /// <summary>
        /// 메뉴를 숨기는 메서드
        /// </summary>
        private void HideMenu() {
            button_close.Visible = false;// 닫기 버튼 숨기기
            button_menu.Visible = true; // 햄버거 버튼 보이게
            isMenuOpen = false; // 메뉴 닫힘 상태로 변경
            
            // 타이머를 사용하여 메뉴 닫기
            Timer timer = new Timer();
            timer.Interval = 10; // 타이머 간격
            timer.Tick += Timer_Tick; // 이벤트 핸들러를 메서드로 연결
            timer.Start();
        }

        /// <summary>
        /// 타이머 이벤트 핸들러
        /// </summary>
        /// <param name="sender">이벤트를 발생시킨 객체</param>
        /// <param name="e">이벤트 관련 데이터</param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isMenuOpen) // 메뉴가 열려있다면
            {
                // 메뉴 펼치기(너비를 늘리는 애니메이션)
                if (panel_menu.Width < 220) // 원하는 최종 너비 미만이면 실행됨
                {
                    panel_menu.Width += 10; // 패널 크기 조금씩 늘림
                }
                else
                {
                    // 메뉴가 최대로 펼쳐졌으면 타이머 멈춤
                    Timer timer = sender as Timer;
                    timer.Stop();
                }
            }
            else // 메뉴가 닫혀있다면
            {
                // 메뉴 접기 (너비를 줄이는 애니메이션)
                if (panel_menu.Width > 0)  // 원하는 최소 너비 이상이면 실행(0이 될때까지 실행된다는 뜻)
                {
                    panel_menu.Width -= 25; // 패널 크기 조금씩 줄임
                }
                else
                {
                    // 메뉴가 완전히 접혔으면 타이머 멈춤
                    Timer timer = sender as Timer;
                    timer.Stop();
                }
            }
        }

        // 메뉴 버튼 클릭 이벤트 핸들러
        private void button_menu_Click(object sender, EventArgs e)
        {
            ShowMenu();
        }

        // 메뉴 닫기 버튼 클릭 이벤트 핸들러
        private void button_close_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void label_calc_Click(object sender, EventArgs e)
        {

        }
    }
}
