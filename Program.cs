
Car c = new Car("bmw.sport.x5","400KM", "BMW","2025");
Console.WriteLine();
Truck t = new Truck("mercedes.trans.Stone.m6", "100KM", "Mercedes", "2026");
Console.ReadLine();
class Vichale
{
    public string? name;
}
class MotorVicale : Vichale
{
    public string? speed;

}
class Car : MotorVicale
{

    public string comp;
    public string model;
    public Car(string n, string s, string c, string m)
    {
        name = n;
        speed = s;
        comp = c;
        model = m;
        Console.WriteLine("company:" + comp + "\n" + "model:" + model + "\n" + "speed:" + speed + "\n" + "name:" + name);

    }


}
class Truck : MotorVicale
{

    public string comp2;
    public string model2;
    public Truck(string n, string s, string c, string m)
    {
        name = n;
        speed = s;
        comp2 = c;
        model2 = m;
        Console.WriteLine("company2:" + comp2 + "\n" + "model2:" + model2 + "\n" + "speed2:" + speed + "\n" + "name2:" + name);

    }
}