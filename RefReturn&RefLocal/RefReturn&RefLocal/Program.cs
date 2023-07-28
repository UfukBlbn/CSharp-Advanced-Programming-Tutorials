int b = 5;

X(ref b);

//Eğer böyle bir kullanım olursa --->
ref int c = ref X(ref b);
// c = b = a diyebiliriz.
//c = 2; -> Bu durumda b  = 2 
Console.WriteLine(b);
Console.WriteLine(c);

ref int X(ref int a)
{
    a = 27;
    return ref a;
}

//NEDİR ?
//Not: Eğer ref keyword ile işaretleme yapılmış ise değer tipli değişkenlerde deepcopy olayı gerçekleşmek yerinde
//doğrudan tanımlanan değişkenin referansı yani kendisi parametre olarak gönderilir. Haliyle bellekte tanımlanan değişken ile metod içerisindeki değişken,
//aynı adresi işaret etmektedir. Biz metod içerisinde değişkenin değerini değiştirirsek tanımladığımız değişkenin kendisini de değiştirmiş oluruz.

//ÖNEMLİ NOKTALAR : 
//Değişkenler global olarak tanımlanmalıdır, lokal değişkenler ref return ile döndürülemez. Yada parametre olarak alınıp döndürülebilir.
//Sınıflar ile kullanım olabilir.

//REF LOCALS 
int ax = 10;
ref int bx = ref ax;
//Bu durumda ax ile bx aynı bellek adresini işaretleyeceklerdir.

//Lokal parametre ile kullanım :
ref int Y(ref int z)
{
    return ref z;
}

//Sınıf ile kullanım : 
MyClass m = new();
ref int a = ref m.Z();
class MyClass
{
    public int a = 5;
    public ref int Z()
    {
        return ref a;
    }
}

//NEDEN KULLANILIR ? 
//ref return özelliği ; performans gerektiren durumlarda kodu optimize etmek ve özellikle değişkenlerin lüzumsuz yere olabilecek tekrarını engellemek için kullanılır.


// GENEL ÖZET : 

//ref locals ile bir değişkenin referansı başka bir değişken tarafından işaretlenebilir
//ref return ile bir metodun geri dönüş değerinde değişken referansı döndürülebilmektedir.