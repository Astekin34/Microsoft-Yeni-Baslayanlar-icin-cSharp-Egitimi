using System;
using System.Collections.Generic;
using System.Linq;

// Dil Tümleşik Sorgusu (LINQ) ve Ienumerable

List<int> scores = new List<int> { 97, 92, 81, 60 };
IEnumerable<int> scoreQuery = 
    from score in scores
    where score > 80
    select score;

foreach (int i in scoreQuery) {
Console.WriteLine(i + " ");                              
} 
