using MVCSimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSimpleApp.Controllers
{
    public class UserController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //var lista = from u in GetUsersList()
            //            orderby u.Name
            //            select u;
            //return View(lista);

            var lista = listaUsuarios;
            return View(lista);
        }

        //GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        //POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                User newUser = new User();
                newUser.Name = collection["Name"];
                newUser.Email = collection["Email"];
                listaUsuarios.Add(newUser);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {

                return RedirectToAction("Index");
            }
            
        }

        //GET: Test/Edit
        public ActionResult Edit(int id)
        {
            var usuarioAserEditado = listaUsuarios.Single( l => l.Id == id);

            return View(usuarioAserEditado);
        }

        //POST: Test/Edit/Id
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var idUsuario = listaUsuarios.Single(l => l.Id == id);
            if (idUsuario.Id == id)
            {
                idUsuario.Name = collection["name"];
                idUsuario.Email = collection["email"];
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public static List<User> listaUsuarios = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "Joao",
                Email = "joao@gmail"
            },
            new User
            {
                Id = 2,
                Name = "Jose",
                Email = "jose@gmail"
            },
            new User
            {
                Id = 3,
                Name = "Ana",
                Email = "ana@gmail.com"
            }
        };

        //[NonAction]
        //public List<User> GetUsersList()
        //{
        //    List<User> listaUsuarios = new List<User>
        //    {
        //        new User
        //        {
        //            Id = 1,
        //            Name = "Joao",
        //            Email = "joao@gmail"
        //        },
        //        new User
        //        {
        //            Id = 2,
        //            Name = "Jose",
        //            Email = "jose@gmail"
        //        },
        //        new User
        //        {
        //            Id = 3,
        //            Name = "Ana",
        //            Email = "ana@gmail.com"
        //        }                
        //    };
        //        return listaUsuarios;
        //}

    }
}