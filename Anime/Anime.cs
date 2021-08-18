using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime
{
    public class Anime
    {
        public string name { get; set; }
        public string URL { get; set; }

        public Anime(string name, string URL) {
            this.name = name;
            this.URL = URL;
        }

    }
}
