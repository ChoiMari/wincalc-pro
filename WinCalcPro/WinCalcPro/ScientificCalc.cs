using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCalcPro
{
    internal class ScientificCalc
    {

/// <summary>
///  2025.05.02.
///  김철수
///  공학용 계산기 내용 추가
/// </summary>
/// <returns></returns>

        // 파이 출력
        decimal Pi()
        {
            return Math.PI;
        }
        decimal E()
        {
            return Math.E;
        }
        // 제곱근
        decimal Sqrt(decimal number)
        {
            return (decimal)Math.Sqrt((double)number);
        }
        // 제곱
        decimal Pow(decimal number, decimal exponent)
        {
            return (decimal)Math.Pow((double)number, (double)exponent);
        }
        // 로그
        decimal Log(decimal number, decimal baseNumber)
        {
            return (decimal)Math.Log((double)number, (double)baseNumber);
        }
        // 로그10
        decimal Log10(decimal number)
        {
            return (decimal)Math.Log10((double)number);
        }
        //팩토리얼
        decimal n=0;
        decimal Fatory(decimal number)
        {
            n += number;
            if (number < 0)
            {
                return n;
            }
            Fatory(number - 1);
        }
        // |x|
        decimal Abs(decimal number)
        {
            return Math.Abs(number);
        }
        // exp
        decimal Exp(decimal number)
        {
            return Math.Exp(number);
        }
        //mod
        decimal Mod(decimal number,decimal number2)
        {
            return number % number2;
        }


    }
}
