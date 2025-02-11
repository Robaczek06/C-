using System;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace zadanie1
{
    internal class Program
    {
     /***********************************************
        nazwa funkcji: read
        opis funkcji: wczytuje wartości z pliku do tablicy
        ...
        zwracany typ i opis: brak
        autor: Daria Robak
        ************************************************/
        private static void read()
        {
            int lineCount = 0;
            StreamReader reader = new StreamReader("Data.txt");
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }

            string[] tempTable = new string[lineCount];
            StreamReader Newreader = new StreamReader("Data.txt");
            for (int i = 0; i < lineCount; i++) tempTable[i] = Newreader.ReadLine();

            
        }
        /***********************************************
   nazwa funkcji: write
   opis funkcji: wypisuje informacje z pliku i tworzy obiekt z odpowiednimi wartościami
   zwracany typ i opis: brak
   autor: Daria Robak
   ************************************************/
        private static void write()
        {
            int lineCount = 0;
            StreamReader reader = new StreamReader("Data.txt");
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }

            string[] tempTable = new string[lineCount];
            StreamReader Newreader = new StreamReader("Data.txt");

                string tempArtist = "";
                string tempAlbum = "";
                string tempSnumber = "";
                string tempYear = "";
                string tempDownload = "";

            for (int i = 0; i < lineCount; i++) tempTable[i] = Newreader.ReadLine();
            int tempCounter = 0;

            for (int i = 0; i < lineCount; i++)
            {
                tempCounter++;
                switch (tempCounter)
                {
                    case 1:
                        tempArtist = tempTable[i];
                        break;
                    case 2:
                        tempAlbum = tempTable[i];
                        break;
                    case 3:
                        tempSnumber = tempTable[i];
                        break;
                    case 4:
                        tempYear = tempTable[i];
                        break;
                    case 5:
                        tempDownload = tempTable[i];
                        break;
                    case 6:
                        tempCounter = 0;
                        break;
                }
                Albums dictonary = new Albums(tempArtist, tempAlbum, tempSnumber, tempYear, tempDownload);
            }
            for (int i = 0; i < lineCount; i++) Console.WriteLine(tempTable[i]);
        }
        static void Main(string[] args)
        {
            read();
            write();
        }
        class Albums
        {
            private string artist;
            private string album;
            private string songsNumber;
            private string year_production;
            private string downloadNumber;

            public Albums(string artist, string album, string songsNumber, string year_production, string downloadNumber)

            {
                this.artist = artist;
                this.album = album;
                this.songsNumber = songsNumber;
                this.year_production = year_production;
                this.downloadNumber = downloadNumber;
            }
        }

    }
}
