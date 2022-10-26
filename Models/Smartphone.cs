namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _modelo;
        private string _imei;
        private int _memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ListarInformacoes()
        {
            Console.WriteLine($"Modelo: {_modelo}");
            Console.WriteLine($"Memoria: {_memoria}GB");
            Console.WriteLine($"IMEI: {_imei}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}