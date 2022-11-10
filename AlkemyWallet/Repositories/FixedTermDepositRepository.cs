﻿using AlkemyWallet.DataAccess;
using AlkemyWallet.Entities;
using AlkemyWallet.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AlkemyWallet.Repositories;

public class FixedTermDepositRepository : RepositoryBase<FixedTermDeposit>, IFixedTermDepositRepository
{
    public FixedTermDepositRepository(WalletDbContext context)
        : base(context)
    {
    }
    public async Task<IEnumerable<FixedTermDeposit>> GetByUser(int userId)
    {
        return await Task.FromResult(_context.Set<FixedTermDeposit>().Where(t => t.User_id == userId).AsEnumerable());
    }

    public async Task<FixedTermDeposit?> GetFixedTermById(int id, int userId)
    {
        return await Task.FromResult(_context.Set<FixedTermDeposit>().Where(t => t.Id == id && t.User_id == userId).FirstOrDefault());

    }
}