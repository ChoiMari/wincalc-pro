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
            
            input_number.KeyPress += new KeyPressEventHandler(input_number_KeyPress);
            // 숫자만 입력받도록 이벤트 핸들러 추가
        }

        /// <summary>
        /// 키보드 숫자만 입력 받도록 설정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 숫자와 제어 문자만 허용
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // 입력을 무시
            }
        }
        ScientificCalc sc = new ScientificCalc();
        decimal UserInput(string input)
        {
            decimal number;
            if (decimal.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                input_number.Text = "";
                return 0;
            }
        }

        private void sin_Click(object sender, EventArgs e)
        {
            input_number.Text= sc.Sin(UserInput(input_number.Text)).ToString();
        }
    }
}
