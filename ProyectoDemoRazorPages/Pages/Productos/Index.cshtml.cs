using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoDemoRazorPages.Model;

namespace ProyectoDemoRazorPages.Pages.Productos
{
    public class IndexModel : PageModel
    {

        //Creacion de instancias muy parecido a JAVA

        public IList<Producto> Productos { get; set; }

        public IndexModel()
        {
            Productos = new List<Producto>();
        }
    
        public void OnGet()
        {
          
            Productos.Add(new Producto() { 
                Id=1,
                Nombre="Prueba1",
                Marca="Prueba1",Precio=45});
            Productos.Add(new Producto()
            {
                Id = 2,
                Nombre = "Prueba2",
                Marca = "Prueba2",
                Precio = 45
            });
        }
    }
}
