using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cUrun_Base
    {
        int urun_adet;
        DateTime tarih;
        double  birim_fiyat;

         

        public double Birim_fiyat
        {
            get { return birim_fiyat; }
            set { birim_fiyat = value; }
        }

        public int Urun_adet
        {
            get { return urun_adet; }
            set { urun_adet = value; }
        }

        
        


        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        

       
        
    }
}
