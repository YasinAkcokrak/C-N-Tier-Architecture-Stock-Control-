using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cUrun_Giridisi:cUrun_Base
    {
        public cUrun_Giridisi(cUrunBilgi gUrunu,cTedarik gTedarikci,int gUrun_adet,double gBirim_fiyat,DateTime gTarih,double gToplam_fiyat)
        {
            this.Urunu = gUrunu;
            this.Tedarikci = gTedarikci;
            this.Urun_adet = gUrun_adet;
            this.Birim_fiyat = gBirim_fiyat;
            this.Toplam_fiyat = gToplam_fiyat;
          //  this.Toplam_fiyat = gBirim_fiyat * gUrun_adet;
        }
        cTedarik tedarikci;
        cUrunBilgi urunu;
        double toplam_fiyat;

        public double Toplam_fiyat
        {
            get { return toplam_fiyat; }
            set { toplam_fiyat = value; }
        }

       
        
        

        public cUrun_Giridisi()   // composition oluşturduk
        {
            cTedarik t = new cTedarik();
            this.Tedarikci = t;
            cUrunBilgi u = new cUrunBilgi();
            this.Urunu = u;
        }

        public cTedarik Tedarikci
        {
            get { return tedarikci; }
            set { tedarikci = value; }
        }
        

        public cUrunBilgi Urunu
        {
            get { return urunu; }
            set { urunu = value; }
        }



        //public void girenurun()
        //{
        //    this.Toplam_fiyat = Urun_adet * Birim_fiyat;
        //}
    }
}
