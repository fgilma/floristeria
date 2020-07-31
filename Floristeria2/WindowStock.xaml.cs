using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Floristeria2.Models;

namespace Floristeria2
{
    /// <summary>
    /// Lógica de interacción para WindowStock.xaml
    /// </summary>
    public partial class WindowStock : Window
    {
        //Marc
        public WindowStock(Florist F)
        {
            InitializeComponent();
            Flori.Text = F.Nombre;
            listaflores.ItemsSource = F.ListaFlower; 
            listatrees.ItemsSource = F.ListaTree;     //conectamos las listas  .cs con las ListBox del .xaml
            listadeco.ItemsSource = F.ListaDeco;
        }


        
}
}
