using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cArac
    {
        int arac_Id;
        public cArac()
        {

        }

        public int Arac_Id
        {
            get { return arac_Id; }
            set { arac_Id = value; }
        }
        string arac_marka, arac_plaka, arac_kapasite, arac_model;

        public cArac(string gArac_marka, string gArac_plaka, string gArac_kapasite, string gArac_model)
        {
            this.Arac_marka = gArac_marka;
            this.Arac_plaka = gArac_plaka;
            this.Arac_kapasite = gArac_kapasite;
            this.Arac_model = gArac_model;
        }
        public cArac(int gArac_Id, string gArac_marka, string gArac_plaka, string gArac_kapasite, string gArac_model)
        {
            this.Arac_Id = gArac_Id;
            this.Arac_marka = gArac_marka;
            this.Arac_plaka = gArac_plaka;
            this.Arac_kapasite = gArac_kapasite;
            this.Arac_model = gArac_model;
        }


        public string Arac_marka
        {
            get { return arac_marka; }
            set { arac_marka = value; }
        }

        public string Arac_plaka
        {
            get { return arac_plaka; }
            set { arac_plaka = value; }
        }

        public string Arac_kapasite
        {
            get { return arac_kapasite; }
            set { arac_kapasite = value; }
        }

        public string Arac_model
        {
            get { return arac_model; }
            set { arac_model = value; }
        }
        public override string ToString()
        {
            return this.Arac_plaka + "---->" + this.Arac_kapasite;
        }
    }
}
