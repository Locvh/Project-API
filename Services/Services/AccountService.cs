using Project_API.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkPattern.Repositories;

namespace Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<Account> AddAccountAsync(Account newAccount)
        {
            return await _accountRepository.AddAsync(newAccount);
        }

        public async Task<Account> GetAccountByIdAsync(string id)
        {
            return await _accountRepository.GetAccountByIdAsync(id);
        }

        public async Task<List<Account>> GetAllAccountsAsync()
        {
            return await _accountRepository.GetAllAccountsAsync();
        }
    }
}
