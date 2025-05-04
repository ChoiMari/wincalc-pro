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

        
        // -------------------메서드 선언 ------------------
        /// <summary>
        /// 사용자 컨트롤 로드 메서드
        /// </summary>
        /// <param name="control">form1에 삽입 시킬 컨트롤</param>
        private void LoadUserControl(UserControl control)
        {
            panel_main.Controls.Clear();      // 기존 컨트롤 제거
            control.Dock = DockStyle.Fill;   // 채우기
            panel_main.Controls.Add(control); // 새 컨트롤 추가
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
            LoadUserControl(stdCalcControl);
        }
    }
}
