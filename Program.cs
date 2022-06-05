namespace CollectionsPractice
{
    class Practice
    {
        static void Main(string[] args)
        {
            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = new string[]  {"Tim", "Martin", "Nikki","Sara"}; 
            Console.WriteLine(names[2]);

            // Create an array to hold integer values 0 through 9
            int[] nums =  {0,1,2,3,4,5,6,7,9};

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] trufa = new bool[]  {true, false, true, false, true, false, true, false, true, false};

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("mungbean");
            flavors.Add("poingo");
            flavors.Add("strongeberry");
            flavors.Add("Chonklo");
            flavors.Add("bread");
            Console.WriteLine(flavors[2]);
            Console.WriteLine(flavors.Count); 
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string,string> profile = new Dictionary<string,string>();
            profile.Add("Tim", "mungbean");
            profile.Add("Martin","bread");
            profile.Add("Nikki", "Chonklo");
            profile.Add("Sara", "strongeberry");
            foreach (KeyValuePair<string,string> entry in profile)
            {
                Console.WriteLine(entry.Key + "-" + entry.Value);
            }

        }
    
    }   

}




