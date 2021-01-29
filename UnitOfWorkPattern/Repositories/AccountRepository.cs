using Microsoft.EntityFrameworkCore;
using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(CarRentalContext CarRentalContext) : base(CarRentalContext)
        {
        }
        public async Task<Account> GetAccountByIdAsync(string id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.AccountId == id);
        }

        public async Task<List<Account>> GetAllAccountsAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}
