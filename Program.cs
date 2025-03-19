using System;
internal class program;

public class PemrosesData
{
    public PemrosesData()
    {
    }

    public void DapatkanNilaiTerbesar<T>(T bil1, T bil2, T bil3)
    {
        //int TEMP1 = Convert.ToInt32(bil1); 
        //int TEMP2 = Convert.ToInt32(bil2);
        //int TEMP3 = Convert.ToInt32(bil3);

        dynamic T1 = bil1;
        dynamic T2 = bil2;
        dynamic T3 = bil3;

        // menambahkan class PemrosesData dengan method DapatkanNilaiTerbesar
        bool status = false;
        while (status == false)
        {
            if (T1 > T2 && T1 > T3)
            {
                Console.Write("Bilangan Maksimum (Terbesar) adalah: " + bil1);
                status = true;
            } else if (T2 > T1 && T2 > T3)
            {
                Console.Write("Bilangan Maksimum (Terbesar) adalah: " + bil2);
                status = true;
            } else if (T3 > T1 && T3 > T2)
            {
                Console.Write("Bilangan Maksimum (Terbesar) adalah: " + bil3);
                status = true;
            } else
            {
                Console.WriteLine("Bilagan Maksimum (Terbesar) tidak ditemukan!");
            }
        }
    }

    public static void Main(String[] args)
    {
        PemrosesData max = new PemrosesData();
        max.DapatkanNilaiTerbesar(10, 30, 22);
    }
}
