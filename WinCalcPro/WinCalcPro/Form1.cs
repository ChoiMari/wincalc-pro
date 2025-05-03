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
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            panel_menu.Width = 200; // 너비 설정 (필요한 만큼 조절)
            button_close.Visible = true; // 닫기 버튼 보이게
            button_menu.Visible = false; // 햄버거 버튼은 숨기기
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            panel_menu.Width = 0; // 다시 닫기
            button_close.Visible = false;
            button_menu.Visible = true;
        }
    }
}
