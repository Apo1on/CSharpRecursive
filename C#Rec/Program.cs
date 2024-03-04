// author: Евгений Афанасьев
class Program
{

    static void Tests()
    {
    }
    static string Recyrsive(string str)
    {
        Console.WriteLine("Введите число от 0 до 9");
        int n = 0;
        n = Convert.ToInt32(Console.ReadLine());
        if(n >= 0 && n <9)
        {
            str = str + n.ToString(); 
            return Recyrsive(str);
        }
        else
        {
            Console.WriteLine("Ошибка введения числа , заканчиваем функцию");
            return str;
        }
    }

    static void Main()
    {
        string str = "";
        Console.WriteLine(Recyrsive(str));
    }
}