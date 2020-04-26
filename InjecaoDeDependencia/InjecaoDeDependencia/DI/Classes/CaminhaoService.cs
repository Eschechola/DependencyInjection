using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.DI.Classes
{
    public class CaminhaoService : ICaminhaoService
    {
        private string Motorista;
        private string TipoCarteira;

        public CaminhaoService(string motorista, string tipoCarteira)
        {
            Motorista = motorista;
            TipoCarteira = tipoCarteira;
        }

        public string RealizarEntrega(string tipoEntrega)
        {
            if (tipoEntrega == "pesada")
                return $"{Motorista} \nCarteira do Tipo: {TipoCarteira} \nRelizando entrega de carga pesada";

            else
                return "Você não tem o tipo de automóvel necessário!";
        }
    }
}
