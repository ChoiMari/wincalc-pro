using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCalcPro
{
    /// <summary>
    ///  2025.05.02.
    ///  김철수
    ///  공학용 계산기 내용 추가
    /// </summary>
    /// <returns></returns>
    internal class ScientificCalc
    {



        /// <summary>
        /// 파이 출력
        /// </summary>
        /// <returns></returns>
        public decimal Pi()
        {
            return (decimal)Math.PI;
        }

        /// <summary>
        /// 상수 e 출력
        /// </summary>
        /// <returns></returns>
        public decimal E()
        {
            return (decimal)Math.E;
        }
        /// <summary>
        /// 제곱근
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public decimal Sqrt(decimal number)
        {
            return (decimal)Math.Sqrt((double)number);
        }
        /// <summary>
        /// 제곱
        /// </summary>
        /// <param name="number"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        public decimal Pow(decimal number, decimal exponent)
        {
            return (decimal)Math.Pow((double)number, (double)exponent);
        }
        /// <summary>
        /// 로그
        /// </summary>
        /// <param name="number"></param>
        /// <param name="baseNumber"></param>
        /// <returns></returns>
        public decimal Log(decimal number, decimal baseNumber)
        {
            return (decimal)Math.Log((double)number, (double)baseNumber);
        }
        /// <summary>
        /// 로그 10
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public decimal Log10(decimal number)
        {
            return (decimal)Math.Log10((double)number);
        }

        decimal n =0;
        /// <summary>
        ///  팩토리얼
        /// </summary>
        public decimal Fatory(decimal number)
        {
            n += number;
            if (number > 0)
            {
                Fatory(number - 1);
            }
            return n;
        }
        /// <summary>
        /// lxl 절대값
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public decimal Abs(decimal number)
        {
            return Math.Abs(number);
        }
        /// <summary>
        /// exp 자연로그
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public decimal Exp(double number)
        {
            return (decimal)Math.Exp(number);
        }
        /// <summary>
        /// mod 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public decimal Mod(decimal number,decimal number2)
        {
            return number % number2;
        }
        /// <summary>
        /// sin 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public decimal Sin(decimal number)
        {
            return (decimal)Math.Sin((double)number);
        }


    }
}
