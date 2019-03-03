using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Packman.ConsoleGraphic.ConsoleGraphic;

namespace Packman.ConsoleGraphic
{
    public interface IConsoleRenderable
    {
        List<ConsolePixel> GetConsolePixels();
    }
}
