using confess.DAO;
using confess.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace confess.Service
{
    class cService
    {
        public void urunbilgiKaydet(string gSerino, string gUrun_aciklama, string gUrun_adi)
        {
            (new cUrunBilgiDAO()).urunbilgikaydet(new cUrunBilgi(gSerino, gUrun_aciklama, gUrun_adi));
        }

        public ArrayList urunoku()
        {
            return (new cUrunBilgiDAO()).urunOKU();
        }

        public void tedkaydet(string gTed_adi, string gTed_adres, string gTed_tel)
        {
            (new cTedarikDAO()).tedarekKaydet(new cTedarik(gTed_adi, gTed_adres, gTed_tel));
        }

        public ArrayList tedarikOku()
        {
            return (new cTedarikDAO()).tedOku();
        }

        public void musterikaydet(string gSube_no, string gYonetici_adi, string gSube_adi, string gAdres, string gTel)
        {
            (new cMusteriDAO()).musteriyiKaydet(new cMusteri(gSube_no, gYonetici_adi, gSube_adi, gAdres, gTel));
        }

        public ArrayList musteriOku()
        {
            return (new cMusteriDAO()).mustOku();
        }

        public void arackaydet(string gArac_marka, string gArac_plaka, string gArac_kapasite, string gArac_model)
        {
            (new cAracDAO()).aracıKaydet(new cArac(gArac_marka, gArac_plaka, gArac_kapasite, gArac_model));
        }

        public ArrayList aracıoku()
        {
            return (new cAracDAO()).arac();
        }

        public void bolumkaydet(string gSaha_ismi, string gİslevi, string gDepertman_tel)
        {
            (new cBolumDAO()).bolumuKaydet(new cBolum(gSaha_ismi, gİslevi, gDepertman_tel));
        }

        public ArrayList bolumuOku()
        {
            return (new cBolumDAO()).bolOku();
        }

        public void personelKaydet(string gPer_adi, string gPer_tel, string gPer_adres, cBolum gBol)
        {
            (new cPersonelDAO()).perKaydet(new cPersonel(gPer_adi, gPer_tel, gPer_adres, gBol));
        }

        public ArrayList peroku()
        {
            return (new cPersonelDAO()).personelOku();
        }

        public void girenUrun(cUrunBilgi gUrunu,cTedarik gTedarikci,int gUrun_adet,double gBirim_fiyat,DateTime gTarih,double gToplam_fiyat)
        {

            (new cUrunGirdisiDAO()).girUrun(new cUrun_Giridisi(gUrunu, gTedarikci, gUrun_adet, gBirim_fiyat, gTarih, gToplam_fiyat));
        }

        public void cikanUrun(cUrunBilgi gUrunu, int gUrun_adet, double gBirim_fiyat, DateTime gTarih, cMusteri gMust, cArac gAracı, double gToplam_fiyat)
        {
            (new cUrun_CiktisiDAO()).cikanurun(new cUrun_Ciktisi(gUrunu, gUrun_adet, gBirim_fiyat, gTarih, gMust, gAracı, gToplam_fiyat));
        }





        public void stokKaydet(cUrunBilgi gBilgisi, int gAdet, double gBirim_fiyat, DateTime gTarih)
        {
            (new cUrunStokDAO()).stokGit(new cUrunStok(gBilgisi, gAdet, gBirim_fiyat, gTarih));
        }

        public ArrayList  secileniOku(int gSecilenUrunId)
        {
            return (new cUrunStokDAO()).urunStokGetir(gSecilenUrunId);
        }



        public void stokGuncelle(int gId, int gAdet)
        {
            (new cUrunStokDAO()).guncelle(gId, gAdet);
        }

        //internal void cikGuncelle(int gId, int gAdet)
        //{
        //    (new cUrunStokDAO()).stokeksilt(gId, gAdet);
        //}

        public ArrayList secilenTedarikci(int gTedarikciId)
        {
            return (new cTedarikDAO()).tedarikciyeGit(gTedarikciId);
        }

        public ArrayList secilenMusteriOku(int gMusteriId)
        {
            return (new cMusteriDAO()).secilenMusteriyiGetir(gMusteriId);
        }
    }
}
