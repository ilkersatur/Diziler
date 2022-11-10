int[] sayı = new int[5];
for (int i = 0; i < sayı.Length; i++)
{
    sayı[i] = Convert.ToInt16(Console.ReadLine());

}
for (int i = 0; i < sayı.Length; i++)
{
    Console.Write(" " + sayı[i]);

}
/* foreach
koleksiyonlar üzerinde çalışır
sadece okunabilirdir ----- iterasyon değişkeni sadece okunabilirdir
*/
Console.WriteLine();
foreach (int x in sayı) // bu döngüde eleman sayısı bilinmek zorunda değildir ---- indis yok
                        //type iterasyon in koleksiyon
{
    Console.WriteLine(x);
    // sadece okunabilir
}

int[,] matris = new int[3,3]; 
int[,] matris2 = { {1,1,1},{1,1,1 },{1,1,1 } };
Console.WriteLine(matris.Rank);  // çıktı 2
int[,,] matris3 = new int[5,5,5]; //3 boyutlu

// 2 boyutlu dizinin tüm elemanlarını görmek için 2 indis kullanılır
for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 3; j++)
	{
		Console.WriteLine(matris2[i,j]+" ");
	}
}
//dizilerin dizisi
//jagged array düzensiz dizi
int[][] jagged=new int[3][];
jagged[0] = new int[5];
jagged[1] = new int[50];

int[] sayilar = { 4, 5, 6, 7 }; // 4 x 32 bit ---- 32 bit = 4 byte