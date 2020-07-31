using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Floristeria2.Models
{
    public class Florist
    {
        public string Nombre { get; set;}
        public List<Flower> ListaFlower { get; set; }
        public List<Tree> ListaTree { get; set; }
        public List<Deco> ListaDeco { get; set; }

        //Constructor
        public Florist(TextBox nombre)
        {
            this.Nombre = nombre.Text;
            this.ListaFlower=new List<Flower>();
            this.ListaTree= new List<Tree>();
            this.ListaDeco = new List<Deco>();
        }

        public void AddListaFlower(Flower flor)
        {
            this.ListaFlower.Add(flor);
        }
        public void AddListaTree(Tree arbol)
        {
            this.ListaTree.Add(arbol);
        }
        public void AddListaDeco(Deco decoracion)
        {
            this.ListaDeco.Add(decoracion);
        }
    }
}
