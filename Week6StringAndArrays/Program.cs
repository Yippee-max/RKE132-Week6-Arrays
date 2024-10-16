string hello = " i have become destroyer of worlds? "; 
// ikka taht, komma ja vahemik on sumbol

int stringLength = hello.Length;
// Length on -1 kuna hakkab lugema nullist, naiteks hello on 5 sumbolid aga indeks on neli

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!').Replace('e', 'E');

firstLetter = hello[0];
    
// string andmed on immutable 

Console.WriteLine(firstLetter);
Console.WriteLine(hello);

// Trim eelmdab mittevajavad sumboolid nagu tuhikud
//int wordCounter = 0;
//for (int i = 0; i < hello.Length; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//    {
//        wordCounter++;
//    }
//}
//char.IsWhiteSpace vaatab tuhikuid, ja tagastab true voi falsina
// [ sulud prindivad indeksi vaartuse
//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words.");