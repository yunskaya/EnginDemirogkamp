static void Add()
{
    Console.WriteLine("added!!!");
}
static void Add2(int number1, int number2=30) //default parameters
{

}
//ref keywords
static int Add3(ref int number1, int number2 = 30) // ref keywordu değeri değişmesini sağlıyor referans tip gibi davranmasını sağlıyor
{
    number1 = 50;
    return number1 + number2;
}

static int Add4(int number1, int number2)
{
    number1 = 50;
    return number1 + number2;
}
// out keyword
static int Add5(out int number1, int number2 = 30) // ref keywordu değeri değişmesini sağlıyor referans tip gibi davranmasını sağlıyor
{
    number1 = 50;
    return number1 + number2;
}

// ref ile out farkı refte ilk değer ataması mutlaka yapılmış olması gerekiyor, outta böyle bir zorunluluk yok
int number1 = 20;
int number2 = 30;
int number3 = 60;
var result2 = Add4(number1, number2);
var result3 = Add5(out number1, number2);
Console.WriteLine(number1);
Console.WriteLine(result2);

var result = Add3(ref number1, number2); //gönderirkende ref ile gönderemek gerekiyor
Console.WriteLine(number1);
Console.WriteLine(result);
Add();

// method overloading
static int Multiply(int number, int number2)
{
    return number * number2;
}

static int Multiply(int number1, int number2, int number3)
{
    return number1 * number2 * number3;
}

//Params Keywordu
// burada çokfazla parametre için
static int MultiplyParams(params int[] numbers)
{

    return numbers.Sum();
}

//getupperbound