// Sayılar, Tam sayılar ve Matematik
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
