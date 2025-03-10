using Ödev4;

List<Calisan> calısanlar = new List<Calisan>
{

    new Calisan("Ali","Mehmet","Genel müdür","IT",95000),
    new Calisan("Erdem","Carus","Stajyer","IT",8000),
    new Calisan("Efe","Can","Programcı","IT",39000),
    new Calisan("Fatma","Yüz","Müdür","IT",62000)

};
foreach (var worker in calısanlar)
{
    Console.WriteLine(worker.BilgileriGöster());
}


int toplamMaas = 0;

foreach(var totalSalary in calısanlar)
{
    toplamMaas += totalSalary.Maas;
}
Console.WriteLine("Toplam maaş "+toplamMaas+ " TL'dir");