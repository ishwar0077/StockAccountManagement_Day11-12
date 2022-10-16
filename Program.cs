namespace JsonDemo 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int totalStockValue = 0;
            string filePath = @"C:\Users\ishwa\source\repos\c#208\JasonDemo\JasonDemo\SimpleJsonFile.json";
            LoadJson loadJson = new LoadJson();
            Model data = new Model();  
            data=loadJson.Read(filePath);

            // Console.WriteLine(data.stockMarket[0].numberOfShare * data.stockMarket[0].sharePrice);

            Console.WriteLine("---------------------------------");
            for (int i = 0; i < data.stockMarket.Count; i++)
            {
                Console.WriteLine("Share Name: " + data.stockMarket[i].shareName);
                Console.WriteLine("Number of Sahare: " + data.stockMarket[i].numberOfShare);
                Console.WriteLine("Share Price: " + data.stockMarket[i].sharePrice);
                 int stockValue = data.stockMarket[i].numberOfShare * data.stockMarket[i].sharePrice;
                Console.WriteLine("Total stock value of {0} is : {1}", data.stockMarket[i].shareName, stockValue);
                totalStockValue += stockValue;
                Console.WriteLine("---------------------------------");
            }
            Console.WriteLine("value of total stocks  is: {0}", totalStockValue);
        }
    }
}