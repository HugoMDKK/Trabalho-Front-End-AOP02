using Microsoft.AspNetCore.Mvc;

public class ContentController : Controller
{
    public IActionResult Preparos() => View();
    public IActionResult Receitas() => View();
    public IActionResult Sobre() => View();

    // Ação para listar os ingredientes na página principal de Preparos
    public ActionResult Index()
    {
        return View(); // Retorna a view principal com a lista de preparos
    }

    // Ação para exibir a receita de Cogumelos Frescos
    public ActionResult PreparosCogumelos()
    {
        return View(); // Retorna a view de detalhes do preparo de cogumelos
    }
    public ActionResult ReceitasCogumelos()
    {
        return View(); // Retorna a view de detalhes do Rececita de cogumelos
    }

    // Ação para exibir a receita de Lombo
    public ActionResult PreparosLombo()
    {
        return View(); // Retorna a view de detalhes do preparo de lombo
    }
    public ActionResult ReceitasLombo()
    {
        return View(); // Retorna a view de detalhes do Receita de lombo
    }

    // Ação para exibir a receita de Sanduíche
    public ActionResult PreparosSanduiche()
    {
        return View(); // Retorna a view de detalhes do preparo de Sanduiche
    }
    public ActionResult ReceitasSanduiche()
    {
        return View(); // Retorna a view de detalhes do Receita de Sanduiche
    }
    public ActionResult SobreCogumelos()
    {
        return View(); // Retorna a view de detalhes do Sobre de cogumelos
    }

    public ActionResult SobreLombo()
    {
        return View(); // Retorna a view de detalhes do Sobre de Lombo
    }
    public ActionResult SobreSanduiche()
    {
        return View(); // Retorna a view de detalhes do Sobre de Sanduiche
    }
}


