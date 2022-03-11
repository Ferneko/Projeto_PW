using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_PW.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_PW.Controllers
{
    public class UsuariosController : Controller
    {
        //Classe Construtor
        public UsuariosController()
        {

        }

        // GET: UsuariosController
        public ActionResult Index()
        {
            List<Usuario> lista = new List<Usuario>();
            return View();
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        public ActionResult Create(Usuario dadosTela)
        {
       
       
                return RedirectToAction("index");
          
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            //Buscar no banco o Usuario para editar
            return View();
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Usuario dadosTela)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

      
      
        public ActionResult Delete(int id)
        {
                return RedirectToAction(nameof(Index));
        }
    }
}
