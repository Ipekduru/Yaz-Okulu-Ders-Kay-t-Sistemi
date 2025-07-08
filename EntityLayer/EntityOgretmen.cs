using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrtId;
        private string ogrtAdSoyad;
        private int ogrtBrans;

        public string OGRTADSOYAD
        {
            get { return ogrtAdSoyad; }
            set { ogrtAdSoyad = value; }
        }

        public int OgrtId
        {
            get { return ogrtId; }
            set{ ogrtId = value; }
        }
    }
}
