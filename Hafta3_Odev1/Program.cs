
using System;


class Program
{

    static void Main()
    {/*
        Değer türleri(int, double, float, char .vb) belleğin stack bölgesinde tutulur.

        Referans türleri (string, diziler, object, nesneler) belleğin heap bölgesinde tutulur.

        Değer türleri referans türlerine göre daha hızlı çalışır ancak belleğin stack alanı sınırlı olduğu için diziler, 
        nesneler belleğin heap bölgesinde oluşturulur.

        Heap bölgesinde oluşturulan referans türlerine belleğin başlangıç adresi ile erişim sağlanır ve herhangi bir yerde
        yapılan değişiklik verinin değişmesine neden olur.

        Ancak ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out anahtar kelimesi ile kullanımda başlangıç 
        değerinin verilmesine gerek yoktur.

      * */

        int sayimizOut;
        DegistirOut(out sayimizOut);
        Console.WriteLine(sayimizOut);

        int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
        DegistirRef(ref sayimizRef);
        Console.WriteLine(sayimizRef);
    }

    static void DegistirRef(ref int sayiRef)
    {
        sayiRef = 1234;
    }

    static void DegistirOut(out int sayiOut)
    {
        sayiOut = 1234;
    }
}