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

string Method4(string text, int count)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(count: 10, text: "z");
Console.WriteLine(res);