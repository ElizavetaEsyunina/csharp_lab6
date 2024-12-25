using Laba_6;
using System.Net.Http.Headers;

internal class Program
{
    public static void MakeThemMeow(List<IMeow> meowables)
    {
        foreach (var meowable in meowables)
        {
            meowable.Meow();
        }
    }
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите задание 1 или 2. Для выхода нажмите 0");
            int choise = int.Parse(Console.ReadLine());
            switch (choise)
            {

                case 1:
                    Console.Clear();
                    Console.WriteLine("Задание 1");
                    Console.WriteLine("Проверка класса Cat");
                    Cat cat = new Cat("Барсик");
                    Console.WriteLine("Барсик, голос =)");
                    cat.Meow();
                    cat.Meow(3);

                    Console.WriteLine("\nПроверка класса Tiger");
                    Tiger tiger = new Tiger("Толя");
                    tiger.Meow();
                    tiger.Meow(3);

                    //оборачиваем кота в декоратор
                    CatDecorator decoratedCat = new CatDecorator(cat);
                    int k;
                    do
                    {
                        Console.WriteLine($"\nСколько раз должен мяукнуть {cat.Name}?");
                        k = int.Parse(Console.ReadLine());
                        decoratedCat.Meow(k);
                    } while (k != 0);
                    Console.WriteLine($"{cat.Name} мяукнул {decoratedCat.MeowCount} раз(а)");

                    Console.WriteLine("\nТестирование вызова мяукания для списка котов");
                    Cat cat1 = new Cat("Мурзик");
                    Cat cat2 = new Cat("Плюша");
                    Cat cat3 = new Cat("Фрося");
                    List<IMeow> meowables = new List<IMeow> { cat1, cat2, cat3 };
                    MakeThemMeow(meowables);
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Задание 2");
                    try
                    {
                        Console.WriteLine("Введите значение числителя и знаменателя для дроби");
                        int numerator = int.Parse(Console.ReadLine());
                        int denominator = int.Parse(Console.ReadLine());
                        Fraction fraction = new Fraction(numerator, denominator);
                        Console.WriteLine(fraction);
                        Console.WriteLine("\nТестирование на создание рандомных дробей");
                        Fraction dr1 = new Fraction(5, 6);
                        Fraction dr2 = new Fraction(-2, 6);
                        Fraction dr3 = new Fraction(9, -10);
                        Fraction dr4 = new Fraction(1, 12);
                        Fraction dr5 = new Fraction(2, -6);
                        Console.WriteLine($"{dr1}\n{dr2}\n{dr3}\n{dr4}\n{dr5}");
                        Console.WriteLine("\nТестирование методов");
                        Console.WriteLine("\nСложение двух дробей");
                        Console.WriteLine($"{dr1} + {dr5} = {dr1 + dr5}");
                        Console.WriteLine("\nСложение дроби и числа");
                        Console.WriteLine($"{dr4} + {3} = {dr4 + 3}");
                        Console.WriteLine("\nРазность двух дробей");
                        Console.WriteLine($"{dr1} - {dr2} = {dr1 - dr2}");
                        Console.WriteLine("\nРазность дроби и числа");
                        Console.WriteLine($"{dr1} - {5} = {dr1 - 5}");
                        Console.WriteLine("\nПроизведение дробей");
                        Console.WriteLine($"{dr1} * {dr5} = {dr1 * dr5}");
                        Console.WriteLine("\nПроизведение дроби и числа");
                        Console.WriteLine($"{dr3} * {-20} = {dr3 * -20}");
                        Console.WriteLine("\nЧастное от деления двух дробей");
                        Console.WriteLine($"{dr2} / {dr5} = {dr2 / dr5}");
                        Console.WriteLine("\nЧастное от деления дроби на число");
                        Console.WriteLine($"{dr3} / {10} = {dr3 / 10}");
                        Console.WriteLine($"\nВычисление значения выражения (({dr1} + {dr2}) / {dr3}) - {5}");
                        Console.WriteLine($"{dr1} + {dr2} = {dr1 + dr2}");
                        Console.WriteLine($"{dr1 + dr2} / {dr3} = {(dr1 + dr2) / dr3}");
                        Console.WriteLine($"{(dr1 + dr2) / dr3} - {5} = {((dr1 + dr2) / dr3) - 5}");
                        Console.WriteLine("\nСравнение дробей");
                        Console.WriteLine($"{dr1} == {dr2}? -> {dr1 == dr2}");
                        Console.WriteLine($"{dr2} == {dr5}? -> {dr2 == dr5}");
                        Console.WriteLine("\nКлонирование дроби");
                        Console.WriteLine("Введите числитель и знаменатель дроби");
                        int numerator1 = int.Parse(Console.ReadLine());
                        int denominator1 = int.Parse(Console.ReadLine());
                        Fraction dr = new Fraction(numerator1, denominator1);
                        Console.WriteLine($"Введенная дробь: {dr}");
                        Console.WriteLine($"Копия этой дроби: {dr.Clone()}");
                        Console.WriteLine($"\nУстановим для дроби dr1 = {dr1} новые значения числителя и знаменателя");
                        Console.WriteLine("Введите числитель и знаменатель дроби");
                        int new_numerator = int.Parse(Console.ReadLine());
                        int new_denominator = int.Parse(Console.ReadLine());
                        //оборачиваем дробь dr1 в декоратор
                        FractionDecorator decorated_dr1 = new FractionDecorator(dr1);
                        decorated_dr1.SetValue(new_numerator, new_denominator);
                        Console.WriteLine($"Теперь дробь dr1 = {dr1}");
                        Console.WriteLine("\nПолучение вещественного значения дроби");
                        Console.WriteLine("Введите числитель и знаменатель дроби");
                        int numerator2 = int.Parse(Console.ReadLine());
                        int denominator2 = int.Parse(Console.ReadLine());                        
                        Fraction fraction2 = new Fraction(numerator2, denominator2);
                        FractionDecorator _double = new FractionDecorator(fraction2);
                        Console.WriteLine( _double.GetDoubleValue());
                        Console.WriteLine(_double.GetDoubleValue());
                        Console.WriteLine($"Установка для дроби {fraction2} новых значений числителя = -9 и знаменателя = 23");
                        _double.SetValue(-9, 23);
                        Console.WriteLine($"Новое вещественное значение дроби {fraction2} = {_double.GetDoubleValue()}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Работа программы завершена");
                    return;
                default:
                    Console.WriteLine("\nНекорректный выбор. Попробуйте еще раз");
                    break;
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}