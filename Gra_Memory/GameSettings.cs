using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Memory
{
    // klasa przechowywująca wszystkie ustawienia gry
    public class GameSettings
    {
        //ustawienia gry
        
        //odliczanie czasu gry 
        public int CzasGry;
        //czas na podgląd kart na początku
        public int CzasPodgladu;
        //maksymalna ilość punktów
        public int MaxPunkty;
        //ilość kart na plnaszy wiersze x kolumny
        public int Wiersze;
        public int Kolumny;
        //wielkość pojedyńczej karty w px
        public int Bok;
        //aktualna ilość punktów
        public int AktualnePunkty;

        //ustawiamy na sztywno ścieżki do grafik
        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";

        //konstruktor
        public GameSettings()
        {
            UstawStartowe();
        }

        public void UstawStartowe()
        {
            CzasGry = 60;
            CzasPodgladu = 5;
            MaxPunkty = 0;
            Wiersze = 4;
            Kolumny = 6;
            Bok = 150;
            AktualnePunkty = 0;
        }
    }
}
