using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHEA
{
    public interface IAccountService
    {
        Task<double> GetAccountAmountAsync(int accountId);
    }
}
