using System;
using System.Collections.Generic;
var names = new List<string>{ "Scott", "Ana", "Felipe" };
names.Sort();
foreach (var name in names){
    Console.WriteLine($"Hello {name.ToUpper()}");
}

using System;
using System.Collections.Generic;
var numbers = new List<int> {12, 34, 76, 89, 43, 21, 67, 99};
{
    Console.WriteLine($"I found number 43 at index {numbers.IndexOf(43)}");
    numbers.Sort();
    Console.WriteLine($"I found number 43 at index {numbers.IndexOf(43)}");
}
