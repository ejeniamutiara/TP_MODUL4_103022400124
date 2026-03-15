using System;
using TP_MODUL4_103022400124;

class Program
{
    static void Main(string[] args)
    {
        // --- Implementasi Bagian C (Table-Driven) ---
        Console.WriteLine("--- Tes Kode Pos ---");
        Console.WriteLine("Kode Pos Kelurahan Batununggal: " + KodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Kelurahan Jatisari: " + KodePos.getKodePos("Jatisari"));
        Console.WriteLine();

        // --- Implementasi Bagian E (State-Based) ---
        Console.WriteLine("--- Tes Door Machine ---");
        DoorMachine pintu = new DoorMachine();

        // Simulasi perubahan state
        pintu.BukaPintu();   // Output: Pintu tidak terkunci
        pintu.KunciPintu();  // Output: Pintu terkunci
        pintu.BukaPintu();   // Output: Pintu tidak terkunci
        pintu.BukaPintu();   // (Tetap di state terbuka) Output: Pintu tidak terkunci
    }
}