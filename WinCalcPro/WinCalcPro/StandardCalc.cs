﻿/*******************************
 * 작성일 : 2025-05-02
 * 작성자 : 최마리
 * -----------------------------
 * 최종 수정일 : 
 * 최종 작성자 :
 * 변경 내용 :
 *******************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace WinCalcPro
{
    // 표준 계산기 
    internal class StandardCalc
    {
        // 함수 정의(C#에서는 파스칼 표기법 사용, 함수명 - 동사형으로 짓기)

        /// <summary>
        /// 더하기 : 두 숫자를 더합니다.
        /// </summary>
        /// <param name="x">첫 번째 피연산자</param>
        /// <param name="y">두 번째 피연산자</param>
        /// <returns>x와 y를 더한 결과</returns>
        public decimal Add(decimal x, decimal y) {
            return x + y;
        }

        /// <summary>
        /// 빼기 : 두 숫자를 뺍니다.
        /// </summary>
        /// <param name="x">첫 번째 피연산자</param>
        /// <param name="y">두 번째 피연산자</param>
        /// <returns>x에서 y를 뺀 결과</returns>
        public decimal Subtract(decimal x, decimal y) {
            return x - y; 
        }

        /// <summary>
        /// 곱하기 : 두 수를 곱합니다.
        /// </summary>
        /// <param name="x">첫 번째 피연산자</param>
        /// <param name="y">두 번째 피연산자</param>
        /// <returns>x와 y를 곱한 결과</returns>
        public decimal Multiply(decimal x, decimal y) {
            return x * y;
        }

        /// <summary>
        /// 나누기 : 두 수를 나눕니다.
        /// </summary>
        /// <param name="x">피제수(나눠지는 수)</param>
        /// <param name="y">제수(나누는 수)</param>
        /// <returns>x를 y로 나눈 결과(단, y가 0이면 null 반환함)</returns>
        public decimal? Divide(decimal x, decimal y) {
            //decimal?은 nullable decimal, 즉 "널을 담을 수 있는 decimal 타입"
            if (y == 0) { // 0으로는 나눌 수 없음 
                return null;
            }

            return x / y;
        }

        /// <summary>
        /// 제곱근(루트) : 아규먼트로 넣은 x의 제곱근(루트)을 구합니다.
        /// </summary>
        /// <param name="x">입력 값</param>
        /// <returns>제곱근 값(단, x가 음수이면 double.NaN을 반환함)</returns>
        public double Sqrt(double x) {

            if (x < 0) { // 음수는 제곱근을 구할 수 없음
                return double.NaN; // Not a Number, Double.IsNaN()으로 확인 가능
            }

            double result = Math.Sqrt(x);
            return result;
        }

        /// <summary>
        /// 제곱 : 아규먼트로 넣은 x의 제곱을 구합니다.
        /// </summary>
        /// <param name="x">입력 값</param>
        /// <returns>x의 제곱</returns>
        public double Square(double x) {
            return x * x;
        }

        // 1/x 버튼, 역수(입력된 숫자 x에 대해 1 / x를 계산함)
        // x가 0이면 예외 처리(0으로는 나눌 수 없음)
        /// <summary>
        /// 역수 : 아규먼트로 넣은 x의 역수(1/x)를 계산합니다.
        /// </summary>
        /// <param name="x">입력 값</param>
        /// <returns>역수(1/x) 값(단, x가 0이면 double.NaN을 반환함)</returns>
        public double Reciprocal(double x) {

            if (x == 0) {
                return double.NaN;
                // Not a Number : 수학적으로 정의되지 않은 값이나 계산할 수 없는 값을 나타내는 특별한 값 
                // 반환값을 받을 때는 주로 if문과 함께 double.IsNaN(result) 사용. result가 NaN이면 True반환 
            }

            return 1 / x;
        }

        // % : 퍼센트 계산(기준값이 없으면 0처리)
        public decimal Percent(decimal left, decimal right, string op)
        {
            switch (op)
            {
                case "＋":
                    return  (left * right / 100);
                case "－":
                    return (left * right / 100);
                case "×":
                case "*":
                    return (right / 100);
                case "÷":
                case "/":
                    return (right / 100);
                default:
                    return 0; // 잘못된 연산자일 경우 0 반환
            }
        }


        /// <summary>
        /// CE : 지금 입력하고 있는 값을 "0"으로 만듭니다.(현재 입력값 지우기)
        /// </summary>
        /// <returns>현재 입력값을 "0"으로 만들어 반환</returns>
        public string ClearEntry() {
            string result = "0"; // 현재 입력값을 0으로 초기화
            return result;
        }


        /// <summary>
        /// 백스페이스(⌫) : 맨 뒤의 한 글자를 지운다.
        /// </summary>
        /// <param name="s">입력 문자열</param>
        /// <returns>마지막 한 문자가 제거된 새 문자열 반환(빈 문자열이면 "0"을 반환)</returns>
        public string Backspace(string s) {

            // 입력 문자열이 null이거나 빈 문자열일 경우 "0"리턴
            if (string.IsNullOrEmpty(s)) { //s가 빈문자열("") 또는 null이면 true
                return "0";
            }

            string result = s.Remove(s.Length - 1, 1); // 맨 뒤에서 한 글자 지우기
            //string 클래스의 Remove(int startIndex, int count)
            // ㄴ startIndex는 제거를 시작할 인덱스(0부터 시작), count는 제거할 문자 수
            //원본 문자열은 수정되지 않으므로 새로운 문자열을 저장해서 리턴함
            return result;
        }

        // = : 계산 결과를 보여줍니다.

        /// <summary>
        /// . 소수점을 추가합니다.
        /// </summary>
        /// <param name="s">입력값</param>
        /// <returns>아규먼트로 넣은 문자열에 소수점(.)을 추가함(단, 이미 소수점(.)이 포함 되어 있는 경우 그대로 반환)</returns>
        public string DecimalPoint(string s)
        {
            // 현재 입력값에 소수점(.)을 추가
            if (s.Contains(".")) { // 이미 소수점이 포함되어 있으면 아무것도 하지 않고 그대로 반환
                return s;
            }
            string result = s + "."; // 현재 입력값에 소수점 추가
            return result;
        }

        /// <summary>
        /// +/- : 입력값의 부호를 변경합니다
        /// </summary>
        /// <param name="x">입력값</param>
        /// <returns>부호를 바꿔서 반환</returns>
        public decimal ChangeSign(decimal x)
        {
            return -x; // 부호를 바꿔서 반환
        }

        // 메모리 버튼 MC & MR & M : 메모리에 값이 저장되어야 활성화됨 
        // M+ : 메모리에 더하기
        /// <summary>
        /// 메모리 더하기 : 메모리에 저장된 값에 x를 더합니다.
        /// </summary>
        /// <param name="x">입력 값</param>
        /// <param name="memory">메모리에 저장된 값</param>
        /// <returns>메모리에 저장된 값에 x를 더한 값을 반환</returns>
        public double MemoryPlus(double x, double memory) {
            return memory + x; // 메모리에 x를 더한 값을 반환
        }



    } //StandardCalc 클래스 끝
}
