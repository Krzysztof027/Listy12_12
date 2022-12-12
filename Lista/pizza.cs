using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lista.MainWindow;
using System.Windows;

namespace Lista
{
    public partial class MainWindow : Window
    {

        public class pizza
        {
            public string Nazwa { get; set; }
            public int Cena { get; set; }
            public string Skladniki { get; set; }
            public bool czyCienka { get; set; }

            public pizza(string nazwa, int cena, string skladniki, bool czyCienka)
            {
                Nazwa = nazwa;
                Cena = cena;
                Skladniki = skladniki;
                this.czyCienka = czyCienka;
            }
        }
    }
}

