﻿using EcommerceMvc.Models;
using EcommerceMvc.Models.ViewModels;
using EcommerceMvc.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceMvc.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IProdutoRepository produtoRepository, CarrinhoCompra carrinhoCompra)
        {
            _produtoRepository = produtoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraVM);
        }

        [Authorize]
        public IActionResult AdicionarItemNoCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
            if (produtoSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(produtoSelecionado);
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoverItemNoCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
            if (produtoSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(produtoSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
