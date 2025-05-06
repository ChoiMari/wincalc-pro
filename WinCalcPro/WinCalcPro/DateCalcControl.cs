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

        }
    }
}
