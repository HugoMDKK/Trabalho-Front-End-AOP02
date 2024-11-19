using Microsoft.AspNetCore.Mvc;
using SeuProjeto.Models;

namespace SeuProjeto.Controllers
{
    public class ContactController : Controller
    {
        // Action para exibir o formulário de contato
        public IActionResult Index()
        {
            return View();
        }

        // Action para processar o formulário (POST)
        [HttpPost]
        public IActionResult Index(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para salvar ou enviar a mensagem (e.g., enviar por email)
                TempData["SuccessMessage"] = "Sua mensagem foi enviada com sucesso!";
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
