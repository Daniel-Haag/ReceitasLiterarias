using Microsoft.AspNetCore.Mvc;
using ReceitasLiterarias.Models;
using System.Diagnostics;

namespace ReceitasLiterarias.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ComentariosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult AdicionarComentario(int receitaId, string comentario)
        {
            //if (string.IsNullOrWhiteSpace(comentario))
            //    return BadRequest("O comentário não pode estar vazio.");

            //var receita = _context.Receitas.FirstOrDefault(r => r.Id == receitaId);
            //if (receita == null)
            //    return NotFound("Receita não encontrada.");

            //receita.Comentarios.Add(comentario);
            //_context.SaveChanges(); // Certifique-se de que está usando um contexto persistente
            //return Ok("Comentário adicionado com sucesso.");

            return null;
        }


        public IActionResult Index()
        {
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
}