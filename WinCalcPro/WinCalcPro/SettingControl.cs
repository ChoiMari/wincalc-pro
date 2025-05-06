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
    public partial class SettingControl : UserControl
    {
        public SettingControl()
        {
            InitializeComponent();
            

        }

        //테마 ---------------------
        public void ChangeTheme(AppTheme theme)
        {
            if (theme == AppTheme.Light)
            {
                
                // 테마를 적용하는 함수 호출
                LightTheme();
                radioButton_light.Checked = true;


            }
            else if (theme == AppTheme.Dark)
            {
                
                // 테마를 적용하는 메서드 호출
                DarkTheme();
                radioButton_dark.Checked = true;
            }
        }

        // LightTheme()로 바꾸는 메서드
        void LightTheme()
        {
            this.BackColor = Color.FromArgb(243, 242, 249);
            panel_theme.BackColor = Color.White;
            label_information.BackColor = Color.White;
            label_info_content.BackColor = Color.White;
            label_copyright.ForeColor = Color.Black;
            label_shape.ForeColor = Color.Black;
            label_shape.BackColor = Color.FromArgb(243, 242, 249);
            label_icon_copyright.ForeColor = Color.Black;
            label_information.BackColor = Color.FromArgb(243, 242, 249);
            label_information.ForeColor = Color.Black;
            radioButton_dark.ForeColor = Color.Black;
            radioButton_light.ForeColor = Color.Black;
            label_info_content.ForeColor = Color.Black;
            linkLabel_icon_copyright.LinkColor = Color.Navy;
            

        }

        // DarkTheme()로 바꾸는 메서드
        void DarkTheme()
        {
            this.BackColor = Color.FromArgb(26, 34, 39);
            panel_theme.BackColor = Color.FromArgb(38, 45, 50);
            label_information.BackColor = Color.FromArgb(26, 34, 39);
            label_info_content.BackColor = Color.FromArgb(38, 45, 50);
            label_copyright.ForeColor = Color.White;
            label_shape.BackColor = Color.FromArgb(26, 34, 39);
            label_shape.ForeColor = Color.White;
            label_icon_copyright.ForeColor = Color.White;
            label_information.ForeColor = Color.White;
            radioButton_dark.ForeColor = Color.White;
            radioButton_light.ForeColor = Color.White;
            label_info_content.ForeColor = Color.White;
            linkLabel_icon_copyright.LinkColor = Color.Aqua;

        }

        // 이벤트 ---------------------------
        private void SettingControl_Load(object sender, EventArgs e)
        {
            label_info_content.Text =
                  "\r\n  계산기 프로그램               \r\n"
                + "  2025-05-02 ~ 2025-05-07           \r\n\r\n";
            label_copyright.Text =
                "이 프로그램은 Windows 계산기를 참고하여 개발한 \r\n" +
                "학습용 프로젝트입니다. Microsoft와는 무관하며,\r\n" +
                "교육 및 개인 학습용으로만 사용됩니다.";
        }

        private void linkLabel_icon_copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/kr/");
        }

        //라디오 버튼 체크에 변화가 생기면 이벤트 발생
        private void radioButtonTheme(object sender, EventArgs e)
        {
            //체크된 라디오 버튼을 가져옴(어느 라디오 버튼이 체크되었는지)
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked) {
                
                // 선택된 테마를 저장할 변수
                AppTheme selectedTheme;

                if (rb.Text == "Light")
                {
                    selectedTheme = AppTheme.Light;
                    ChangeTheme(selectedTheme);
                    
                }
                else if (rb.Text == "Dark")
                {
                    selectedTheme= AppTheme.Dark;
                    ChangeTheme(selectedTheme);
                    
                }
                else
                {
                    return; // 다른 버튼이면 무시
                }

                // 이 설정 컨트롤이 올라가 있는 Form1을 찾아서
                Form1 mainForm = this.FindForm() as Form1;

                // Form1에 테마 변경 요청
                mainForm?.ChangeTheme(selectedTheme);
                //mainForm이 null이 아닐 때만 ChangeTheme()호출해라.
                //mainForm이 null이면 → 아무 일도 안 일어남(에러도 안 나고 그냥 무시)
            }
        }


    }
}
