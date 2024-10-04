Bölüm:17 LINQ Yöntemi Sözdizimi ve Sorgu Karşılaştırması
using System;
using System.Collections.Generic;
using System.Linq;

List<int> scores = new List<int> { 3, 45, 100, 97, 92, 81, 60 };
var scoreQuery = scores.Where(s => s > 80). OrderByDescending(s => s);

List<int> myscores = scoreQuery.ToList();

foreach (int score in scores) {
    Console.WriteLine(score);
}
