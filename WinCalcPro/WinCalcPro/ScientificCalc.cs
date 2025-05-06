using System;
using System.Collections.Generic;
using System.Data;
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
        /// 역수
        /// </summary>
        public decimal Inverse(decimal number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException("0으로 나눌 수 없습니다.");
            }
            return 1 / number;
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
       /// 나누기
       /// </summary>
       public decimal Div(decimal number, decimal number2)
        {
            try
            {
                return number / number2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("0으로 나눌 수 없습니다.");
            }
        }

        ///<summary>
        /// 더하기
        /// </summary>
        public decimal Add(decimal number,decimal number2)
        {
            return number + number2;
        }
        /// <summary>
        /// 빼기
        /// </summary>
        public decimal Sub(decimal number, decimal number2)
        {
            return number - number2;
        }
        /// <summary>
        /// 곱하기
        /// </summary>
        public decimal Mul(decimal number, decimal number2)
        {
            return number * number2;
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
        /// exp 지수 함수
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public decimal Exp(decimal number)
        {
            return (decimal)Math.Exp((double)number);
        }
        /// <summary>
        /// mod 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public decimal Mod(decimal number, decimal number2)
        {
            try
            {
                return number % number2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException("0으로 나눌 수 없습니다.");

            }
        }

        /// <summary>
        /// ( )기능 구현
        /// </summary>
        /// 
        DataTable dt = new DataTable();
        public decimal Calculate(string expression)
        {
            try
            {
                return Convert.ToDecimal(dt.Compute(expression, string.Empty));
            }
            catch (EvaluateException)
            {
                throw new EvaluateException("잘못된 수식입니다.");
            }
        }


        /// <summary>
        /// sin 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public double Sin(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return Math.Sin(radians);
        }
        /// <summary>
        /// cos
        /// </summary>
        /// <param name="number"></param>
        public decimal Cos(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return (decimal)Math.Cos(radians);
        }
        /// <summary>
        /// tan
        /// </summary>
        /// <param name="number"></param>
        public decimal Tan(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return (decimal)Math.Tan(radians);
        }
        /// <summary>
        /// hyp
        /// </summary>
        /// <param name="number"></param>
        public decimal Hyp(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return (decimal)Math.Sinh(radians);
        }
        /// <summary>
        /// sec
        /// </summary>
        /// <param name="number"></param>
        public decimal Sec(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return (decimal)(1 / Math.Cos(radians));
        }
        /// <summary>
        /// csc
        /// </summary>
        /// 
        public decimal Csc(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return (decimal)(1 / Math.Sin(radians));
        }
        /// <summary>
        /// cot
        /// </summary>
        /// 
        public decimal Cot(decimal number)
        {
            // 도를 라디안으로 변환
            double radians = (double)number * (Math.PI / 180);
            return (decimal)(1 / Math.Tan(radians));
        }
        ///<summary>
        ///10의 제곱
        /// </summary>
        /// 
        public decimal SquareOfTen(decimal number)
        {
            //10제곱 리턴
            return (decimal)Math.Pow((double)number,10);
        }
        ///<summary>
        /// In 자연로그 
        /// </summary>
        /// 
        public decimal naturalLog(decimal number)
        {
            return (decimal)Math.Log((double)number);
        }

        /// <summary>
        /// 계산 결과 기록
        /// </summary>
        /// 
        List<string> history = new List<string>();
        public void AddToHistory(string operation)
        {
            history.Add(operation);
        }
        public List<string> GetHistory()
        {
            return history;
        }
    }
}
