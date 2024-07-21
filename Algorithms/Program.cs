for (int i= 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!Kendime inanıyorum, ben bu yazılım işini hallederim!"); // 
} // 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırıyor.(For Örnekleri - 1)

Console.WriteLine("<--------------------------------------------------------------->");
for(int i= 0; i<=20; i++)
{
    Console.WriteLine(i);
} //2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırıyor (For Örnekleri - 2)

Console.WriteLine("<--------------------------------------------------------------->");

for (int i= 1;  i<=20; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırıyyoruz  (For Örnekleri - 3)
Console.WriteLine("<--------------------------------------------------------------->");


int sum = 0;
for (int i=50; i<=150; i++)
{
    sum +=i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + sum); //4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırır.(For Örnekleri - 4)

Console.WriteLine("<--------------------------------------------------------------->");

int ciftSayi = 0;
int tekSayi = 0;

for (int i = 1; i<=120; i++)
{
    if(i % 2 == 0)
    {
        ciftSayi += i;
    }
    else
    {
        tekSayi += i;
    }

}

Console.WriteLine("1 ile 120 ararasındaki çift sayıların toplamı:" + ciftSayi);

Console.WriteLine("1 ile 120 ararasındaki tek sayıların toplamı:" + tekSayi);

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırr. (For Örnekleri - 5)





