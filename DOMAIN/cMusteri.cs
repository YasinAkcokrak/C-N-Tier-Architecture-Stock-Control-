using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cMusteri
    {
        int musteriId;


        public cMusteri()
        {

        }
        public int MusteriId
        {
            get { return musteriId; }
            set { musteriId = value; }
        }
        string sube_no, yonetici_adi, sube_adi, adres, tel;

        public cMusteri(string gSube_no, string gYonetici_adi, string gSube_adi, string gAdres, string gTel)
        {
            this.Sube_no = gSube_no;
            this.Yonetici_adi = gYonetici_adi;
            this.Sube_adi = gSube_adi;
            this.Adres = gAdres;
            this.Tel = gTel;
        }
        public cMusteri(int gMusteri_ıd,string gSube_no, string gYonetici_adi, string gSube_adi, string gAdres, string gTel)
        {
            this.MusteriId = gMusteri_ıd;
            this.Sube_no = gSube_no;
            this.Yonetici_adi = gYonetici_adi;
            this.Sube_adi = gSube_adi;
            this.Adres = gAdres;
            this.Tel = gTel;
        }

        public string Sube_no
        {
            get { return sube_no; }
            set { sube_no = value; }
        }

        public string Yonetici_adi
        {
            get { return yonetici_adi; }
            set { yonetici_adi = value; }
        }

        public string Sube_adi
        {
            get { return sube_adi; }
            set { sube_adi = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public override string ToString()
        {
            return this.Sube_no + "------" + this.Sube_adi;
        }
    }
}
