using System;
using System.Collections.Generic;
using System.Text;

namespace Sångklassen
{
    public class Sång
    {
        private string artist;
        public string Artist
        {
            get { return artist; }
        }

        private string sångnamn;
        public string Sångnamn
        {
            get { return sångnamn; }
        }

        private int speltid;
        public int Speltid
        {
            get { return speltid; }
            set { speltid = value; }
        }

        public Sång(string mottagenArtist, string mottagenSångnamn, int mottagetnSpeltid)
        {
            artist = mottagenArtist;
            sångnamn = mottagenSångnamn;
            speltid = mottagetnSpeltid;
        }

    }
}
