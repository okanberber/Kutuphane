using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUTUPHANE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region KÜTÜPHANE

            Kutuphane[] kutuphanes = new Kutuphane[10];
            kutuphanes[0] = new Kutuphane() { yazar = "John Steinbeck", kitap = "Fareler ve İnsanlar", sayfa = "128", tur = "Roman" };
            kutuphanes[1] = new Kutuphane() { yazar = "Herman Hesse", kitap = "Siddhartha", sayfa = "152", tur = "Roman" };
            kutuphanes[2] = new Kutuphane() { yazar = "Antoine de Saint-Exupéry", kitap = "Küçük Prens", sayfa = "112", tur = "Çocuk Edebiyatı" };
            kutuphanes[3] = new Kutuphane() { yazar = "John Steinbeck", kitap = "Gazap Üzümleri", sayfa = "556", tur = "Roman" };
            kutuphanes[4] = new Kutuphane() { yazar = "Paulo Coelho", kitap = "Simyacı", sayfa = "188", tur = "Roman" };
            kutuphanes[5] = new Kutuphane() { yazar = "Jean-Paul Sartre", kitap = "Bulantı", sayfa = "264", tur = "Edebiyat" };
            kutuphanes[6] = new Kutuphane() { yazar = "Fyodor Dostoyevski", kitap = "Suç ve Ceza", sayfa = "432", tur = "Dram" };
            kutuphanes[7] = new Kutuphane() { yazar = "Haruki Murakami", kitap = "Sahilde Kafka", sayfa = "656", tur = "Fantastik" };
            kutuphanes[8] = new Kutuphane() { yazar = "Louis-Ferdinand Céline", kitap = "Gecenin Sonuna Yolculuk", sayfa = "576", tur = "Roman" };
            kutuphanes[9] = new Kutuphane() { yazar = "Lev Tolstoy", kitap = "Anna Karenina", sayfa = "864", tur = "Aşk" };

            #endregion
            #region MENÜ YAZDIRMA
            string secim = "";
            string hangiyazar = "";
            string hangitur = "";
            bool yazarvarmı = false;
            bool turvarmı = false;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kütüphaneye Hoşgeldiniz giriş yapmak için bir tuşa basınız");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("1) Yazar Adı");
                Console.WriteLine("2) Tür");
                Console.WriteLine("3) Tümü");
                Console.WriteLine("***************************************************");
                Console.WriteLine("Lütfen aratmak istediğiniz kriteri seçiniz");
                secim = Console.ReadLine();

                #endregion
            #region PROGRAM



                if (secim == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Hangi Yazarın kitaplarını istiyorsunuz");
                    hangiyazar = Console.ReadLine();
                    Console.Clear();

                    for (int i = 0; i < kutuphanes.Length; i++)
                    {

                        if (hangiyazar == kutuphanes[i].yazar)
                        {
                            Console.WriteLine("Yazar = " + kutuphanes[i].yazar + "\t" + "Tür = " + kutuphanes[i].tur + "\t" + "Kitap Adı = " + kutuphanes[i].kitap + "\t" + "Sayfa = " + kutuphanes[i].sayfa);
                            yazarvarmı = true;
                        }

                    }
                    if (yazarvarmı == false)
                    {
                        Console.WriteLine("Aradığınız isimde yazar yok");
                        Console.ReadKey();
                    }
                }
                else if (secim == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Hangi türde kitapları istiyorsunuz");
                    hangitur = Console.ReadLine();
                    Console.Clear();
                    for (int i = 0; i < kutuphanes.Length; i++)
                    {

                        if (hangitur == kutuphanes[i].tur)
                        {
                            Console.WriteLine("Yazar = " + kutuphanes[i].yazar + "\t" + "Tür = " + kutuphanes[i].tur + "\t" + "Kitap Adı = " + kutuphanes[i].kitap + "\t" + "Sayfa = " + kutuphanes[i].sayfa);
                        }

                    }
                    if (turvarmı == false)
                    {
                        Console.WriteLine("Aradığınız türde kitap yok");
                        Console.ReadKey();
                    }
                }
                else if (secim == "3")
                {
                    for (int i = 0; i < kutuphanes.Length; i++)
                    {
                        Console.WriteLine("Yazar = " + kutuphanes[i].yazar + "\t" + "Tür = " + kutuphanes[i].tur + "\t" + "Kitap Adı = " + kutuphanes[i].kitap + "\t" + "Sayfa = " + kutuphanes[i].sayfa);
                    }
                }
                else
                {
                    Console.WriteLine("Böyle bir kriter yok");
                    Console.ReadKey();
                }
            }

            #endregion
        }
    }
    class Kutuphane
    {
        public string yazar;
        public string kitap;
        public string sayfa;
        public string tur;

    }
}
