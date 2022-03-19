using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResul<T> : DataResult<T>
    {
        public ErrorDataResul(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResul(T data) : base(data, false)
        {

        }
        public ErrorDataResul(string message) : base(default, true, message)
        {

        }
        public ErrorDataResul() : base(default, true)
        {

        }
    }
}
