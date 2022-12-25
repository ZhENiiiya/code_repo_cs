//Вид 1
//void Method1()
//{
//    Console.WriteLine("Е.Е.Е.");
//}
//Method1();

//Вид 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("текс");

// void Method2_1(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method2_1(msg:"abc", count:5);
// Method2_1(count:12, msg:"nwq2132j");

//Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int b = Method3();
// Console.WriteLine(b);

// Вид 4

// string Method4(string text, int count)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(count: 10, text: "z");
// Console.WriteLine(res);

// string Method4(string text, int count)
// {

//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(count: 10, text: "z");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j<=10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

//string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//            + "ежели бы вас послали вместо нашего милого Винценгероде,"
//            + "вы бы взяли приступом согласие прусского короля. "
//            + "Вы так красноречивы. вы дадите мне чаю?";

// string s = "qwerty";
//             012
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int  length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     } 
//     return result;
// }

// string newText = Replace(text, ' ', '-');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);


int[] arr = {1,5,7,3,2,7,6,5,9,8,4};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPositon = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPositon]) minPositon = j;
        }

        int temp = array[i];
        array[i] = array[minPositon];
        array[minPositon] = temp;
        
    }
}

PrintArray(arr);

SelectionSort(arr);
PrintArray(arr);