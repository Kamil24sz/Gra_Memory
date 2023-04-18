using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gra_Memory
{
    public class MemoryCard : Label
    {
        //do porównania 2 takich samych kart
        public Guid Id;
        //przód i tył karty
        public Image Obrazek;
        public Image Tyl;

        public MemoryCard(Guid id, string tylPath, string obrazekPath)
        {
            Id = id;
            Tyl = Image.FromFile(tylPath);
            Obrazek = Image.FromFile(obrazekPath);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Odkryj()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }

        public void Zakryj() 
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }

    }
}
