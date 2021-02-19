using System;
using System.Diagnostics;
using simple_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using simple_mvc.Methods;
using System.Collections.Generic;

namespace simple_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(long ID)
        {
            var buscarCliente = new BuscarDadosCliente();

            return View(buscarCliente.Buscar(ID));
        }

        public IActionResult EditarDados(long ID, string Nome, string Cpf, DateTime DataNascimento, string Sexo, 
                                            string Cep, string Endereco, string Numero, string Complemento, 
                                                string Bairro, string Estado, string Cidade)
        {
            return View("Index");
        }

        public IActionResult ListarClientes()
        {
            var lista = new ListarDadosCliente();

            return View(lista.Listar());
        }

        public IActionResult RemoverDados(long ID)
        {
            var dbRemover = new RemoverDadosCliente();
            ViewBag.MessageLista = dbRemover.Remover(ID);

            return View("Index");
        }

        public IActionResult InserirDados(string Nome, string Cpf, DateTime DataNascimento, string Sexo, 
                                string Cep, string Endereco, string Numero, string Complemento, 
                                    string Bairro, string Estado, string Cidade)
        {
            var dbInserir = new InserirDadosCliente();

            ViewBag.Message = dbInserir.Inserir(Nome, Cpf, DataNascimento, Sexo, 
                                                Cep, Endereco, Numero, Complemento, 
                                                    Bairro, Estado, Cidade);

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
