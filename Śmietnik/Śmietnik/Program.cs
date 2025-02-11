using System;

namespace Śmietnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trash trash = new Trash(2, 3, 10);
            trash.condition();
            trash.paperIn(2);
            trash.PlasticIn(2);
            trash.glassIn(2);
            trash.condition();
            trash.paperOut();
            trash.condition();
        }
    }
    class Trash
    {
        private int plastic;
        private int glass;
        private int paper;

        public Trash() { }
        public Trash(int plastic, int glass, int paper)
        {
            this.plastic = plastic;
            this.glass = glass;
            this.paper = paper;
        }
        public void glassOut() { glass = 0; }

        public void glassIn(int trash) { glass += trash; }

        public void plasticOut() { plastic = 0; }
        public void PlasticIn(int trash) { plastic += trash; }
        public void paperOut() { plastic = 0; }
        public void paperIn(int trash) { paper += trash; }
        public void condition()
        {
            Console.WriteLine("ilość śmieci w szkle: " + glass);
            Console.WriteLine("ilość śmieci w plastiku: " + plastic);
            Console.WriteLine("ilość śmieci w papierze: " + paper);
            Console.WriteLine();
        }
    }
}
