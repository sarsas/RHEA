﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHEA
{
    public class AccountInfo
    {
        private readonly int _accountId;
        private readonly IAccountService _accountService;

        public AccountInfo(int accountId, IAccountService accountService)
        {
            _accountId = accountId;
            _accountService = accountService;
        }

        public double Amount { get; private set; }

        public async Task RefreshAmountAsync()
        {
            Amount = await _accountService.GetAccountAmountAsync(_accountId);
        }

    }
}
