using System;

class Program
{
    static void Main(string[] args)
    {
        int transaksiUlang = 0;
        int maxBeli = 5;
        int hargaTiket = 50000;
        string ulang = "n";

        do
        {
            Console.WriteLine("=== Tiket Konser Rayyan Bieber ===");
            Console.Write("Masukkan jumlah tiket yang dibeli ( Maksimal 5 Ya Bro ): ");
            int jumlah = int.Parse(Console.ReadLine());

            if (jumlah > maxBeli)
            {
                Console.WriteLine("Jumlah pembelian maksimal 5 tiket aja ya bro , maruk amat");
                continue;
            }

            int total = jumlah * hargaTiket;
            double diskon = 0;

            // Diskon 10% jika beli 5 tiket
            if (jumlah == 5)
            {
                diskon = 0.10;
            }

            // Tambah counter transaksi ulang
            transaksiUlang++;

            // Diskon berdasarkan jumlah transaksi ulang
            if (transaksiUlang == 3)
            {
                diskon = 0.05;
            }
            else if (transaksiUlang > 5)
            {
                Console.WriteLine("Transaksi sudah lebih dari 5 kali bro , banyak amat");
                break;
            }

            double potongan = total * diskon;
            double bayar = total - potongan;

            Console.WriteLine($"Total Harga  : Rp {total}");
            Console.WriteLine($"Diskon       : {diskon * 100}%");
            Console.WriteLine($"Total Bayar  : Rp {bayar}");

            Console.Write("\nApakah ingin transaksi lagi bro ? (Yoi/Kagak): ");
            ulang = Console.ReadLine();

        } while (ulang.ToLower() == "yoi");

        Console.WriteLine("Terima kasih!");
    }
} 