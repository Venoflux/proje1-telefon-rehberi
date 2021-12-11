namespace proje1_telefon_rehberi
{
    public static class Choice
    {
        static List<Person> personList = new List<Person>(){
            new Person("Ali", "Bozkurt", "5327514141"),
            new Person("Dilara", "Başaran", "5457517834"),
            new Person("Rutkay", "Aziz", "5329556136"),
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
            personList.Sort((x, y) => string.Compare(x.Soyad, y.Soyad));
            personList.Sort((x, y) => string.Compare(x.Ad, y.Ad));
            
            Console.WriteLine("Yeni kullanıcı başarıyla eklendi. ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void NumaraKaldir()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            int itemCount = personList.Count;
            string deleteName = Console.ReadLine();
            bool trigger = true;

            for (int i = itemCount - 1; i >= 0; i--)
            {
                if (personList[i].Ad == deleteName || personList[i].Soyad == deleteName)
                {
                    trigger = false;
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

            if (trigger)
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
            bool trigger = true;

            for (int i = itemCount - 1; i >= 0; i--)
            {
                if (personList[i].Ad == updateName || personList[i].Soyad == updateName)
                {
                    trigger = false;
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

            if (trigger)
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

        public static void NumaraListele()
        {
            Console.WriteLine("(A-Z) Listeleme için : (1)");
            Console.WriteLine("(Z-A) Listeleme için : (2)");

            int choice;
            while (!Int32.TryParse(Console.ReadLine(), out choice)){}

            switch (choice)
            {
                case 1:{
                    personList.Sort((x, y) => string.Compare(x.Soyad, y.Soyad));
                    personList.Sort((x, y) => string.Compare(x.Ad, y.Ad));
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    foreach (var person in personList)
                    {
                        Console.WriteLine("İsim             : {0}", person.Ad);
                        Console.WriteLine("Soyisim          : {0}", person.Soyad);
                        Console.WriteLine("Telefon Numarası : {0}", person.Numara);
                        Console.WriteLine("-");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:{
                    personList.Sort((x, y) => string.Compare(x.Soyad, y.Soyad));
                    personList.Sort((x, y) => string.Compare(x.Ad, y.Ad));
                    personList.Reverse();
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");
                    foreach (var person in personList)
                    {
                        Console.WriteLine("İsim             : {0}", person.Ad);
                        Console.WriteLine("Soyisim          : {0}", person.Soyad);
                        Console.WriteLine("Telefon Numarası : {0}", person.Numara);
                        Console.WriteLine("-");
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                
                default:{
                    Console.Clear();
                    Console.WriteLine("Olan seçeneklerin dışında bir veri giridniz. \n");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }

        public static void NumaraArama()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");

            Console.WriteLine("\nİsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int choice;
            while (!Int32.TryParse(Console.ReadLine(), out choice)){}

            switch (choice)
            {
                case 1:{
                    Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    string searchName = Console.ReadLine();

                    personList.Sort((x, y) => string.Compare(x.Soyad, y.Soyad));
                    personList.Sort((x, y) => string.Compare(x.Ad, y.Ad));
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    bool trigger = true;

                    foreach (var person in personList)
                    {
                        if (person.Ad == searchName || person.Soyad == searchName)
                        {
                            trigger = false;
                            Console.WriteLine("İsim             : {0}", person.Ad);
                            Console.WriteLine("Soyisim          : {0}", person.Soyad);
                            Console.WriteLine("Telefon Numarası : {0}", person.Numara);
                            Console.WriteLine("-");
                        }       
                    }

                    if (trigger)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Aramayı sonlandırmak için      : (1)");
                        Console.WriteLine("* Yeniden denemek için           : (2)");

                        int choice2;
                        while (!Int32.TryParse(Console.ReadLine(), out choice2)){}
                        switch (choice2)
                        {
                            case 1:
                                Console.ReadKey();
                                Console.Clear();
                                break;
            
                            case 2:
                                NumaraArama();
                                break;
                    
                            default:{
                                Console.WriteLine("Olan seçeneklerin dışında bir veri girdiniz. \n");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }

                case 2:{
                    Console.WriteLine("Lütfen numarasını aramak istediğiniz kişinin numarasını giriniz:");
                    string searchNumber = Console.ReadLine();

                    personList.Sort((x, y) => string.Compare(x.Soyad, y.Soyad));
                    personList.Sort((x, y) => string.Compare(x.Ad, y.Ad));
                    Console.WriteLine("Arama sonuçlarınız:");
                    Console.WriteLine("**********************************************");

                    bool trigger = true;

                    foreach (var person in personList)
                    {
                        if (person.Numara == searchNumber)
                        {
                            trigger = false;
                            Console.WriteLine("İsim             : {0}", person.Ad);
                            Console.WriteLine("Soyisim          : {0}", person.Soyad);
                            Console.WriteLine("Telefon Numarası : {0}", person.Numara);
                            Console.WriteLine("-");
                        }       
                    }
                    
                    if (trigger)
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Aramayı sonlandırmak için      : (1)");
                        Console.WriteLine("* Yeniden denemek için           : (2)");

                        int choice2;
                        while (!Int32.TryParse(Console.ReadLine(), out choice2)){}
                        switch (choice2)
                        {
                            case 1:
                                Console.ReadKey();
                                Console.Clear();
                                break;
            
                            case 2:
                                NumaraArama();
                                break;
                    
                            default:{
                                Console.WriteLine("Olan seçeneklerin dışında bir veri girdiniz. \n");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                
                default:{
                    Console.Clear();
                    Console.WriteLine("Olan seçeneklerin dışında bir veri giridniz. \n");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
        }
    }
}