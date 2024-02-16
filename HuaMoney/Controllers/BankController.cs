using HuaMoney.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HuaMoney.Interfaces;
using HuaMoney.ViewModel.Bank;

namespace HuaMoney.Controllers;

public class BankController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBankService _bankService;

    public BankController(ILogger<HomeController> logger, IBankService bankService)
    {
        _logger = logger;
        _bankService = bankService;
    }

    public async Task<IActionResult> Index()
    {
        var bankList = await _bankService.Find();
        BankIndexViewModel bankIndexViewModel = new BankIndexViewModel(bankList);
        return View(bankIndexViewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
