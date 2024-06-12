// assign function to variable isEven
Func<int, bool> isEven = x => x % 2 == 0;
var list = Enumerable.Range(1, 10);
// pass isEven as an argument to Where
var even = list.Where(isEven).ToList();
foreach (var item in even)
{
    Console.WriteLine(item);
}
