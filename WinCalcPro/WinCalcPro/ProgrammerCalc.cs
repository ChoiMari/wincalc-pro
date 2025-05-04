using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCalcPro
{
    internal class ProgrammerCalc
    {
        /// <summary>
        /// <<
        /// </summary>
        /// 
        public long Left(long value)
        {
            return value << 1;
        }
        /// <summary>
        /// >>
        /// </summary>
        /// 
        public long Right(long value)
        {
            return value >> 1;
        }

        ///<summary>
        ///% 
        /// </summary>
        /// 
        public decimal Percent(decimal value)
        {
            return value / 100;
        }
    }
}
