using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criando uma instância de Nokia
        Nokia nokia = new Nokia("11 99857-9854", "Nokia106", "953847", 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Mimo");

        Console.WriteLine();

        // Criando uma instância de iPhone
        Iphone iphone = new Iphone("11 995578-9853", "iPhoneX", "268745",68);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Duolingo");

        Console.WriteLine();
    }
}