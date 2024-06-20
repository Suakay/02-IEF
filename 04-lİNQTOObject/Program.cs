using _04_lİNQTOObject;
using System.Text;

string[] dersler = { "Matematik", "Türkçe", "Fen Bilgisi", "Beden Eğitimi" };

StringBuilder stringBuilder = new StringBuilder();
foreach(var item  in dersler)
{
    stringBuilder.Append(item + "/t");
}
Console.WriteLine(stringBuilder.ToString());

//Personel Listesi Ouşturma
List<Personel> personelListesi = new List<Personel>();
{
    new Personel() { Id = 1, Adi = "Ahmet", Soyadi = "Mehmet" };
    new Personel() { Id = 2, Adi = "Ayşe", Soyadi = "Fatma" };
    new Personel() { Id = 3, Adi = "Hayriye", Soyadi = "Öztürk" };


};

personelListesi.Add(new Personel() { Id = 5, Adi = "Ezgi", Soyadi = "Yılmaz" });

Personel personel=new Personel();
personel.Id = 1;
personel.Adi = "Buse";
personel.Soyadi = "Akay";
personelListesi.Add(personel);


var personeller=from p in personelListesi select p;
foreach(var kisi in personeller)
{
    Console.WriteLine("Personel Kodu:{0}/nPersonel Adı:{1}/nPersonelSoyadı:{2}", personel.Id, personel.Soyadi);

}
