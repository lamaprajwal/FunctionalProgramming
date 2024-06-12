var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var even = numbers.Where(x => x % 2 == 0);
// => [2, 4, 6, 8]
Func<int, bool> isOdd = x => x % 2 != 0; // assign lambda expression to Func
var odd = numbers.Where(isOdd);
// => [1, 3, 5, 7, 9]


