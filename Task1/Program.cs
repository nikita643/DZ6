// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

void PositiveNumb(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){result++;}
    }
    Console.Write($"[{string.Join(",", array)}] -> ");
    Console.Write(result);

}

int [] ArrayData(int [] array)
{
    
    int [] result = {};
    for (int i = 0; i + 1 > 0 ; i++)
    {
    
        Console.Write("ВВедите число, или нажмите Enter для завершения: ");
        string str = Console.ReadLine();
        int var = 0;
        double number;
        bool isNumber = double.TryParse(str, out number);
        if (str != "")
        {
            if(isNumber == true)
            {
                Array.Resize(ref array, i+1);
                var = Int32.Parse(str);
                array[i] = var;
            }
            else
            {
                Console.WriteLine("ВЫ ввели не число!!!!!"); 
                i = i-1;
            }
        }
        if(str == ""){break;}
        
        
    }
    return array;

}

int [] array = {};
array = ArrayData(array);
PositiveNumb(array);