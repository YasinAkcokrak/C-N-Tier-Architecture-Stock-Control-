using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.DOMAIN
{
    public class cBolum
    {
        int bolum_id;

        public cBolum()
        {

        }
        string saha_ismi, islevi, depertman_tel;

        public cBolum(string gSaha_ismi, string gİslevi, string gDepertman_tel)
        {
            this.Saha_ismi = gSaha_ismi;
            this.Islevi = gİslevi;
            this.Depertman_tel = gDepertman_tel;
        }
        public cBolum(int gBolum_id,string gSaha_ismi, string gİslevi, string gDepertman_tel)
        {
            this.Bolum_id = gBolum_id;
            this.Saha_ismi = gSaha_ismi;
            this.Islevi = gİslevi;
            this.Depertman_tel = gDepertman_tel;
        }

        public string Saha_ismi
        {
            get { return saha_ismi; }
            set { saha_ismi = value; }
        }
        public int Bolum_id
        {
            get { return bolum_id; }
            set { bolum_id = value; }
        }

        public string Islevi
        {
            get { return islevi; }
            set { islevi = value; }
        }

        public string Depertman_tel
        {
            get { return depertman_tel; }
            set { depertman_tel = value; }
        }
        public override string ToString()
        {
            return this.Saha_ismi;
        }
    }
}
