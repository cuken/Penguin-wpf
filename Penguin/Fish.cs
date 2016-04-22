using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace Penguin
{
    public class Fish
    {
        public static void Start()
        {
            var engine = new TesseractEngine(@".\tessdata", "eng", EngineMode.Default);
        }
    }
}
