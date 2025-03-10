//Console.Write("Arabanızın yaşını giriniz: ");
//int age = Convert.ToInt16(Console.ReadLine());

//if(age>=0 && age <= 10)
//{
//    Console.WriteLine("Arabanız yeni");
//}

//else if(age>10 && age<= 20)
//{
//    Console.WriteLine("Servise götürmeniz gerekebilir");
//}
//else if(age>20 && age <= 30)
//{
//    Console.WriteLine("Arabanız hurdaya çıkabilir");
//}
//else
//{
//    Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");


//}


//SWİTCH CASE BLOĞU İLE YAPIMI :


Console.WriteLine("Arabanın yaşını giriniz:");
int age = Convert.ToInt32(Console.ReadLine());


switch (age)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    case 6:
    case 7:
    case 8:
    case 9:
    case 10:
        Console.WriteLine("Arabanız yeni");
        break;
    case 11:
    case 12:
    case 13:
    case 14:
    case 15:
    case 16:
    case 17:
    case 18:
    case 19:
    case 20:
        Console.WriteLine("Servise götürmemniz gerekebilir");
        break;
    case 21:
    case 22:
    case 23:
    case 24:
    case 25:
    case 26:
    case 27:
    case 28:
    case 29:
    case 30:

        Console.WriteLine("Aracınız hurdaya çıkabilir");
        break;

    default:
        Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir");
        break;





}