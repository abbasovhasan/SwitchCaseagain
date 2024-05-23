using System.Security;
using System.Threading.Channels;

namespace Covert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            string mesaj;
            mesaj = result ? "Veri kaydetme islemi basarilidir" : "Veri kaydetme islemi basarisizdir";

            Console.WriteLine(mesaj);
            Console.WriteLine("Veri kaydetme islemi " + (result ? "basarilidir" : "basarisizdir"));

            Console.WriteLine($"Veri Kaydetme Islemi Basari{(result ? "li" : "siz")}dir");

        }
       
    }
}
#region Converter
/* 
 string number = "1";
 byte b = Convert.ToByte(number);
 sbyte sb = Convert.ToSByte(number);
 short s = Convert.ToInt16(number);
 ushort us = Convert.ToUInt16(number);
 int i = Convert.ToInt32(number);
 uint ui = Convert.ToUInt32(number);
 long l = Convert.ToInt64(number);
 ulong ul = Convert.ToUInt64(number);
 float f = Convert.ToSingle(number);
 decimal d = Convert.ToDecimal(number);
 double db = Convert.ToDouble(number);

 float f1 = 1.5f;
 decimal d1 = 1.5m;
 double db1 = 1.5;
*/
#endregion
#region elseIf
/*Console.Write("Lutfen notunuzu giriniz: ");
string not = Console.ReadLine();
string message = "";

int notValue = Convert.ToInt32(not);
if (notValue < 0)
{
    message = "0'dan kucuk not girisi yapamazsiniz";
}
if (notValue > 100)
{
    message = "100'dan buyuk not girisi olamaz";
}
else
{
    message = "Notunuz " + not;
}
Console.WriteLine(message);*/
#endregion