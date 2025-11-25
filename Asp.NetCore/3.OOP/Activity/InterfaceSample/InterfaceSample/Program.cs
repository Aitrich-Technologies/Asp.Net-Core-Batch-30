namespace Inheritance

    internal class Program
    {
        public static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //Cat cat = new Cat();

            //dog.AnimalSound();
            //dog.AnimalPrice();
            //cat.AnimalSound();
            //cat.AnimalPrice();
            Ecar ecar=new Ecar();
            Ebike ebike=new Ebike();

        ecar.VehicleSound();
        ebike.VehicleSound();
        ecar.VehiclePrice();
        ebike.VehiclePrice();
        }
    }
}
