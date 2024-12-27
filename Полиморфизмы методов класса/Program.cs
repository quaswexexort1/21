using Полиморфизмы_методов_класса;
using static Полиморфизмы_методов_класса.TelevizorSuper;


        televizor tv1 =FactoryTV.CreateTV("Samsung", 55, 20, "Корея");
        Console.WriteLine(tv1);
        televizor tv2 = FactoryTV.CreateTV("Sony", 65, 25, "Япония");
        Console.WriteLine(tv2);
        televizor tv3 = FactoryTV.CreateTV("LG", 40, 15, "Китай");
        Console.WriteLine(tv3);
        televizor tv4 = FactoryTV.CreateTV("Xiaomi", 50, 30, "Сингапур");
        Console.WriteLine(tv4);
