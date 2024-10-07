using System;
using System.Collections.Generic;
using System.Linq;

List<int> scores = new List<int> { 3, 45, 100, 97, 92, 81, 60 };
IEnumerable<string> scoreQuery = 
    from score in scores
    where score > 80
    orderby score descending
    select $"The score is {score}";

foreach (string s in scoreQuery) {
Console.WriteLine(s);                              
}
