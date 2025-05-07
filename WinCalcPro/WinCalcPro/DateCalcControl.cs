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
    public partial class DateCalcControl : UserControl
    {
        public DateCalcControl()
        {
            InitializeComponent();
        }

        private void DateCalcControl_Load(object sender, EventArgs e)
        {
            toolStripComboBox_date.SelectedIndex = 0; // 기본값 설정
        }

        private void toolStripComboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 콤보박스에서 선택된 인덱스를 가져옴
           int index = toolStripComboBox_date.SelectedIndex;

            // 선택된 인덱스에 따라 화면에 표시할 패널을 전환
            switch (index) {
                case 0:
                    panel_date0.Visible = true; //인덱스 0인 경우 패널 0을 보이게 함
                    panel_date1.Visible = false; // 패널 1을 숨김
                    break;
                case 1:
                    panel_date0.Visible = false; //인덱스 1인 경우 패널 0을 숨김
                    panel_date1.Visible = true; // 패널 1을 보이게 함
                    break;
            }
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

        void LightTheme() { 
        
        }
        void DarkTheme() {
            this.BackColor = Color.FromArgb(26, 34, 39);
            panel_date0.BackColor = Color.FromArgb(26, 34, 39);
            panel_date1.BackColor = Color.FromArgb(26, 34, 39);
            
            radioBtn_panel1_add.BackColor = Color.FromArgb(26, 34, 39);
            radioBtn_panel1_minus.BackColor = Color.FromArgb(26, 34, 39);
            radioBtn_panel1_add.ForeColor = Color.White;
            radioBtn_panel1_minus.ForeColor = Color.White;
            label_diff.ForeColor = Color.White;
            label_end.ForeColor = Color.White;
            label_panel1_date.ForeColor = Color.White;
            label_panel1_day.ForeColor = Color.White;
            label_panel1_month.ForeColor = Color.White;
            label_panel1_result.ForeColor = Color.White;
            label_panel1_start.ForeColor = Color.White;
            label_panel1_year.ForeColor = Color.White;
            label_result.ForeColor = Color.White;
            label_start.ForeColor = Color.White;

            

        }

    }
}
