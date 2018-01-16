using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0200保证播放窗体是单例的
{
    public class Song
    {
        public int SongID { get; set; }

        public string SongName { get; set; }

        public string SongLocation { get; set; }
        public Song() { }
        public Song(int id,string name,string location) 
        {
            this.SongID = id;
            this.SongName = name;
            this.SongLocation = location;
        }
    }
}
