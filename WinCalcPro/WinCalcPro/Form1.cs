﻿using System;
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
        private AppTheme CurrentTheme;

        public Form1()
        {
            InitializeComponent();
            CurrentTheme = AppTheme.Light;
        } // Form1 끝


        //-------------- 전역 변수(필드) 선언 --------------
        /// <summary>
        /// 메뉴 상태를 추적하는 변수 (true: 열림, false: 닫힘)
        /// </summary>
        private bool isMenuOpen = false;


        //------------------- 메서드 선언 ------------------

        //테마 ---------------------
        public void ChangeTheme(AppTheme theme)
        {
            if (theme == AppTheme.Light)
            {
                CurrentTheme = AppTheme.Light;
                // 테마를 적용하는 함수 호출
                LightTheme();


            }
            else if (theme == AppTheme.Dark) 
            {
                CurrentTheme = AppTheme.Dark;
                // 테마를 적용하는 메서드 호출
                DarkTheme();
            }
        }

        // LightTheme()로 바꾸는 메서드
        void LightTheme() { 
            panel_header.BackColor = Color.FromArgb(243, 242, 249);
            panel_main.BackColor = Color.FromArgb(243, 242, 249);
            panel_menu.BackColor = Color.FromArgb(250, 248, 252);
            tableLayoutPanel_menu_button.BackColor = Color.FromArgb(250, 248, 252);
            tableLayoutPanel_menu_setting.BackColor = Color.FromArgb(250, 248, 252);
            button_menu.BackColor = Color.FromArgb(243, 242, 249);
            button_menu_close.BackColor = Color.FromArgb(250, 248, 252);
            button_menu_date.BackColor = Color.FromArgb(250, 248, 252);
            button_menu_date.ForeColor = Color.Black;
            button_menu_prog.BackColor = Color.FromArgb(250, 248, 252);
            button_menu_prog.ForeColor = Color.Black;
            button_menu_sci.BackColor = Color.FromArgb(250, 248, 252);
            button_menu_sci.ForeColor = Color.Black;
            button_menu_setting.BackColor = Color.FromArgb(250, 248, 252);
            button_menu_setting.ForeColor = Color.Black;
            button_menu_date.ForeColor = Color.Black;
            button_menu_std.BackColor = Color.FromArgb(250, 248, 252);
            button_menu_std.ForeColor = Color.Black;
            label_calc.BackColor = Color.FromArgb(250, 248, 252);
            label_calc.ForeColor = Color.Black;
            label_title.BackColor = Color.FromArgb(243, 242, 249);
            label_title.ForeColor = Color.Black;
            panel_hr.BackColor = Color.Gainsboro;

            button_menu.Image = Properties.Resources.menuImg;
            button_menu_close.Image = Properties.Resources.menuImg;
            button_menu_date.Image = Properties.Resources.dateImg;
            button_menu_prog.Image = Properties.Resources.prog;
            button_menu_sci.Image = Properties.Resources.sci;
            button_menu_setting.Image = Properties.Resources.setting;
            button_menu_std.Image = Properties.Resources.stdImg;
        }

        // DarkTheme()로 바꾸는 메서드
        void DarkTheme()
        {
            button_menu.Image = Properties.Resources.menuImg_dark;
            button_menu_close.Image = Properties.Resources.menuImg_dark;
            button_menu_date.Image = Properties.Resources.dateImg_dark;
            button_menu_prog.Image = Properties.Resources.prog_dark;
            button_menu_sci.Image = Properties.Resources.sci_dark;
            button_menu_setting.Image = Properties.Resources.setting_dark;
            button_menu_std.Image = Properties.Resources.stdImg_dark;

            panel_header.BackColor = Color.FromArgb(26, 34, 39);
            panel_main.BackColor = Color.FromArgb(26, 34, 39);
            panel_menu.BackColor = Color.FromArgb(40, 46, 51);
            tableLayoutPanel_menu_button.BackColor = Color.FromArgb(40, 46, 51);
            tableLayoutPanel_menu_setting.BackColor = Color.FromArgb(40, 46, 51);
            button_menu.BackColor = Color.FromArgb(26, 34, 39);
            button_menu_close.BackColor = Color.FromArgb(40, 46, 51);
            button_menu_date.BackColor = Color.FromArgb(40, 46, 51);
            button_menu_date.ForeColor = Color.White;
            button_menu_prog.BackColor = Color.FromArgb(40, 46, 51);
            button_menu_prog.ForeColor = Color.White;
            button_menu_sci.BackColor = Color.FromArgb(40, 46, 51);
            button_menu_sci.ForeColor = Color.White;
            button_menu_setting.BackColor= Color.FromArgb(40, 46, 51);
            button_menu_setting.ForeColor = Color.White;
            button_menu_std.BackColor = Color.FromArgb(40, 46, 51);
            button_menu_std.ForeColor = Color.White;
            label_calc.BackColor = Color.FromArgb(40, 46, 51);
            label_calc.ForeColor = Color.White;
            label_title.BackColor = Color.FromArgb(26, 34, 39);
            label_title.ForeColor = Color.White;
            panel_hr.BackColor = Color.DimGray;
   
        }

        /// <summary>
        /// 사용자 컨트롤 삽입 메서드
        /// </summary>
        /// <param name="control">form1에 삽입 시킬 컨트롤</param>
        private void LoadUserControl(UserControl control, String title)
        {
            panel_main.Controls.Clear();      // 기존 컨트롤 제거
            control.Dock = DockStyle.Fill;   // 채우기
            panel_main.Controls.Add(control); // 새 컨트롤 삽입(추가)
            label_title.Text = title; // 레이블 제목 변경
        }


        /// <summary>
        /// Form1이 로드될 때 호출되는 이벤트 핸들러 : 
        /// 표준 계산기 컨트롤을 삽입
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            StdCalcControl stdCalcControl = new StdCalcControl();
            LoadUserControl(stdCalcControl, "표준");
        }

        /// <summary>
        /// 메뉴를 보여주는 메서드
        /// </summary>
        private void ShowMenu()
        {
            isMenuOpen = true; // 메뉴 열림 상태로 변경
            panel_menu.BringToFront();// 패널을 앞면으로 가져옴
            button_menu.Visible = false; // 햄버거 버튼은 숨기기
            button_menu_close.Visible = true; // 닫기 버튼 보이게

            // 타이머를 사용하여 메뉴 펼치기
            Timer timer = new Timer();
            timer.Interval = 10; // 타이머 간격
            timer.Tick += Timer_Tick; // 이벤트 핸들러를 메서드로 연결
            timer.Start();

        }

        /// <summary>
        /// 메뉴를 숨기는 메서드
        /// </summary>
        private void HideMenu()
        {
            button_menu_close.Visible = false;// 닫기 버튼 숨기기
            button_menu.Visible = true; // 햄버거 버튼 보이게
            isMenuOpen = false; // 메뉴 닫힘 상태로 변경

            // 타이머를 사용하여 메뉴 닫기
            Timer timer = new Timer();
            timer.Interval = 10; // 타이머 간격
            timer.Tick += Timer_Tick; // 이벤트 핸들러를 메서드로 연결
            timer.Start();
        }

        /// <summary>
        /// 타이머 이벤트 핸들러(햄버거메뉴 애니메이션에 이용)
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
            ShowMenu(); // 햄버거 메뉴 보여주기
        }

        // 메뉴 닫기 버튼 클릭 이벤트 핸들러
        private void button_menu_close_Click(object sender, EventArgs e)
        {
            HideMenu(); // 햄버거 메뉴 감추기
        }

        // 햄버거 메뉴의 표준 계산기 버튼 클릭 이벤트 핸들러 
        private void button_menu_std_Click(object sender, EventArgs e)
        {
            HideMenu(); // 햄버거 메뉴 감추기
            StdCalcControl stdCalcControl = new StdCalcControl();
            LoadUserControl(stdCalcControl, "표준");
            stdCalcControl.ChangeTheme(CurrentTheme);
        }

        // 햄버거 메뉴의 공학 계산기 버튼 클릭 이벤트 핸들러
        private void button_menu_sci_Click(object sender, EventArgs e)
        {
            HideMenu();// 햄버거 메뉴 감추기
            SciCalcControl sciCalcControl = new SciCalcControl();
            LoadUserControl(sciCalcControl, "공학용");
            sciCalcControl.ChangeTheme(CurrentTheme);
        }

        private void button_menu_prog_Click(object sender, EventArgs e)
        {
            HideMenu();// 햄버거 메뉴 감추기
            ProgCalcControl progCalcControl = new ProgCalcControl();
            LoadUserControl(progCalcControl, "프로그래머");
            progCalcControl.ChangeTheme(CurrentTheme);
        }

        private void button_menu_date_Click(object sender, EventArgs e)
        {
            HideMenu();// 햄버거 메뉴 감추기
            DateCalcControl dateCalcControl = new DateCalcControl();
            LoadUserControl(dateCalcControl, "날짜 계산");
            dateCalcControl.ChangeTheme(CurrentTheme);
        }

        private void button_menu_setting_Click(object sender, EventArgs e)
        {
            HideMenu();// 햄버거 메뉴 감추기
            SettingControl settingControl = new SettingControl();
            LoadUserControl(settingControl, "설정");
            settingControl.ChangeTheme(CurrentTheme);
            
        }


    }
}
