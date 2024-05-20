using System;
//class Program
//{
//    public static void Main(string[] args)
//    {
//        IAnimal animalOne = new Bird();
//        IAnimal animalTwo = new Dog();

//        animalOne.Name = "Соловей";
//        animalTwo.Name = "Барбос";

//        animalOne.MakeSound();
//        animalTwo.MakeSound();

//        animalOne.Move();
//        animalTwo.Move();

//    }


//}
//interface IAnimal
//{
//    string Name { get; set; }
//    void MakeSound();
//    void Move();

//}
//class Dog : IAnimal
//{
//    public string Name { get; set; }
//    public void MakeSound()
//    {
//        Console.WriteLine("Собака рычит");
//    } 
//    public void Move ()
//    {
//        Console.WriteLine("Собака идет");
//    }
//}

//class Bird : IAnimal 
//{
//    public string Name { get; set; }
//    public void MakeSound()
//    {
//        Console.WriteLine("Птичка поет");
//    }
//    public void Move()
//    {
//        Console.WriteLine("Птичка летит");
//    }

//}

//// Задание 2

class Program
{
    public static void Main(string[] args)
    {
        IShare circle = new Circle(10);
        IShare rectungle = new Rectangle(4, 5);
        Console.WriteLine($"Площадь круга с радиусом 10: {circle.CalkulateArea()}");
        Console.WriteLine($"Площадь прямоугольника с шириной 4 и высотой 5: {rectungle.CalkulateArea()}");
     }
}


interface IShare
{
    double CalkulateArea();
}
class Circle : IShare
{
    public double Radius {  get; set; } 
    public Circle(double radius)
    {
        Radius = radius;
    }
    public  double  CalkulateArea()
    {
         return Math.PI * Radius * Radius;
    }
}
 class Rectangle : IShare
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public  double CalkulateArea()
    {
        return Width * Height;  
    }
}

