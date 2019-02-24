using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{

    public class Plateau
    {
        public int X { get; set; }
        public int Y { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Plateau(Int32 x, Int32 y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harita Boyutu: 5X5");
            Console.WriteLine("Mevcut Konum: ");
            Console.WriteLine("0 0 N");
            Rover firstRover = new Rover(0, 0, Rover.Direction.N, new Plateau(5, 5));
            Console.WriteLine("Yönlendirme Yapınız.");
            firstRover.Command(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Yeni Konum: ");
            firstRover.GetPosition();
            Console.ReadLine();
        }
    }
}
