/*
 * dizi[i,j] = i ve j indistir
 * diziler "birden fazla" ve "aynı tip" verir içerir, bu verilere "indis" üzerinden ulaşırız
 * düzenli diziler > int[] dizi ----- int[,] matris --- int[, ,] iki boyutlu
 * düzensiz diziler > jagged array int[][]
 */

//int[] dizi = {1,3,2,4,5,6,5}; //  değer vererek dizi oluşturma
//string[] sehirler = {"ist","ank","izm"};
//int[] array = new int[3]; // indis girerek dizi oluşturma

//// dizi değerlerine oluşma

//Console.WriteLine(sehirler[1]); //Console.WriteLine(sehirler[1]); out of range exception hatası verir
//en son indis n-1 dir çünkü 0 dan başlar 


//for(int i=0;i< sayı.Length;i++)
//    Console.WriteLine(sehirler[i]);

Random rand = new Random();
rand.Next(1, 10);

Console.Write("eleman sayısı  : ");
int indis = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] sayı = new int[indis];

for (int i = 0; i < indis; i++)
{ 
    sayı[i] = rand.Next(1, 10);
    Console.Write(" " + sayı[i]);
}
Console.WriteLine(" ");
Console.WriteLine(sayı.Length);
