using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packman.ConsoleGraphic.ConsoleGraphic
{
    public class ConsoleRenderer
    {
        private List<ConsolePixel> canvas;

        public ConsoleRenderer()
        {
            Console.OutputEncoding = Encoding.UTF8;

            canvas = new List<ConsolePixel>();
        }

        public void AddToCanvas(IConsoleRenderable elementToAdd)
        {
            this.canvas.AddRange(elementToAdd.GetConsolePixels());
        }

        public void AddToCanvas(List<IConsoleRenderable> elementsToAdd)
        {
            foreach (IConsoleRenderable element in elementsToAdd)
            {
                AddToCanvas(element);
            }
        }

        public void RenderAll()
        {
            foreach (ConsolePixel pixel in canvas) {
                Console.SetCursorPosition(pixel.X, pixel.Y);
                Console.ForegroundColor = pixel.Color;
                Console.Write(pixel.Symbol);
            }
        }

        public void ClearCanvas()
        {
            canvas = new List<ConsolePixel>();
            Console.Clear();
        }
    }
}
