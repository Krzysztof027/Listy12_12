using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IEnumerable<string> Slowa { get; set; }
        //Aby móc korzystać z pętli foreach musimy na naszej kolekcji zaimplementować interfejs IEnumerable. 
        public ObservableCollection<pizza> WszystkiePizze { get; set; } //samo będzie się aktualizować
        //Reprezentuje dynamiczną kolekcję danych, która dostarcza powiadomienia po dodaniu lub usunięciu elementów albo odświeżeniu całej listy.
        public MainWindow()
        {
            InitializeComponent();

            Slowa = new List<string>();
            //split-rodziel
            Slowa = "Ala ma kota,a kot ma Ale, Ala ma kota,a kot ma Ale, Ala ma kota,a kot ma Ale".Split(' ').ToList();//Wrzucenie do listy
            DataContext = this;//Inne Bindowanie
            przygotujDane();
        }
        private void przygotujDane()
        {
            //Wpiew żeby wywołać w metodzie w tym przypadku "pizze" musimy stworzyć odpowiedni konstruktor w klasie
            WszystkiePizze = new ObservableCollection<pizza>();
            WszystkiePizze.Add(new pizza("Hawajska", 25, "szynka, ser mozarella, ananas z puszki czy sos pomidorowy", true));//true- bo mamy typ bool (prawda czy fałsz), albo true czy false
            WszystkiePizze.Add(new pizza("Morska", 30, " 40 gr ciasta, 2 puszki pomidorów bez skórki, 2 łyżki oregano, 2 ząbki czosnku, oliwa z oliwek", false));
            WszystkiePizze.Add(new pizza("Carbonara", 28, "Mąka przenna, woda, parmezan, jogurt grecki", true));
            WszystkiePizze.Add(new pizza("Mięsna Uczta", 31, "Mięso, pieczarki, ser, oliwki", true));
        }
    }
}
