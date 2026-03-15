using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400124
{
    public class KodePos
    {
        public static string getKodePos(string kelurahan)
        {
            // Menggunakan array paralel untuk teknik table-driven
            string[] daerah = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer" };
            string[] kode = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274" };

            for (int i = 0; i < daerah.Length; i++)
            {
                if (daerah[i] == kelurahan)
                {
                    return kode[i];
                }
            }
            return "Kode pos tidak ditemukan";
        }
    }
}