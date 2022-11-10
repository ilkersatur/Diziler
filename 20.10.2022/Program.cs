/*
int c = 0;
int t = 0;
for (int i = 0; i < 20; i++)
{
    Random random = new Random();
        
    if (random.Next(50) % 2 == 0)
    {   
        Console.WriteLine($"{random.Next(50)} Girilen sayi çift sayidir.");
        c++;
    }
    else
    {
        Console.WriteLine($"{random.Next(50)} Girilen sayi tek sayidir.");
        t++;
    }
}
Console.WriteLine($"\ntoplam çift sayısı={c}\ntoplam tek sayısı={t}\n");
*/

//--------------------
//int deger = new int();
//Console.WriteLine(deger);
//--------------------

//for (int i = 0; i < 3; i++)
//{
//    Console.Write(("#"));
//    for (int j = 0; j < 1; j++)
//    {
//        Console.WriteLine(("###"));
//    }
//}

//Console.WriteLine();

for (int i = 0; i < 10; i++)  
{
    for (int j = i; j < 10; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k <= i; k++)
    {
        Console.Write("▬"); 
        Console.Write(" ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(" ▬");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("▬");
    }
    Console.WriteLine();

}
/*
for (int i = 0; i < 255; i++)
{
    Console.Write((char)i + "");
}
*/