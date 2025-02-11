using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notatki
{
    internal class Program
    {
        /************************************************
         klasa: notatka
         opis: zawartość notatki
         pola:
        notes_counter-ilość stworzonych notatek
        id-identyfikator notatki
        title-tytuł notatki
        description-treść notatki
         autor: Daria Robak
        ************************************************/
        class notatka
        {
            private static int notes_counter;
           private int id;
            protected string title;
            protected string description;
            
            public notatka(string title, string description)
            {
                notes_counter++;
                id=notes_counter;
                this.title = title;
                this.description = description;

            }
            /************************************************
             metoda: showNote
             opis: pokazuje informacje wpisane w notatce
             zwracana wartość: brak
             autor: Daria Robak
            ************************************************/
            public void showNote()
            {
                Console.WriteLine(title);
                Console.WriteLine(description);
                Console.WriteLine();
            }
            /************************************************
             metoda: checkVariables
             opis: pokazuje informacje zawarte w klasie notatki
             zwracana wartość: brak
             autor: Daria Robak
            ************************************************/
            public void checkVariables()
            {
                Console.WriteLine(notes_counter + ";" + id + ";" + title + ";" + description);
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            notatka pies = new notatka("wyjście z psem", "o 12 godzinie wyjść z psem i iść z nim do weterynarza");
            pies.showNote();
            pies.checkVariables();

            notatka gotowanie = new notatka("obiad", "o 15 30 zrobić zupę na obiad");
            gotowanie.showNote();
            gotowanie.checkVariables();
        }
    }
}
