using HuaMoney.Dto.Transaction;
using HuaMoney.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HuaMoney.ViewModel.Transaction;
using AutoMapper;
using HuaMoney.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using HuaMoney.Dto.Account;

namespace HuaMoney.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITransactionService _transactionService;
        private readonly IAccountService _accountService;

        public AccountController(ITransactionService transactionService, 
                                        IAccountService accountService,
                                        IMapper mapper)
        {
            _transactionService = transactionService;
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpGet("[controller]/[action]")]
        [HttpGet("[controller]")]
        public async Task<IActionResult> Index()
        {
            var transactions = await _accountService.Find();
            var transactionViewModel = new AccountCreateViewModel();

            return View(transactionViewModel);
        }

        // GET: Transaction/Details/5
        [HttpGet("[controller]/[action]/{id}")]
        public async Task<IActionResult> Details(long id)
        {

            var transactionDto = await _accountService.FindOne(id);

            if (transactionDto == null) return NotFound();

            return View(transactionDto);
        }

        // GET: Transaction/Create
        [HttpGet("[controller]/[action]")]
        public async Task<IActionResult> Create()
        {
            var vm = new AccountCreateViewModel();
            vm.Accounts = await _accountService.Find();

            return View(vm);
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,AccountNumber,Amount,BankId,Currency,Name")] AccountCreateViewModel newTransaction)
        {

            if (!ModelState.IsValid) return View(newTransaction);
            
            var newTransactionDto = _mapper.Map<AccountDto>(newTransaction);
            
            var added_transaction = await _accountService.Add(newTransactionDto);
            return RedirectToAction(nameof(Index));

            // //var accountList = await _accountService.Find();
            
            // //ViewData["Id"] = new SelectList(accountList, "Id", "Name", newTransaction.Id);
            // //return View(newTransaction);
        }



        // GET: Transaction/Delete/5
        [HttpGet("[controller]/[action]/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var transaction = await _accountService.FindOne(id);
            if (transaction == null)
            {
                return NotFound();
            }
            var transactionfromdto = _mapper.Map<Transaction>(transaction);
            return View(transactionfromdto);
        }

        // POST: Transaction/Delete/5
        //[HttpPost, ActionName("Delete")]
        [HttpPost("[controller]/[action]/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var numberOfItemsDeleted = await _accountService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
