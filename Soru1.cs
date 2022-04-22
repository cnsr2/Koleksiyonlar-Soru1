using System;
using System.Collections;
using System.Collections.Generic;
    class program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            ArrayList asal = new ArrayList();
            ArrayList normal = new ArrayList();
            int j =0;
            try
            {
                while (true)
            {
                if(j==20)
                {
                    break;
                }
                Console.WriteLine("Lütfen {0}. Pozitif Tam Sayı Giriniz",j+1);
                int temp = Convert.ToInt32(Console.ReadLine());
                if(temp >=0)
                {
                    sayilar[j] = temp;
                    j ++;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz Sayı Negatiftir, Lütfen Pozitif Tam Sayı Giriniz.");
                }
                
            }
            }
            catch (System.Exception)
            {
                Console.WriteLine("İşlem Başarısız, Lütfen Pozitif Tam Sayı Giriniz.");
            }
            for (int i = 0; i < sayilar.Length; i++)
            { int kontrol =0;
                if(sayilar[i]==1)
                {
                    normal.Add(sayilar[i]);
                }
                else if (sayilar[i]==2)
                {
                    asal.Add(sayilar[i]);
                }
                else
                {
                    for (int k = 2; k < sayilar[i]; k++)
                    {
                        for (int l = 2; l < sayilar[i]; l++)
                        {
                            if(sayilar[i]%l==0)
                            {
                            kontrol ++;
                            }
                        }
                        if(kontrol != 0)
                        {
                        normal.Add(sayilar[i]);
                        break;
                        }
                        else
                        {
                        asal.Add(sayilar[i]);
                        break;
                        }
                    }
                }
            }
            normal.Sort();
            asal.Sort();
            normal.Reverse();
            asal.Reverse();
            Console.WriteLine("Asal Olmayan Sayılarınız :");
            int sayac1 = 0;
            for (int i = 0; i < normal.Count; i++)
            {
                Console.WriteLine(normal[i]);
                sayac1 += Convert.ToInt32(normal[i]);
            }
            Console.WriteLine("Asal Sayılarınız :");
            int sayac =0;
            for (int i = 0; i < asal.Count; i++)
            {
                Console.WriteLine(asal[i]);
                sayac += Convert.ToInt32(asal[i]);
            }
            Console.WriteLine("Asal Olmayan Elemanlarınızın Sayısı : {0}",normal.Count);
            Console.WriteLine("Asal Olan Elemanlarınızın Sayısı : {0}",asal.Count);
            if(normal.Count!=0)
            {
                Console.WriteLine("Asal Olmayan Sayılarınızın Ortalaması : {0}", sayac1/normal.Count);
            }
            else
            {
                Console.WriteLine("Asal Olmayan Sayılarınızın Ortalaması : 0");
            }
            if(asal.Count!=0)
            {
                Console.WriteLine("Asal Sayılarınızın Ortalaması : {0}", sayac/asal.Count);
            }
            else
            {
                Console.WriteLine("Asal Sayılarınızın Ortalaması : 0");
            }
        }
    }