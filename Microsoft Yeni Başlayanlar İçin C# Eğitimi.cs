// Bölüm:1-2-3-4-5-6-7 String temelleri

// Stringe değer atama ve yazdırma.
Console.WriteLine("Hello, David!");
string firstFriend = "Maria";
string secondFriend = "Scott";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Stringin içinde kaç karakter bulunduğunu yazdırı
string firstFriend = "Maria";
string secondFriend = "Scott";
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters."); 
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters."); 

// Stringdeki boşlukları kesmek
string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");  

greeting = greeting.TrimStart();
Console.WriteLine($"[{greeting}]");

greeting = greeting.TrimEnd();
Console.WriteLine($"[{greeting}]");

greeting = greeting.Trim();
Console.WriteLine($"[{greeting}]"); 

// String içindeki kelimeyi değiştirme
string Hello = "Hello World!";
Console.WriteLine(Hello);
Hello = Hello.Replace("Hello", "Greetings");
Console.WriteLine(Hello); 

// Stringin tüm karakterlerini büyük veya Küçük yapmak
string Hello = "Hello World!";
Console.WriteLine(Hello.ToUpper());
Console.WriteLine(Hello.ToLower()); 


// Bölüm:9 Dört işlem ve integer veri türü
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c); // Toplama

c = a - b;
Console.WriteLine(c); // Çıkarma

c = a * b;
Console.WriteLine(c); // Çarpma

c = a / b;
Console.WriteLine(c); // Bölme

// Metod oluşturma
void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);
  
    c = a - b;
    Console.WriteLine(c);

    c = a * b;
    Console.WriteLine(c);

    c = a / b;
    Console.WriteLine(c);
} 

// İşlem önceliği ayarlama
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);

d = (a + b) * c;
Console.WriteLine(d);

// integerin maksimum ve minimum değeri görebilmek için
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"Integerin maksimum ve minimum değerleri {max} {min}'dir");


// Bölüm:10 Double veri türü 
double e = 19;
double f = 23;
double g = 8;
double h = (e + f) / g;
Console.WriteLine(h);

// Double ın alabileceği maksimum ve minimum değeri görmek için
double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");


// Bölüm:11 Döngüler 

int counter = 0;
while (counter < 5) {
    counter++;
    Console.WriteLine(counter)
}

// do while döngüsü
int counter = 0;
do {
    counter++;
    Console.WriteLine(counter)
} int counter = 0;
while (counter < 5);

// for döngüsü
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 5; i++)
{
        if (i == 3)
    {
        Console.WriteLine(3);
    }
}


// Bölüm:12 Veri Listesi<T> ve Koleksiyonlar
var names = new List<string> {"Scott", "Ana", "Felipe"};

foreach (var name in names) {
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


// Bölüm:13 Diziler, Listeler, Dizin Oluşturma ve Foreach 
var names = new string[] {"Scott", "Ana", "Felipe"};
        names = names.Concat(new string[] {"Damian"}).ToArray(); // diziye kodla eleman ekleme
        
        foreach (var name in names) {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }


// Bölüm:14 Listeleri Sıralama ve Arama
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


// Bölüm:15 Dil Tümleşik Sorgusu (LINQ) ve IEnumerable
using System;
using System.Collections.Generic;
using System.Linq;

List<int> scores = new List<int> { 97, 92, 81, 60 };
IEnumerable<int> scoreQuery = 
    from score in scores
    where score > 80
    select score;

foreach (int i in scoreQuery) {
Console.WriteLine(i + " ");                              
} 


// Bölüm:16 LINQ Sorgu İfadeleri From, Where, Orderby ve Select
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


// Bölüm:17 LINQ Yöntemi Sözdizimi ve Sorgu Karşılaştırması
using System;
using System.Collections.Generic;
using System.Linq;

List<int> scores = new List<int> { 3, 45, 100, 97, 92, 81, 60 };
var scoreQuery = scores.Where(s => s > 80). OrderByDescending(s => s);

List<int> myscores = scoreQuery.ToList();

foreach (int score in scores) {
    Console.WriteLine(score);
}















