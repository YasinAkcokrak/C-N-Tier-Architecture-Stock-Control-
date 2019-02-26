using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cPersonel
    {
        int personel_id;

        public int Personel_id
        {
            get { return personel_id; }
            set { personel_id = value; }
        }

       

        cBolum bolumu;
        string per_adi, per_tel, per_adres;

        public cPersonel(string gPer_adi, string gPer_tel,string gPer_adres, cBolum gBol)
        {
            this.Per_adi = gPer_adi;
            this.Per_tel = gPer_tel;
            this.Per_adres = gPer_adres;
            this.bolumu = gBol;
        }
        public cPersonel(int gPersonel_id,string gPer_adi, string gPer_tel, string gPer_adres, cBolum gBol)
        {
            this.Personel_id = gPersonel_id;
            this.Per_adi = gPer_adi;
            this.Per_tel = gPer_tel;
            this.Per_adres = gPer_adres;
            this.bolumu = gBol;
        }


        public cPersonel()
        {
            cBolum b = new cBolum();
            this.bolumu = b;
        }

        public cBolum Bolumu
        {
            get { return bolumu; }
            set { bolumu = value; }
        }
       

        public string Per_adi
        {
            get { return per_adi; }
            set { per_adi = value; }
        }

        public string Per_tel
        {
            get { return per_tel; }
            set { per_tel = value; }
        }

        public string Per_adres
        {
            get { return per_adres; }
            set { per_adres = value; }
        }
        public override string ToString()
        {
            return this.Per_adi + "----" + this.Bolumu.Saha_ismi;
        }
    }
}
