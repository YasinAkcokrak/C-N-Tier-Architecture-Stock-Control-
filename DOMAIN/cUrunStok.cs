using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cUrunStok:cUrunBilgi
    {

        public cUrunStok()
        {

        }

        public cUrunStok(cUrunBilgi gBilgisi, int gAdet, double gBirim_fiyat ,DateTime gTarih)
        {
            this.Bilgisi = gBilgisi;
            this.Adet = gAdet;
            this.Birim_fiyat = gBirim_fiyat;
            this.Tarih = gTarih;
        }

        cUrunBilgi bilgisi;
        int adet, sId;

        public int SId
        {
            get { return sId; }
            set { sId = value; }
        }
        double birim_fiyat;
        DateTime tarih;
        public cUrunBilgi Bilgisi
        {
            get { return bilgisi; }
            set { bilgisi = value; }
        }
        

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }
        

        public double Birim_fiyat
        {
            get { return birim_fiyat; }
            set { birim_fiyat = value; }
        }
        

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
    }
}
