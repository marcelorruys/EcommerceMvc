using EcommerceMvc.Models;
using EcommerceMvc.Models.ViewModels;
using EcommerceMvc.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EcommerceMvc.Controllers;

public class HomeController : Controller
{
    private readonly IProdutoRepository _produtoRepository;

    public HomeController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel
        {
            ProdutosPreferidos = _produtoRepository.ProdutosPreferidos
        };

        return View(homeViewModel);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}