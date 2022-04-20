// See https://aka.ms/new-console-template for more information
//case
//int[] sayilar = { 4, 13, 8, 9, 7, 1, 6 };
int[] sayilar = { 16, 23, 7, 11, 3, 14};
Array.Sort(sayilar);
Array.Reverse(sayilar);
for (int i = 0; i < sayilar.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(sayilar[i]);
    }
}
for (int i = sayilar.Length -1; i >=0;i--)
{
    if (i % 2 == 1)
    {
        Console.WriteLine(sayilar[i]);
    }
}




