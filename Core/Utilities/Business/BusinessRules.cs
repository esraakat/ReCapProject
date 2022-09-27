using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //params - virgülle aırarak istediğim kadar IResult verebilirim
        {
            foreach (var logic in logics)
            {
                if (!logic.Success) //parametreyle gönderilen iş kurallarına uymayanları business'a bildir
                    return logic;
            }
            return new SuccessResult();
        }
    }
}
