// String temelleri
Console.WriteLine("Hello, David!");

string firstFriend = "Maria";
string secondFriend = "Scott";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}"); // Stringe değer atama ve yazdırma.

string firstFriend = "Maria";
string secondFriend = "Scott";
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters."); 
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters."); // Stringin içinde kaç karakter bulunduğunu yazdırır.

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");  

greeting = greeting.TrimStart();
Console.WriteLine($"[{greeting}]");

greeting = greeting.TrimEnd();
Console.WriteLine($"[{greeting}]");

greeting = greeting.Trim();
Console.WriteLine($"[{greeting}]"); // Stringdeki boşlukları kesmek

string Hello = "Hello World!";
Console.WriteLine(Hello);
Hello = Hello.Replace("Hello", "Greetings");
Console.WriteLine(Hello); // String içindeki kelimeyi değiştirme











