﻿using BaseLibrary.Entities;
using BaseLibrary.Responses;
using Microsoft.EntityFrameworkCore;
using ServerLibrary.Data;
using ServerLibrary.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repositories.Implementations
{
    public class AccountingCompleteRepository(AppDbContext context) : IGenericRepositoryInterface<AccountingComplete>
    {
        public async Task<GeneralResponse> DeleteById(int id)
        {
            var accountingComplete = await context.AccountingComplete.FindAsync(id);
            if (accountingComplete == null)
                return NotFound();

            context.AccountingComplete.Remove(accountingComplete);
            await Commit();
            return Success();
        }

        public async Task<List<AccountingComplete>> GetAll() => await context.AccountingComplete.ToListAsync();
        public async Task<AccountingComplete> GetById(int id) => await context.AccountingComplete.FindAsync(id);

        public async Task<GeneralResponse> Insert(AccountingComplete item)
        {
            if (!await CheckName(item.Name!))
                return new GeneralResponse(false, "Accounting details already added");
            await Commit();
            return Success();
        }

        public async Task<GeneralResponse> Update(AccountingComplete item)
        {
            var accountingComplete = await context.AccountingComplete.FindAsync(item.Id);
            if (accountingComplete == null)
                return NotFound();
            accountingComplete.Name = item.Name;
            await Commit();
            return Success();
        }

        private static GeneralResponse NotFound() => new(false, "Sorry, accounting details not found");
        private static GeneralResponse Success() => new(true, "Process completed!");
        private async Task Commit() => await context.SaveChangesAsync();
        private async Task<bool> CheckName(string name)
        {
            var item = await context.AccountingComplete.FirstOrDefaultAsync(x => x.Name!.ToLower().Equals(name.ToLower()));
            return item is null;
        }
    }
}
