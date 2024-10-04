// String temelleri

Console.WriteLine("Hello, David!");
string firstFriend = "Maria";
string secondFriend = "Scott";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}"); // Stringe değer atama ve yazdırma.

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

// Dört işlem 
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














