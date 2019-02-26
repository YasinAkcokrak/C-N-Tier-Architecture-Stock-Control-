using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cUrunBilgi
    {
        int urunId;

        public int UrunId
        {
            get { return urunId; }
            set { urunId = value; }
        }
        string serino, urun_aciklama, urun_adi;
        public cUrunBilgi()
        {

        }

        public cUrunBilgi(string gSerino, string gUrun_aciklama, string gUrun_adi)
        {
            this.Serino = gSerino;
            this.Urun_aciklama = gUrun_aciklama;
            this.Urun_adi = gUrun_adi;
        }
        public cUrunBilgi(int gUrunıd, string gSerino, string gUrun_aciklama, string gUrun_adi)
        {
            this.UrunId = gUrunıd;
            this.Serino = gSerino;
            this.Urun_aciklama = gUrun_aciklama;
            this.Urun_adi = gUrun_adi;
        }

        public string Serino
        {
            get { return serino; }
            set { serino = value; }
        }

        public string Urun_aciklama
        {
            get { return urun_aciklama; }
            set { urun_aciklama = value; }
        }

        public string Urun_adi
        {
            get { return urun_adi; }
            set { urun_adi = value; }
        }
        public override string ToString()
        {
            return this.UrunId + "----" + this.Urun_adi;
        }
    }
}
