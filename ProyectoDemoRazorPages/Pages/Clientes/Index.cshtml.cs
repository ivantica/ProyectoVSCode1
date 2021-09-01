using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoDemoRazorPages.Model;

namespace ProyectoDemoRazorPages.Pages.Clientes
{
    public class IndexModel : PageModel
    {

        public IList<Cliente> Clientes { get; set; }

        public IndexModel()
        {
            Clientes = new List<Cliente>();

        }

        public void OnGet()
        {
            Clientes.Add(new Cliente() { 
              Id = 1,
              Nombre="Ivan",
              Apellido="Robles",
              Correo="ivanprogramando@gmail.com"
            });
            Clientes.Add(new Cliente()
            {
                Id = 2,
                Nombre = "Ivan2",
                Apellido = "Robles2",
                Correo = "ivanprogramando2@gmail.com"
            });
        }
    }
}
