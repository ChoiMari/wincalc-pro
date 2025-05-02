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

    } //StandardCalc 클래스 끝
}
