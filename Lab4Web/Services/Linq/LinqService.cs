namespace Lab4Web.Services.Linq
{
    public class Car
    {
        public Car(string brand, string model, string fuel, float weight, string road_type)
        {
            Brand = brand;
            Model = model;
            Fuel = fuel;
            Weight = weight;
            Road_type = road_type;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }
        public float Weight { get; set; }
        
        public string Road_type { get;}
    }
    public static class CarsDatabase
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car("Skoda","Octavia","diesel",1500, "city"), //1
            new Car("Mercedes","GLC","diesel", 2500, "terrain"),//2
            new Car("Opel","Insignia","gas", 1800,"city"),//3
            new Car("Renault","Talisman","diesel",1700, "city"),//4
            new Car("BMW","X5","diesel", 2500, "terrain"),//5
            new Car("Opel","Astra","gas", 1400,"city"),//6
            new Car("Skoda","Superb","diesel",1500, "city"),//7
            new Car("Mercedes","Sprinter","diesel", 3000, "city"),//8
            new Car("Opel","Agila","gas", 1100,"city"),//9
            new Car("Alfa Romeo","Giulietta","gas", 1400,"city"),//10
        };
    }
    public class LinqService : ILinqService
    {
       

       public string Test1(int a) //nr de elemente din lista primita
       {
            var querry = CarsDatabase.Cars.Where(car => car.Weight <= a);

            return "Sunt "+querry.Count() +" masini cu masa de cel mult "+a+" de kg";
       }

       public List<Car> Test2(string brand) //returneaza o lista de obiecte de tipul car in functie de un anume atribut 
        {
            var query = CarsDatabase.Cars.Where(car => car.Brand == brand);
            return query.ToList();
        }

       public List<string> Test3()
        {
            var query = CarsDatabase.Cars
                                       .Where(car => car.Road_type == "terrain")
                                       .Select(car => car.Brand);
            return query.ToList();
       }
        public List<object> Test4()
        {
            var query = from car in CarsDatabase.Cars
                        group car by car.Fuel into fuelGroup
                        select new
                        {
                            FuelType = fuelGroup.Key,
                            NumberOfCars = fuelGroup.Count()
                        };
            var objects = new List<Object>();
            foreach (var item in query)
            {
                objects.Add(new { FuelType = item.FuelType, NumberOfCars = item.NumberOfCars });
            }
            return objects ;
        }
    }
}
