using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkPattern.Repositories
{
   public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> GetAccountByIdAsync(String id);

        Task<List<Account>> GetAllAccountsAsync();
    }
}
