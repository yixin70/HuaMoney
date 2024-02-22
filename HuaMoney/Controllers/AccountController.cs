using HuaMoney.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using HuaMoney.Dto.Account;
using HuaMoney.ViewModel.Account;
using System.Runtime.Intrinsics.X86;

namespace HuaMoney.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITransactionService _transactionService;
        private readonly IAccountService _accountService;
        private readonly ICurrencyService _currencyService;
        private readonly IBankService _bankService;

        public AccountController(ITransactionService transactionService, 
                                        IAccountService accountService,
                                        IMapper mapper,
                                        ICurrencyService currencyService,
                                        IBankService bankService)
        {
            _transactionService = transactionService;
            _accountService = accountService;
            _mapper = mapper;
            _currencyService = currencyService;
            _bankService = bankService;
        }

        [HttpGet("[controller]/[action]")]
        [HttpGet("[controller]")]
        public async Task<IActionResult> Index()
        {
            var accounts = await _accountService.Find();
            var vm = new AccountIndexViewModel(accounts);

            
            return View(vm);
        }

        // GET: Transaction/Create
        [HttpGet("[controller]/[action]")]
        public async Task<IActionResult> Create()
        {
            var vm = new AccountCreateViewModel();
            
            vm.Currencies = await _currencyService.Find();
            vm.Banks = await _bankService.Find();

            return View(vm);
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AccountCreateViewModel newAccount)
        {
            //Test Line
            newAccount.UserId = 1;

            if (!ModelState.IsValid) return View(newAccount);
            
            var newAccountDto = _mapper.Map<AccountDto>(newAccount);
            
            await _accountService.Add(newAccountDto);
            return RedirectToAction(nameof(Index));

            // //var accountList = await _accountService.Find();
            
            // //ViewData["Id"] = new SelectList(accountList, "Id", "Name", newTransaction.Id);
            // //return View(newTransaction);
        }
    }
}
