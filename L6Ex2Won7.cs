
Car FirstCar = new Car("Honda", "BV 43 ERG", 1998) ;
Car SecondCar = new Car("Ford", "CT 341 DSA", 1598);

Console.WriteLine(FirstCar.Display());
Console.WriteLine(SecondCar.Display());

class Car
{
    string model;
    string registrationNumber;
    int engine;

    public Car(string model, string registrationNumber, int engine)
    {
        this.model = model;
        this.registrationNumber = registrationNumber;
        this.engine = engine;
    }

    public string Display()
    {
        return ($"John just got a new car. The car is a {model} and has the cilindrical capacity of {engine}. He also got a new licence plate, called {registrationNumber}. ");
    }
}