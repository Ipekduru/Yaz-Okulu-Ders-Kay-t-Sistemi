using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityBasvuruForm
    {
        private int basvuruId;
        private int basdersId;
        private int basogrId;

        public int BASVURUID {
            get { return basvuruId; }
            set { basvuruId = value; } 
        }
        public int BASDERSID {
            get { return basdersId; }
            set { basdersId = value; }
        }
        public int BASOGRID {
            get { return basogrId; }
            set { basogrId = value; } }
    }
}
