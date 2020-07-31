using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Floristeria2.Models
{
    public class Deco
    {
        public string Nombre { get; set; }
        public string Material { get; set; }
        public string Precio { get; set; }

        //Constructor
        public Deco(TextBox nombre,RadioButton material,TextBox precio)
        {
            this.Nombre = nombre.Text;
            this.Material = (material.IsChecked == true) ? "Madera" : "Plástico";
            this.Precio = precio.Text;
        }
    }
}
