using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDersler
    {
        private string dersAd;
        private int min;
        private int maks;
        private int id;
        public string DERSAD
        {
            get { return dersAd; }
            set { dersAd = value; }
        }

        public int MIN
        {
            get { return min; }
            set { min = value; }
        }
        public int MAKS
        {
            get { return maks; }
            set { maks = value; }
        }
        public int ID {
            get { return id; }
            set { id = value; }
        }
    }
}
