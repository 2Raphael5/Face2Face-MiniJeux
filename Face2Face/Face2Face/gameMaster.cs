using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Face2Face
{
    static class gameMaster
    {
        static public List<Form> gameList = new List<Form>();
        static public List<Form> gameListRetired = new List<Form>();

        static public string pseudoJ1 = "";
        static public string pseudoJ2 = "";

        static public int scoreJ1 = 0;
        static public int scoreJ2 = 0;
    }
}
