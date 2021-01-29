using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_API.Models;
using Services.Services;

namespace Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService AccountService)
        {
            _accountService = AccountService;
        }
        [HttpPost]
        public async Task<ActionResult<Account>> CreateCustomer()
        {
            var account = new Account
            {
                AccountId = "SE130466",
                Password = "Loc",
                FullName = "Vo",
                Role="user",
                Status = true
            };

            return await _accountService.AddAccountAsync(account);
        }
        [HttpGet]
        public async Task<ActionResult<List<Account>>> GetAllAccounts()
        {
            return await _accountService.GetAllAccountsAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccountById(string id)
        {
            return await _accountService.GetAccountByIdAsync(id);
        }
    }
}
