// See https://aka.ms/new-console-template for more information

using Week_1.Abstract;
using Week_1.Classes;
using Week_1.CLasses;

/*Car i = new();
i.brand = "Fiat";
i.color = "White";
i.year = 2019;
i.km = 150.564;
i.turbo = false;
i.git(i.color, i.brand);


Anne an = new Anne();
an.adi = "Ayşe";
an.soyadi = "A";
an.ekranaYaz(an.adi, an.soyadi);
an.oku(an.adi);
an.dinle(an.adi);
an.yaz(an.adi);

Baba ba= new Baba();
ba.adi = "Ahmet";
ba.soyadi = "A";
ba.ekranaYaz(ba.adi, ba.soyadi);
ba.oku(ba.adi);

Cocuk co = new Cocuk();
co.adi = "Ali";
co.soyadi = "A";
co.ekranaYaz(co.adi, co.soyadi);
i.git("Red", "Volvo");



Model1 a = new Model1();
a.brand = "bmw";
a.model = "x5";
a.vites = "manuel";
a.vitesTürü(a.brand, a.vites);

Model2 b = new Model2();
b.brand = " mercedes";
b.model = "xl";
b.vites = "otomatik";
b.vitesTürü(b.brand, b.vites);

Model3 c = new Model3();
c.brand = " porche";
c.model = "carrera";
c.vites = "otomatik";
c.vitesTürü(c.brand, c.vites);

Model4 d = new Model4();
d.brand = " dodge";
d.model = "charger";
d.vites = "otomatik";
d.vitesTürü(d.brand, d.vites);


AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Ayşe";
ak.soyadi = "Yılmaz";
ak.durum = "akıllı";
ak.akillimiuslumu(ak.adi, ak.soyadi, ak.durum);
ak.askereGit(ak.adi);
ak.ehliyetAl(ak.adi);
ak.klubeGit(ak.adi);

UsluCocuk us = new UsluCocuk();
us.adi = "Ali";
us.soyadi = "Yılmaz";
us.durum = "uslu";
us.akillimiuslumu(us.adi, us.soyadi, us.durum);
us.askereGit(us.adi);
us.ehliyetAl(us.adi);


Hiperaktif hp = new Hiperaktif();
hp.adi = "Hüseyin";
hp.ehliyetAl(hp.adi);

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci p = new Programci();
Stajyer st = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += p.maasinizNedir();
toplamMaas += st.maasinizNedir();

Console.WriteLine("Toplam maaş: " + toplamMaas);
*/

Bmw bm = new Bmw();
bm.brand = "BMW";
bm.HizliGit(bm.brand);
bm.DenizdeYuz(bm.brand);
bm.HavadaUc(bm.brand);

Mercedes mc = new Mercedes();
mc.brand = "Mercedes";
mc.DenizdeYuz(mc.brand);
mc.HavadaUc(mc.brand);

Porsche pr = new Porsche();
pr.brand = "Porsche";
pr.HavadaUc(pr.brand);

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci p = new Programci();
Stajyer st = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.MaasinizNedir();
toplamMaas += mu.MaasinizNedir();
toplamMaas += p.MaasinizNedir();
toplamMaas += st.MaasinizNedir();

Console.WriteLine("Toplam maaş: " + toplamMaas);


Bmw2 b2 = new Bmw2();
Mercedes2 m2 = new Mercedes2();
Porsche2 p2 = new Porsche2();

double toplamYakit = 0.0;
toplamYakit += b2.NeKadarYakıyor();
toplamYakit += m2.NeKadarYakıyor();
toplamYakit += p2.NeKadarYakıyor();

Console.WriteLine("Toplam yakıt: " + toplamYakit);

/*Array nedir?
 * Array, aynı veri tipindeki birden fazla değeri tek bir değişken altında saklamaya yarayan veri yapısıdır. 
 * Diziler bellekte ardışık olarak depolanır ve her elemana sıfırdan başlayan birindeks numarası ile erişilir. 
 * Örneğin, int[] sayilar = {10, 20, 30}; şeklinde bir dizi tanımlandığında,sayilar[0] ile 10 değerine, sayilar[1] ile 20 değerine ulaşılabilir.
 * Diziler sabit boyutludur ve tanımlandıktan sonra boyutları değiştirilemez.
 */

