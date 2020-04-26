using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.DI.Classes
{
    public class CarroService : ICarroService
    {
        private string Motorista;

        public CarroService(string motorista)
        {
            Motorista = motorista;
        }

        public string RealizarEntrega(string tipoEntrega)
        {
            if(tipoEntrega == "media")
                return $"{Motorista} \nRealizando entrega de carga média";
            
            else
                return "Você não tem o tipo de automóvel necessário!";
        }
    }
}
