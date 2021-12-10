namespace proje1_telefon_rehberi
{
    public static class Choice
    {
        static List<Person> personList = new List<Person>(){
            new Person("Ali", "Bozkurt", "5327514141"),

        };


        public static void NumaraEkle()
        {
            Console.WriteLine("Lütfen isim giriniz             : ");
            string ad = Console.ReadLine();

            Console.WriteLine("Lütfen soyisim giriniz          : ");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Lütfen telefon numarası giriniz : ");
            string numara = Console.ReadLine();
            numara = numara.Replace(" ", "").Replace("+", "");


            Person yenikullanıcı = new Person(ad, soyisim, numara);
            personList.Add(yenikullanıcı);
            personList.OrderBy(x => x.Ad).ThenBy(x => x.Soyad);

            Console.WriteLine("Yeni kullanıcı başarıyla eklendi. ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void NumaraKaldir()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            int itemCount = personList.Count;
            string deleteName = Console.ReadLine();

            for (int i = itemCount - 1; i >= 0; i--)
            {
                if (personList[i].Ad == deleteName || personList[i].Soyad == deleteName)
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", personList[i].Ad, personList[i].Soyad);
                    string permission = Console.ReadLine();

                    if (permission == "y")
                    {
                        personList.Remove(personList[i]);
                        Console.WriteLine("Numara başarıyla silindi.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }    
                    
                    else if (permission == "n")
                    {
                        Console.WriteLine("Silme işlemi iptal edildi.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                    else
                        break;
                }
            }

            if (personList[0].Ad != deleteName && personList[0].Soyad != deleteName)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                int choice;
                while (!Int32.TryParse(Console.ReadLine(), out choice)){}
                switch (choice)
                {
                    case 1:
                        Console.ReadKey();
                        Console.Clear();
                        break;
            
                    case 2:
                        NumaraKaldir();
                        break;
                    
                    default:{
                        Console.WriteLine("Olan seçeneklerin dışında bir veri girdiniz. \n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
        }


        public static void NumaraDegistir()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            int itemCount = personList.Count;
            string updateName = Console.ReadLine();

            for (int i = itemCount - 1; i >= 0; i--)
            {
                if (personList[i].Ad == updateName || personList[i].Soyad == updateName)
                {
                    Console.WriteLine("{0} {1}", personList[i].Ad, personList[i].Soyad);
                    Console.WriteLine("{0}",personList[i].Numara);    
                    personList.Remove(personList[i]);
                    NumaraEkle();
                    Console.WriteLine("Numara başarıyla güncellendi.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }

            if (personList[0].Ad != updateName && personList[0].Soyad != updateName)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");

                int choice;
                while (!Int32.TryParse(Console.ReadLine(), out choice)){}
                switch (choice)
                {
                    case 1:
                        Console.ReadKey();
                        Console.Clear();
                        break;
            
                    case 2:
                        NumaraDegistir();
                        break;
                    
                    default:{
                        Console.WriteLine("Olan seçeneklerin dışında bir veri girdiniz. \n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}