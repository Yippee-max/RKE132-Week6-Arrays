string[] snacks = { "sushi", "pizza", "chicken wings", "burger", "Chinese food" };
//arrayst suvalise vaartuse votmine, millel on 5 valikuid ja korgem indeks 4

Random rnd = new Random();

int randomSnack = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomSnack]}");