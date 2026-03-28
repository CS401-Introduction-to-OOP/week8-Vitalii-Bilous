using System;
namespace Week8;
    class Program
    {
        static void Main(string[] args)
        {
            Letter letter1 = new Letter("52", 0.6);
            Letter letter2 = new Letter("67", 0.7);

            Parcel parcel1 = new Parcel("42", 2.9, "30x20x15");
            Parcel parcel2 = new Parcel("69", 5.5, "67x52x69");
            
            DeliveryItem item1 = letter1;
            DeliveryItem item2 = parcel1;
            
            item1.PrintInfo();
            item2.PrintInfo();
            
            CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
            
            myCargo.AddItem(letter1);
            myCargo.AddItem(letter2);
            myCargo.AddItem(parcel1);
            myCargo.AddItem(parcel2);

            Console.WriteLine($"Total cost for delivery: {myCargo.GetTotalCost()} UAH");
        }
    }


