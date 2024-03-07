using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Caio Oliver", "222.555.888-87", "caiooo@gmail.com", "Noah");
        Cliente cliente2 = new Cliente(02, "Tais Madam", "111.555.999-98", "taismada@gmail.com", "Finin");
        Cliente cliente3 = new Cliente(03, "Maria Jose", "222.878.888-10", "mariaj@gmail.com", "Roque");
        Cliente cliente4 = new Cliente(04, "Jose Mario", "025.985.888-87", "josem@gmail.com", "Vina");
        Cliente cliente5 = new Cliente(05, "Messi Neymar", "087.555.755-00", "m10n10@gmail.com", "Pele");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        

        Fornecedor fornecedor1 = new Fornecedor(01, "Vida Pet", "15.147.858/0001-99", "Vpet@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "PPet", "20.787.999/0001-0 0", "ppet0@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Pedigrin", "30.721.002/0001-57", "pedigrin@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Dog & Cat", "24.041.369/0001-10", "dec5@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Petin", "85.050.741/0001-01", "petin@gmail.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
