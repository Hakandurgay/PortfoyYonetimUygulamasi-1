﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfoyYonetimUygulamasi.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        ICoinRepository Coins { get; } //unitofWork.Coins diyerek erişilir
        IPortfolioRepository  Portfolios { get; }
        ITransactionTypeRepository TransactionTypes { get; }
        ITransactionRepository Transactions { get; }
        IUserRepository Users { get; }
        IWalletRepository Wallets { get; }

        Task<int> SaveAsync();
    }
}