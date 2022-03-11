using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_PW.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_PW.Controllers
{
    public class UsuariosController : Controller
    {
        //Objeto do contexto do banco
        private readonly Contexto banco;

        //Classe Construtor
        public UsuariosController(Contexto _db)
        {
            banco = _db;
        }

        // GET: UsuariosController
        public ActionResult Index()
        {
            return View(banco.USUARIOS.ToList());
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

                banco.USUARIOS.Add(dadosTela);
                banco.SaveChanges();    
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
