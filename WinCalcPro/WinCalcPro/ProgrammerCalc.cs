using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalcPro
{
    internal class ProgrammerCalc
    {
        /// <summary>
        /// <<
        /// </summary>
        /// 
        public long Left(long value,int count)
        {
            return value << count;
        }
        /// <summary>
        /// >>
        /// </summary>
        /// 
        public long Right(long value,int count)
        {
            return value >> count;
        }

        ///<summary>
        ///% 
        /// </summary>
        /// 
        public decimal Percent(decimal value)
        {
            return value / 100;
        }
        public ScientificCalc scientificCalc;
    }
}
