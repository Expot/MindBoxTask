using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqaures.Exceptions
{
    public class FigureNotValidException : Exception
    {
        public FigureNotValidException(string figureName) : base($"Figure {figureName} not valid! Please check input parameters!") { }
    }
}
