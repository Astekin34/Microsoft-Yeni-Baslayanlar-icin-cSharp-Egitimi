// Bölüm:1-2-3-4-5-6-7-8 String temelleri

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
