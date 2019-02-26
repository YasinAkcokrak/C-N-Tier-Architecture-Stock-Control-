using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cTedarik
    {
        int tedarikId;

        public cTedarik()
        {

        }

        public int TedarikId
        {
            get { return tedarikId; }
            set { tedarikId = value; }
        }
        string ted_adi, ted_adres, ted_tel;

        public cTedarik(string gTed_adi, string gTed_adres, string gTed_tel)
        {
            this.Ted_adi = gTed_adi;
            this.Ted_adres = gTed_adres;
            this.Ted_tel = gTed_tel;
        }
        public cTedarik(int gTedarikId, string gTed_adi, string gTed_adres, string gTed_tel)
        {
            this.TedarikId = gTedarikId;
            this.Ted_adi = gTed_adi;
            this.Ted_adres = gTed_adres;
            this.Ted_tel = gTed_tel;
        }

        public string Ted_adi
        {
            get { return ted_adi; }
            set { ted_adi = value; }
        }

        public string Ted_adres
        {
            get { return ted_adres; }
            set { ted_adres = value; }
        }

        public string Ted_tel
        {
            get { return ted_tel; }
            set { ted_tel = value; }
        }
        public override string ToString()
        {
            return this.Ted_adi;
        }
    }
}
