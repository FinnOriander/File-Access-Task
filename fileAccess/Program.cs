using System;

namespace fileAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItem = new string[6];
            menuItem[0] = "1. Add New Item";
            menuItem[1] = "2. List All Items";
            menuItem[2] = "3. Show Total Cost";
            menuItem[3] = "4. Clear List";
            menuItem[4] = "5. Save List";
            menuItem[5] = "6. Exit";
            Console.WriteLine("Please select an option:");
            Console.WriteLine("------------------------");
            Console.WriteLine(menuItem[0]);
            Console.WriteLine(menuItem[1]);
            Console.WriteLine(menuItem[2]);
            Console.WriteLine(menuItem[3]);
            Console.WriteLine(menuItem[4]);
            Console.WriteLine(menuItem[5]);

 

        



/*         
           static public void Save(List<Thing> things){
               using (StreamWriter writer = new StreamWriter("./data.csv"))
               {
                   foreach(var t in things){
                       writer.WriteLine(t.name + "," + t.number.ToString() + "," + t.value.ToString());
                   }
               }
           }

           static public List<Thing> load(){
               List<Thing> things = new List<Thing>();
               if (File.Exists("./data.csv")){
                   string[] lines = File.ReadAllLines ("./data.csv");
                   foreach (string line in lines){
                       string[] values = line.Split(',');
                       Thing newThing = new Thing(values[0], int.Parse(values[1]), double.Parse(values[2]));
                       things.Add(newThing);
                   }
               }
               return things; */
           }
        }
    }

