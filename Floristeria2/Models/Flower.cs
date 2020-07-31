using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Floristeria2.Models
{
    public class Flower
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Precio { get; set; }

        //Constructor
        public Flower (TextBox nombre, TextBox color, TextBox precio)
        {
            this.Nombre = nombre.Text;
            this.Color = color.Text;
            this.Precio = precio.Text;
        }
    }
}
