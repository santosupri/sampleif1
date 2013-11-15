using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pil;
            string nama = null; 
            string adress = null;
            string koba = null;
            string jml1 = null;
            string jml2 = null;
            int koba1;
            int koba2;
            int koba3;
            int koba01;
            int koba02;
            int koba03;
            string pilihan = null;
            pil = "0";
            do
            {
                System.Console.WriteLine("                          Menu Utama Program Bakso");
                System.Console.WriteLine("                          ========================");
                System.Console.WriteLine("                           1. Input Data Pembeli  ");
                System.Console.WriteLine("                           2. Input Pesanan Bakso ");
                System.Console.WriteLine("                           3. Pembayaran Pesanan  ");
                System.Console.WriteLine("                           4. Keluar              ");
                System.Console.WriteLine("                          ========================");
                System.Console.Write("                           pilihan anda:       ");
                pil = Console.ReadLine();
                System.Console.Clear();
                switch (pil)
                {

                    case "1":
                        System.Console.WriteLine("==========================================");
                        System.Console.WriteLine(" Nama Pembeli : ");
                        nama = Convert.ToString(Console.ReadLine());
                        System.Console.WriteLine(" Alamat lengkap: ");
                        adress = Convert.ToString(Console.ReadLine());
                        System.Console.WriteLine("==========================================");
                        System.Console.ReadLine();
                        System.Console.Clear();
                        break;

                     case "2":
                                    while (pilihan != "n")
                                    {
                                    System.Console.WriteLine("============================================================");
                                    System.Console.WriteLine("| Kode  |  Pesanan         |   1 porsi     |  1/2 porsi    |");
                                    System.Console.WriteLine("============================================================");
                                    System.Console.WriteLine("| BS01  | Mie Bakso        |    10.000     |   7.000       |");
                                    System.Console.WriteLine("| BS02  | Mie Bakso Babat  |    15.000     |   10.000      |");
                                    System.Console.WriteLine("| BS03  | Mie Yamin        |     9.000     |   6.000       |");
                                    System.Console.WriteLine("============================================================");
                                   
                                        System.Console.WriteLine("kode baso :");

                                        koba  = System.Console.ReadLine();
                                        System.Console.WriteLine("jumlah pesanan bakso :");
                                        System.Console.WriteLine("1 porsi sebanyak :  ");
                                        jml1 = System.Console.ReadLine();
                                        System.Console.WriteLine("1/2 porsi sebanyak :  ");
                                        jml2 = System.Console.ReadLine();
                                        System.Console.WriteLine("masukan data lagi? (y/n)");
                                        pilihan = System.Console.ReadLine();
                                        System.Console.Clear();
                                    }
                                    
                                    
                                    break;

                    case "3":
                        System.Console.WriteLine("nama anda         : {0}",nama);
                        System.Console.WriteLine("alamat anda       : {0}",adress);
                        if (koba == "BS01")
                            System.Console.Write("Kode Bakso anda   : {0}", koba);
                        if (koba == "BS02")
                            System.Console.Write("Kode Bakso anda   : {0}", koba);
                        if (koba == "BS03")
                            System.Console.Write("Kode Bakso anda   : {0}", koba);
                        System.Console.WriteLine("");
                        if (koba == "BS01")
                            System.Console.Write("Nama pesanan anda : Mie Bakso");
                        if (koba == "BS02")
                            System.Console.Write("Nama pesanan anda : Mie Bakso Babat");
                        if (koba == "BS03")
                            System.Console.Write("Nama pesanan anda : Mie Yamin");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("Porsi :");
                        System.Console.WriteLine("1 Porsi    : {0} ",jml1);
                        System.Console.WriteLine("1/2 Porsi  : {0} ",jml2);
                        System.Console.WriteLine("");
                        System.Console.WriteLine("Harga bayar: ");
                        if (koba == "BS01")
                        System.Console.Write("harga    : {0}", koba1 = ((10000 * int.Parse(jml1)) + (7000 * int.Parse(jml2))));
                        if (koba == "BS02")
                            System.Console.Write("harga   : {0}", koba2 =((15000 * int.Parse(jml1)) + (10000 * int.Parse(jml2))));;
                        if (koba == "BS03")
                            System.Console.Write("harga   : {0}", koba3 = ((9000 * int.Parse(jml1)) + (6000 * int.Parse(jml2))));
                        System.Console.WriteLine("");
                         
                        koba1 = ((10000 * int.Parse(jml1)) + (7000 * int.Parse(jml2)));
                        if (koba == "BS01" && koba1 >= 50000 && koba1 < 100000)
                            System.Console.WriteLine("Diskon: {0}", koba01 = (int)(koba1 * (0.03)));
                            koba01 = (int)(koba1 * (0.03));
                        if (koba == "BS01" && koba1 >= 50000 && koba1 < 100000)
                            System.Console.WriteLine(" total : {0}", koba1 - koba01);
                        if (koba == "BS01" && koba1 >= 100000)
                            System.Console.WriteLine("Diskon: {0}", koba01 = (int)(koba1 * (0.06)));
                            koba01 = (int)(koba1 * (0.06));
                        if (koba == "BS01" && koba1 >= 100000)
                            System.Console.WriteLine(" total : {0}", koba1 - koba01);
                        
                        koba2 = ((15000 * int.Parse(jml1)) + (10000 * int.Parse(jml2)));
                        if (koba == "BS02" && koba2 >= 50000 && koba2 < 100000)
                            System.Console.WriteLine("Diskon: {0}", koba02 = (int)(koba2 * (0.03)));
                            koba02 = (int)(koba2 * (0.03));
                        if (koba == "BS02" && koba2 >= 50000 && koba2 < 100000)
                            System.Console.WriteLine(" total : {0}", koba2 - koba02);
                        if (koba == "BS02" && koba2 >= 100000)
                            System.Console.WriteLine("Diskon: {0}", koba02 = (int)(koba2 * (0.06)));
                            koba02 = (int)(koba2 * (0.03));
                        if (koba == "BS02" && koba2 >= 100000)
                            System.Console.WriteLine(" total : {0}", koba2 - koba02);
                        
                        koba3 = ((9000 * int.Parse(jml1)) + (6000 * int.Parse(jml2)));
                        if (koba == "BS03" && koba3 >= 50000 && koba3 < 100000)
                            System.Console.WriteLine("Diskon: {0}", koba03 = (int)(koba3 * (0.03)));
                            koba03 = (int)(koba3 * (0.03));
                        if (koba == "BS03" && koba3 >= 50000 && koba3 < 100000)
                            System.Console.WriteLine(" total : {0}", koba3 - koba03);
                        if (koba == "BS03" && koba3 >= 100000)
                            System.Console.WriteLine("Diskon: {0}", koba03 = (int)(koba3 * (0.06)));
                            koba03 = (int)(koba3 * (0.03));
                        if (koba == "BS03" && koba3 >= 100000)
                            System.Console.WriteLine(" total : {0}", koba3 - koba03);
                        

                        System.Console.ReadLine();
                        System.Console.Clear();
                        break;

                    case "4" :
                        System.Console.WriteLine("terimakasih telah menggunakan aplikasi ini");
                        break;
                    default:
                        Console.WriteLine("menu salah, masukan pilihan anda kembali ");
                        System.Console.ReadLine();
                        System.Console.Clear();
                        break;

                }
            } while (pil != "4");
            Console.ReadLine();
        }
    }
}
