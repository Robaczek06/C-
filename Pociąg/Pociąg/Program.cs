using System;

namespace Pociąg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train1 = new Train(2, 10);
            train1.condition();
            train1.PassIn(20);
            train1.condition();
            train1.PassOut(10);
            train1.condition();
            train1.WagIn(20);
            train1.condition();
        }
    }
    class Train
    {
        private int wagons;
        private int seats;
        private int pepole = 0;

        public Train(int wagons, int seats)
        {
            this.wagons = wagons;
            this.seats = seats;
        }
        public Train() { }

        public void PassIn(int pass)
        {
            if (pass <= wagons * seats && pass>0) pepole += pass;
            else Console.WriteLine("do pociągu nie zmieści sie tyle osób");
        }
        public void PassOut(int pass)
        {
            if (pass <= pepole && pass>0) pepole -= pass;
            else Console.WriteLine("nie ma tylu pasażerów");
        }
        public void WagIn(int wagons) { this.wagons += wagons; }
        public void WagOut(int wagons)
        {
            if (wagons <= this.wagons) this.wagons -= wagons;
            else Console.WriteLine("nie ma tylu wagonów");

        }
        public void condition()
        {
            Console.WriteLine("liczba wagonów:  " + wagons);
            Console.WriteLine("liczba miejsc w jednym wagonie: " + seats);
            Console.WriteLine("luczba miejsc w pociągu:  " + (seats * wagons));
            Console.WriteLine("ilośc pasażerów:  " + pepole);
            Console.WriteLine();
        }
    }
}
