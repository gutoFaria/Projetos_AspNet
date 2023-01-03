using System.Net;
using Microsoft.AspNetCore.Mvc;
using QuizServer.Models;

namespace QuizServer.Controllers
{
    public class MateriaController : Controller
    {
        public IActionResult GetMateria()
        {
            IEnumerable<Materia> materias = null!;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5001/api/");
                var response = client.GetAsync("Materia");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsAsync<IList<Materia>>();
                    read.Wait();

                    materias = read.Result;
                }
                else
                {
                    materias = Enumerable.Empty<Materia>();
                    ModelState.AddModelError(string.Empty, "Erro no servidor");
                }
            }

            return View(materias);
        }

        [HttpGet]
        public IActionResult CreateMateria()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMateria(Materia materia)
        {
            if (materia == null)
            {
                return BadRequest();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5001/api/");
                //HTTP POST
                var postTask = client.PostAsJsonAsync<Materia>("Materia", materia);
                postTask.Wait();
                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetMateria");
                }
            }
            ModelState.AddModelError(string.Empty, "Erro no Servidor. Contacte o Administrador.");
            return View(materia);
        }


        public ActionResult EditarMateria(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Materia materia = null!;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5001/api/Materia");

                //HTTP GET
                var response = client.GetAsync("/" + id.ToString());
                response.Wait();
                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var read = result.Content.ReadAsAsync<Materia>();
                    read.Wait();
                    materia = read.Result;
                }
            }
            return View(materia);
        }

        
        [HttpPost]
        public ActionResult EditarMateria(Materia materia)
        {
            if (materia == null)
            {
                return BadRequest();
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5001/api/");
                //HTTP PUT
                var putTask = client.PutAsJsonAsync<Materia>("Materia", materia);
                putTask.Wait();
                var result = putTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("GetMateria");
                }
            }
            return View(materia);
        }

    }
}