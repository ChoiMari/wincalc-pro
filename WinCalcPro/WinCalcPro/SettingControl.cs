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

        private void SettingControl_Load(object sender, EventArgs e)
        {
            label_info_content.Text =
                "\r\n  Windows 계산기 클론 프로그램   \r\n"
                + "  2025-05-02 ~ 2025-05-07   \r\n\r\n";
            label_copyright.Text =
                "이 프로그램은 Windows 계산기를 참고하여 제작된 \r\n" +
                "비공식 클론입니다. Microsoft와는 무관하며,\r\n" +
                "교육 및 개인 학습용으로만 사용됩니다.";
        }

        private void linkLabel_icon_copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/kr/");
        }
    }
}
