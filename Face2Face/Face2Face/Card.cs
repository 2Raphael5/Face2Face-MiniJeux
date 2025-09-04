using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Face2Face
{
    public class Card
    {
        public int value {get;set;}
        public bool isFigure { get; set; }
        public Image image { get; set; }
        public Card(int value, bool isFigure, Image image)
        {
            this.value = value;
            this.isFigure = isFigure;
            this.isFigure = isFigure;
            this.image = image;
        }
    }
}
