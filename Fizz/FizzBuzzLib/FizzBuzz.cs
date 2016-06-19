using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        private long _nextnum;
        private long _start;
        private long _end;
        private List<FizzBuzzArgs> _args;

        public FizzBuzz()
        {

        }

        public FizzBuzz(long start, long end, List<FizzBuzzArgs> args)
        {
            if (start >= end)
                throw new ArgumentException("'start' argument is greater than or equal to 'end' argument");

            if (end > 100000000)
                throw new ArgumentOutOfRangeException("end", "'end' argument is greater than 100,000,000");

            _start = start;
            _end = end;
            _args = args;

            _nextnum = _start;
        }

        /// <summary> 
        /// Next - Method that returns the next numeric string / replacement sequence using the _nextnum counter
        /// <para>Useful for large number ranges that can take up large amounts of memory</para>
        /// </summary>
        /// <returns>string Next numeric or replacement string</returns>
        public string Next()
        {
            if (_nextnum <= _end)
                return (ProcessNumber(_nextnum++, _args));
            else
                return (null);
        }

        /// <summary> 
        /// ProcessBulk - Method that will process all the numbers at once and return an array of results
        /// </summary>
        /// <returns>string[] Array of all processed numeric/replacement strings</returns>
        public string[] ProcessBulk(long start, long end, List<FizzBuzzArgs> args)
        {                                
            if (start >= end)
                throw new ArgumentException("'start' argument is greater than or equal to 'end' argument");

            if (end > 100000000)
                throw new ArgumentOutOfRangeException("end", "'end' argument is greater than 100,000,000");

            try
            {
                string[] _retstr = new string[(end - start)+1];

                long x = start;
                long cnt = 0;
                while (x <= end)
                {
                    _retstr[cnt++] = ProcessNumber(x, args);
                    x++;
                }

                return (_retstr);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        protected string ProcessNumber(long num, List<FizzBuzzArgs> args)
        {
            string RetStr = string.Empty;

            foreach (FizzBuzzArgs _arg in args)
            {
                if (num % _arg.DIVIDE_BY == 0)
                {
                    RetStr += _arg.DIVIDE_STR;
                }
            }

            if (RetStr == string.Empty)
                RetStr = num.ToString();

            return RetStr;
        }
    }

    public class FizzBuzzArgs
    {
        public FizzBuzzArgs(string DivStr, long DivLong)
        {
            this.DIVIDE_STR = DivStr;
            this.DIVIDE_BY = DivLong;
        }

        string m_dividestr;
        public string DIVIDE_STR
        {
            get
            {
                return m_dividestr;
            }
            set
            {
                m_dividestr = value;
            }
        }

        long m_divideby;
        public long DIVIDE_BY
        {
            get
            {
                return m_divideby;
            }
            set
            {
                m_divideby = value;
            }
        }

    }
}