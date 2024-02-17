using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HuaMoney.Dto.Transaction;
using HuaMoney.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HuaMoney.Models;
using HuaMoney.ViewModel.Bank;
using HuaMoney.ViewModel.Transaction;

namespace HuaMoney.Controllers
{
    public class TransactionController : Controller
    {
        private readonly HuaMoneyContext _context;
        private readonly ITransactionService _transactionService;

        public TransactionController(HuaMoneyContext context, ITransactionService transactionService)
        {
            _context = context;
            _transactionService = transactionService;
        }

        // GET: Transaction
        public async Task<IActionResult> Index()
        {
            var transactions = await _transactionService.Find();
            var transactionViewModel = new TransactionIndexViewModel(transactions);
            
            return View(transactionViewModel);
        }

        // GET: Transaction/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .Include(t => t.Account)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transaction/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id");
            return View();
        }

        // POST: Transaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountAmountAfter,AccountId,Amount,Concept,Currency,Date,Recipient")] TransactionCreateViewModel newTransaction)
        {

            if (ModelState.IsValid)
            {
                var newTransactionDto = new TransactionDto
                {
                    AccountAmountAfter = newTransaction.AccountAmountAfter,
                    AccountId = newTransaction.AccountId,
                    Amount = newTransaction.Amount,
                    Concept = newTransaction.Concept,
                    Currency = newTransaction.Currency,
                    Date = newTransaction.Date,
                    Recipient = newTransaction.Recipient
                };
                var added_transaction = await _transactionService.Add(newTransactionDto);
                Console.WriteLine(added_transaction);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Accounts, "Id", "Id", newTransaction.AccountId);
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
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .Include(t => t.Account)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction != null)
            {
                _context.Transactions.Remove(transaction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(long id)
        {
            return _context.Transactions.Any(e => e.Id == id);
        }
    }
}
