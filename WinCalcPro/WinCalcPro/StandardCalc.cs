/*******************************
 * 작성일 : 2025-05-02
 * 작성자 : 최마리
 * 최종 수정일 :
 * 변경 내용 :
 *******************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCalcPro
{
    // 표준 계산기 
    internal class StandardCalc
    {
        // 함수 정의(C#에서는 파스칼 표기법 사용, 함수명 - 동사형으로 짓기)

        // 더하기
        public double Add(double x, double y) {
            double result = x + y;

            return result;
        }

        // 빼기
        public double Subtract(double x, double y)
        {
            double result = x - y;

            return result;
        }

        // 곱하기
        public double Multiply(double x, double y)
        {
            double result = x * y;

            return result;
        }

        // 나누기
        public double Divide(double x, double y)
        {

            if (y == 0)
            { // 0으로는 나눌 수 없음 
                return double.NaN;
            }

            double result = x / y;

            return result;
        }

        // 제곱근(루트 씌움)
        public double Sqrt(double x)
        {

            if (x < 0)
            {
                return double.NaN;
            }

            double result = Math.Sqrt(x);
            return result;
        }

        // 제곱
        public double Square(double x)
        {
            double result = x * x;

            return result;
        }

        // 1/x 버튼, 역수(입력된 숫자 x에 대해 1 / x를 계산함)
        // x가 0이면 예외 처리(0으로는 나눌 수 없음)
        public double Reciprocal(double x)
        {

            if (x == 0)
            {
                return double.NaN;
                // Not a Number : 수학적으로 정의되지 않은 값이나 계산할 수 없는 값을 나타내는 특별한 값 
                // 반환값을 받을 때는 주로 if문과 함께 double.IsNaN(result) 사용. result가 NaN이면 True반환 

            }

            return 1 / x;
        }

    } //StandardCalc 클래스 끝
}
