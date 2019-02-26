using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cUrun_Ciktisi:cUrun_Base  // kalıtım
    {
        public cUrun_Ciktisi(cUrunBilgi gUrunu,int gUrun_adet,double gBirim_fiyat,DateTime gTarih, cMusteri gMust, cArac gAraci,double gToplam_fiyat)
        {
            this.Urunu = gUrunu;
            this.Urun_adet = gUrun_adet;
            this.Birim_fiyat = gBirim_fiyat;
            this.Tarih = gTarih;
            this.Musteriyi = gMust;
            this.Araci = gAraci;
            this.Toplam_fiyat = gToplam_fiyat;
            
        }
        cUrunBilgi urunu;
        cMusteri musteriyi;


        cArac araci;

        public cArac Araci
        {
            get { return araci; }
            set { araci = value; }
        }
        double toplam_fiyat;

        public double Toplam_fiyat
        {
            get { return toplam_fiyat; }
            set { toplam_fiyat = value; }
        }


        public cUrunBilgi Urunu
        {
            get { return urunu; }
            set { urunu = value; }
        }
        
        public cMusteri Musteriyi
        {
             get { return musteriyi; }
             set { musteriyi = value; }
        }
        
        
         
       
    }
}
