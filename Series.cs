using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesConsoleApp
{
    class Series : IComparable
    {
        public string genre;
        public int numberEpisode;
        public Series(string genre,int numberEpisode) { this.genre = genre;this.numberEpisode = numberEpisode; }
        public Series() { }
    
    public int  CompareTo(object obj)
    {
        Series series = (Series)obj;
        if (this.numberEpisode < series.numberEpisode) return -1;
        if (this.numberEpisode > series.numberEpisode) return 1;
        return 0;
    }
    }
}
