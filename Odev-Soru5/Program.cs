// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sırasıyla bölmek istediğiniz sayıyı ve hangi sayıya bölmek istediğini giriniz.");
Console.WriteLine("İlk sayıyı giriniz");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz");
double number2 = Convert.ToDouble(Console.ReadLine());
double result = number1 / number2;
Console.WriteLine("{0} Sayısının {1} sayısına bölümünün sonucu: {2}", number1,number2,result);

