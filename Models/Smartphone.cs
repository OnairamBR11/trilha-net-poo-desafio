namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando o smartphone...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo uma ligação...");
        }

        // Método abstrato que deverá ser implementado pelas classes derivadas
        public abstract void InstalarAplicativo(string nome);
    }
}