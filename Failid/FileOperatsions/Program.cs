namespace FileOperatsions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

             Programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse kas kasutaja on sisestanud
             keelatud sõnu, keelatud sõnad ise asuvad loendis, kui kasutaja on sisestanud keelatud sõnu, küsitakse kogu rida kasutajalt uuesti.
             Kui küsimine on lõppenud, küsitakse kasutajalt failinime, ja luuletus salvestatakse faili
             Pärast salvestust kuvatakse failisisu kasutajale tagasi

              */


            Console.WriteLine("Sisesta oma luuletus, salvesta see faili ning kuva oma luuletus tagasi");
            int riduOlemas = 0;
            string olemaolevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Sisesta "+(riduOlemas+1)+" rida");
                List<string> keelatudSõnad = new List<string>() { "aint writing dis", "nono word", "riigikogu", "bad word", "dang" };

                string reasisestus = "";
                while (reasisestus == "") //reasisetsuse kontroll ja esmane sisestus
                {
                    reasisestus = ReadAnswer(); //loeb vastuse
                        foreach (var sõna in keelatudSõnad) //kontrollib keelatud sõnade vasteid
                    {
                        if (reasisestus.Contains(sõna)) //kui vastav sõna on leitud reast
                        {
                            reasisestus = ""; ///tühistame sisestuse
                            Console.WriteLine("On leitud keelatud sõna, sisestus tühistatud, proovi uuesti"); //ütleme kasutajale
                        }
                    }
                }
                olemaolevSisu += (reasisestus+"\n"); //lisame sisestuse
                riduOlemas++;
            }
            string filePath = "C:\\Users\\opilane\\source\\repos\\iktpv\\exercises\\Failid\\FileOperatsions\\";
            SaveLuuletus(olemaolevSisu, filePath); 
        }
        public static void SaveLuuletus(string content, string location)
        {
            Console.WriteLine("Kirjuta failinimi kuhu soovid oma luuletuse salvestada:");
            string failinimi = ReadAnswer();    
            string combinedPath = location+failinimi+".txt";
            File.WriteAllText(combinedPath, content);
            Console.WriteLine("salvestasid faili sellise sisu:");
            DisplayLuuletus(combinedPath);
        }
        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readFile = new StreamReader(location))
            {
                while (readFile.EndOfStream == false)
                {
                    Console.WriteLine(readFile.ReadLine());
                }
                readFile.Close();
            }
        }
        public static string ReadAnswer()
        {
            string answer = "";
            while (answer == "")
            {
                Console.WriteLine("Tee sisestus");
                answer = Console.ReadLine();
            }
            return answer;
            
        }
    }
}
