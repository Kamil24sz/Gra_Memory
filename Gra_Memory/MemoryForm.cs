using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Memory
{
    public partial class MemoryForm : Form
    {
        //deklarujemy obiekt ustawień gry
        private GameSettings _settings;

        public MemoryForm()
        {
            InitializeComponent();
            //tworzymy obiekt z ustawieniami gry
            _settings = new GameSettings();

            UstawKontrolki();
            GenerujKarty();
        }

        //tutaj zaczynamy pisać kod

        // metoda ustawiająca ustawienia startowe formularza
        // wykorzystamy ją podczas pierwszego uruchomienia
        // oraz przy restartowaniu gry
        // odpowiada za ustalenie wymiarów formularza i zawartości kontrolek
        private void UstawKontrolki()
        {
            // obliczymy, ile miejsca potrzeba na wszystkie karty na podstawie właściwości

            panelKart.Width = _settings.Bok * _settings.Kolumny;
            panelKart.Height = _settings.Bok * _settings.Wiersze;

            //robimy to samo dla szerkości i wysokości okna formularza
            Width = panelKart.Width + 40;
            Height = panelKart.Height + 100;

            //ustawiamy wartości początkowe labelów
            lblCzasWartosc.Text = _settings.CzasGry.ToString();
            lblPunktyWartosc.Text = _settings.AktualnePunkty.ToString();
            lblStartInfo.Text = $"Początek gry za {_settings.CzasPodgladu}";

            //uwidaczniamy labelkę lblStartInfo na początku gry
            //ponieważ będzie ona chowana po zakońćzeniu odliczania
            lblStartInfo.Visible = true;
        }

        // metoda generująca karty oraz losowo układjąca je po panelu gry
        private void GenerujKarty()
        {
            // pobieramy ścieżki do pliów z obrazkami
            string[] memories = Directory.GetFiles(_settings.FolderObrazki);

            // ustawiamy maksymalną liczę punktów do zdobycia na podstawie 
            // ilości pobranych obrazków
            _settings.MaxPunkty = memories.Length;

            // tworzymy listę na karty do gry
            List<MemoryCard> buttons = new List<MemoryCard> ();

            // dla każdego z obrazka tworzymy po dwie karty
            foreach(string img in memories)
            {
                //tworzymy unikalny indentyfikator
                Guid id = Guid.NewGuid();

                //tworzymy pierwszą kartę
                MemoryCard b1 = new MemoryCard(id, _settings.PlikLogo, img);

                //tworzymy drugą kartę, ma takie samo GuID
                MemoryCard b2 = new MemoryCard(id, _settings.PlikLogo, img);

                //dodajemy utworzone karty do listy
                buttons.Add(b1);
                buttons.Add(b2);
            }

            //karty losowo zostały rozmieszczone na planszy

            //tworzymy generator liczb pseoudlosowych
            //wykrozystamy go do losowego rozmieszczenia kart na panelu
            Random random = new Random();

            //przy restarcie gry upewniamy się że nie ma żadnych kart 
            //z poprzedniej rozgrywki w panelu kart
            panelKart.Controls.Clear();

            //robimy pętle w pętli aby stworzyć siatkę 2D kart 
            for(int x = 0; x < _settings.Kolumny; x++)
            {
                for(int y = 0; y < _settings.Wiersze; y++) 
                {
                    // losujemy indeks karty, która aktualnie będzie kładzona na planszy
                    int index = random.Next(0, buttons.Count);

                    // pobieramy wylosowaną kartę z listy
                    MemoryCard b = buttons[index];

                    //dodajemy zmienną na margines pomiędzy kartami
                    int margines = 2;

                    //ustawiamy lokalizaję karty
                    b.Location = new Point((x * _settings.Bok + margines * x), (y * _settings.Bok + margines * y));

                    //ustawiamy wymiary karty
                    b.Height = _settings.Bok;
                    b.Width = _settings.Bok;

                    //odkrywamy startowo kartę
                    b.Odkryj();

                    //dodajemy przygotowaną kartę do panelu gry
                    panelKart.Controls.Add(b);

                    // na samym końcu usuwamy utworzoną kartę z listy
                    buttons.Remove(b);

                }
            }

        }
    }
}
