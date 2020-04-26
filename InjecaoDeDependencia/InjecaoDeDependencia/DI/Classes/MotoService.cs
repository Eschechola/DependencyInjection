using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.DI.Classes
{
    public class MotoService : IMotoService
    {
        private string Motorista;
        private string Placa;

        public MotoService(string motorista, string placa)
        {
            Motorista = motorista;
            Placa = placa;
        }

        public string RealizarEntrega(string tipoEntrega)
        {
            if(tipoEntrega == "leve")
                return $"{Motorista} \nCom a placa {Placa} \nRealizando entrega de carga leve";
            
            else
                return "Você não tem o tipo de automóvel necessário!";
        }
    }
}
