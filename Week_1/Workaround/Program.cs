
using Business.Concreate;
using Entities.Concreate;

SelamVer();
Topla();

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Murat";
ogrenciler[2] = "Mert";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler = new[] { "Ankara", "İstanbul, Rize" };
string[] sehirler2 = new[] { "Amasya", "Samsun", "Zonguldak" };

sehirler2 = sehirler;
sehirler[0] = "Artvin";

Console.WriteLine(sehirler2[0]);

Person person1 = new();
person1.FisrtName = "Murat Eren";

Person person2 = new();
person2.FisrtName = "Nagihan";

PttManager pttManager = new(new PersonManager());
pttManager.GetGive(person1);

// ------ İşlemler -------

static void SelamVer()
{
    Console.WriteLine("Merhaba");
}

static int Topla(int sayi1 = 3, int sayi2 = 5)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine(sonuc);
    return sonuc;
}


