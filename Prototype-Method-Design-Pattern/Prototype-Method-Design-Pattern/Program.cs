using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraphicElement originalLogo = new Logo("OriginalLogo", "Blue");

            // Clone the original logo to create a new customized logo
            IGraphicElement customizedLogo = originalLogo.Clone();

            // Display the original and customized logos
            Console.WriteLine("Original Logo:");
            originalLogo.Display();

            Console.WriteLine("\nCustomized Logo:");
            customizedLogo.Display();
        }
    }
}
