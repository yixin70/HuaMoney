using HuaMoney.Dto.Transaction;
using HuaMoney.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HuaMoney.ViewModel.Transaction;
using AutoMapper;
using HuaMoney.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HuaMoney.Controllers
{
    public class TransactionController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITransactionService _transactionService;
        private readonly IAccountService _accountService;
        private readonly ICurrencyService _currencyService;

        public TransactionController(ITransactionService transactionService, 
                                        IAccountService accountService,
                                        ICurrencyService currencyService,
                                        IMapper mapper)
        {
            _transactionService = transactionService;
            _accountService = accountService;
            _currencyService = currencyService;
            _mapper = mapper;
        }

        [HttpGet("[controller]/[action]")]
        [HttpGet("[controller]")]
        public async Task<IActionResult> Index()
        {
            var transactions = await _transactionService.Find();
            var transactionViewModel = new TransactionIndexViewModel(transactions);

            return View(transactionViewModel);
        }

        // GET: Transaction/Details/5
        [HttpGet("[controller]/[action]/{id}")]
        public async Task<IActionResult> Details(long id)
        {

            var transactionDto = await _transactionService.FindOne(id);

            if (transactionDto == null) return NotFound();

            return View(transactionDto);
        }

        // GET: Transaction/Create
        [HttpGet("[controller]/[action]")]
        public async Task<IActionResult> Create()
        {
            var vm = new TransactionCreateViewModel();
            vm.Accounts = await _accountService.Find();
            vm.Currencies = await _currencyService.Find();

            return View(vm);
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountAmountAfter,AccountId,Amount,Concept,Currency,Date,Recipient")] TransactionCreateViewModel newTransaction)
        {

            if (!ModelState.IsValid) return View(newTransaction);
            
            var newTransactionDto = _mapper.Map<TransactionDto>(newTransaction);
            
            var added_transaction = await _transactionService.Add(newTransactionDto);
            return RedirectToAction(nameof(Index));

            var accountList = await _accountService.Find();
            
            ViewData["AccountId"] = new SelectList(accountList, "Id", "Name", newTransaction.AccountId);
            return View(newTransaction);
        }

        //
        // // GET: Transaction/Edit/5
        // public async Task<IActionResult> Edit(long? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     var transaction = await _context.Transactions.FindAsync(id);
        //     if (transaction == null)
        //     {
        //         return NotFound();
        //     }
        //     ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id", transaction.AccountId);
        //     return View(transaction);
        // }
        //
        // // POST: Transaction/Edit/5
        // // To protect from overposting attacks, enable the specific properties you want to bind to.
        // // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(long id, [Bind("Id,AccountAmountAfter,AccountId,Amount,Concept,Currency,Date,Recipient")] Transaction transaction)
        // {
        //     if (id != transaction.Id)
        //     {
        //         return NotFound();
        //     }
        //
        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(transaction);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!TransactionExists(transaction.Id))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id", transaction.AccountId);
        //     return View(transaction);
        // }

        // GET: Transaction/Delete/5
        [HttpGet("[controller]/[action]/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var transaction = await _transactionService.FindOne(id);
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
            var numberOfItemsDeleted = await _transactionService.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
