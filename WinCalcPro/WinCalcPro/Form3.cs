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
    public partial class Form3 : Form
    {
        ProgrammerCalc pc=new ProgrammerCalc();
        public Form3()
        {
            InitializeComponent();
            // 10진수로
            Dec_Click(this, EventArgs.Empty);

            // input_number의 TextChanged 이벤트에 핸들러 추가
            input_number.TextChanged += InputNumber_TextChanged;
        }
        private void InputNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // 입력값이 유효한 정수인지 확인
                if (int.TryParse(input_number.Text, out int number))
                {
                    // 각 진수로 변환하여 텍스트 박스에 표시
                    textHex.Text = Convert.ToString(number, 16).ToUpper(); // 16진수
                    textDec.Text = Convert.ToString(number, 10);          // 10진수
                    textOct.Text = Convert.ToString(number, 8);           // 8진수
                    textBin.Text = Convert.ToString(number, 2);           // 2진수
                }
                else
                {
                    // 유효하지 않은 입력일 경우 초기화
                    textHex.Text = string.Empty;
                    textDec.Text = string.Empty;
                    textOct.Text = string.Empty;
                    textBin.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                // 예외 처리 (필요시 로그 추가)
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Hex_Click(object sender, EventArgs e)
        {
            // Abtn 활성화
            ABtn.Enabled = true;
            BBtn.Enabled = true;
            CBtn.Enabled = true;
            DBtn.Enabled = true;
            EBtn.Enabled = true;
            FBtn.Enabled = true;
            // 10진수 버튼 활성화
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = true;
            Number_3.Enabled = true;
            Number_4.Enabled = true;
            Number_5.Enabled = true;
            Number_6.Enabled = true;
            Number_7.Enabled = true;
            Number_8.Enabled = true;
            Number_9.Enabled = true;
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            // 10진수 버튼 활성화 및 16진수 버튼 비활성화
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            DBtn.Enabled = false;
            EBtn.Enabled = false;
            FBtn.Enabled = false;
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = true;
            Number_3.Enabled = true;
            Number_4.Enabled = true;
            Number_5.Enabled = true;
            Number_6.Enabled = true;
            Number_7.Enabled = true;
            Number_8.Enabled = true;
            Number_9.Enabled = true;

        }

        private void Oct_Click(object sender, EventArgs e)
        {
            // 8진수 버튼 활성화 및 16진수 버튼 비활성화
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            DBtn.Enabled = false;
            EBtn.Enabled = false;
            FBtn.Enabled = false;
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = true;
            Number_3.Enabled = true;
            Number_4.Enabled = true;
            Number_5.Enabled = true;
            Number_6.Enabled = true;
            Number_7.Enabled = true;
            Number_8.Enabled = false;
            Number_9.Enabled = false;

        }

        private void Bin_Click(object sender, EventArgs e)
        {
            // 2진수 버튼 활성화 및 16진수 버튼 비활성화
            ABtn.Enabled = false;
            BBtn.Enabled = false;
            CBtn.Enabled = false;
            DBtn.Enabled = false;
            EBtn.Enabled = false;
            FBtn.Enabled = false;
            Number_0.Enabled = true;
            Number_1.Enabled = true;
            Number_2.Enabled = false;
            Number_3.Enabled = false;
            Number_4.Enabled = false;
            Number_5.Enabled = false;
            Number_6.Enabled = false;
            Number_7.Enabled = false;
            Number_8.Enabled = false;
            Number_9.Enabled = false;


        }

        private void ABtn_Click(object sender, EventArgs e)
        {
            // 16진수 A 10
            input_number.Text += 0xA;
        }

        private void BBtn_Click(object sender, EventArgs e)
        {
            input_number.Text += 0xB; 
        }

        private void CBtn_Click(object sender, EventArgs e)
        {

        }

        private void DBtn_Click(object sender, EventArgs e)
        {

        }

        private void EBtn_Click(object sender, EventArgs e)
        {

        }

        private void FBtn_Click(object sender, EventArgs e)
        {

        }

        private void Number_9_Click(object sender, EventArgs e)
        {
            input_number.Text += "9";   
        }

        private void Number_8_Click(object sender, EventArgs e)
        {
            input_number.Text += "8";
        }

        private void Number_7_Click(object sender, EventArgs e)
        {
            input_number.Text += "7";
        }

        private void Number_6_Click(object sender, EventArgs e)
        {
            input_number.Text += "6";
        }

        private void Number_5_Click(object sender, EventArgs e)
        {
            input_number.Text += "5";
        }

        private void Number_4_Click(object sender, EventArgs e)
        {
            input_number.Text += "4";
        }

        private void Number_3_Click(object sender, EventArgs e)
        {
            input_number.Text += "3";
        }

        private void Number_2_Click(object sender, EventArgs e)
        {
            input_number.Text += "2";
        }

        private void Number_1_Click(object sender, EventArgs e)
        {
            input_number.Text += "1";
        }

        private void Number_0_Click(object sender, EventArgs e)
        {
            input_number.Text += "0";
        }

        private void Left_Click(object sender, EventArgs e)
        {
            
        }

        private void Right_Click(object sender, EventArgs e)
        {
            

        }

        private void CEBtn_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }

        private void Parentheses_Click(object sender, EventArgs e)
        {

        }

        private void ParenthesesEnd_Click(object sender, EventArgs e)
        {

        }

        private void Percent_Click(object sender, EventArgs e)
        {

        }

        private void Sharing_Click(object sender, EventArgs e)
        {

        }

        private void Multiplication_Click(object sender, EventArgs e)
        {

        }

        private void Minus_Click(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Click(object sender, EventArgs e)
        {

        }

        private void Conversion_Click(object sender, EventArgs e)
        {

        }
    }
}
