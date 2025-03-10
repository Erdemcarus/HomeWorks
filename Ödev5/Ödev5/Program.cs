using Ödev5;

List<Araba> arabalar = new List<Araba>
{
   new Araba("Audi",80),
   new Araba("Mercedes",73),
   new Araba("Bmw",77)
};
foreach(var araba in arabalar)
{

    Console.WriteLine(araba.BilgileriGoster());
}

int toplamYakit = 0;

foreach(var araba in arabalar)
{

    toplamYakit += araba.Yakit;

}

Console.WriteLine("Toplam yakıt tüketimi "+toplamYakit+" litredir.");