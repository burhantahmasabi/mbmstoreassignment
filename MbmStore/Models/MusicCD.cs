using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        public List<string> Tracks { get; } = new List<string>();
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

       


        //method function
        public void AddTrack(string track)
        {
            //hvis jeg anvender den read only function så skal "tracks.Add(phone);" bruges. 

            Tracks.Add(track);
        }

        //constructors
        public MusicCD() { }
        public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
            {
            Released = released;
            Artist = artist;
        }
    }
    }

