﻿Console.Write("Yaşınızı giriniz: ");
int age = Convert.ToInt32(Console.ReadLine());

if(age>0 && age <= 18)
{
    Console.WriteLine("Küçüksünüz")
        ;
}
else if(age>18 && age<= 35)
{
    Console.WriteLine("Gençsiniz");
}
else if(age>35 && age <= 55)
{
    Console.WriteLine("Yetişkinsiniz");
}

else if(age>55 && age <=75)
{
    Console.WriteLine("Yaşlısınız");
}
else if(age>75 && age <= 99)
{
    Console.WriteLine("Çok yaşlısınız");
}
else
{
    Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz.");
}