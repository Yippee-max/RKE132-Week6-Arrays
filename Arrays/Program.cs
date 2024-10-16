//string[] fruit = { "apples", "grapes", "melon",};
// [ ] ei ole enam primitiivne nagu ( ), vaid juba kogum
// arrays saab olla ainult mis on array jaoks definieeritud

using System.Linq.Expressions;

string[] fruit = new string[3];
//saab ainult lisada nii palju vaartusi kui definieeritud
fruit[0] = "apple";
fruit[1] = "melon";
fruit[2] = "pear";
Console.WriteLine($"Fruits: {fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;
Console.WriteLine($"There are {fruitArrayLength} value(s) in your array");

for (int i = 0; i < fruitArrayLength; i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}
//sones vaartust ei saa muuda, aga arrays saab

foreach (string element in fruit) // votab ikka vaartust arrayst
{
    Console.WriteLine(element);
}
// for each ei luba muudatusi teha, ainult vaatada voi salvestada