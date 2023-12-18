using DesafioPOO.Models;
class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia();
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Iphone iphone = new Iphone();
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}
// TODO: Realizar os testes com as classes Nokia e Iphone