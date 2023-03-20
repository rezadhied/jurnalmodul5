// See https://aka.ms/new-console-template for more information


Penjumlahan p = new Penjumlahan();
p.JumlahTigaAngka<int>(13, 02, 21);



class Penjumlahan
{
    public void JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic hasil = 0;
        hasil += a;
        hasil += b;
        hasil += c;
        Console.WriteLine("Hasil Penjumlahan: "+hasil);
    }
}
