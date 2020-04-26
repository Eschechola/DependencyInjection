using System.Text;
using Microsoft.AspNetCore.Mvc;
using InjecaoDeDependencia.DI.Interfaces;

namespace InjecaoDeDependencia.Controllers
{
    public class DIController : Controller
    {
        private readonly ICarroService _carroService;
        private readonly IMotoService _motoService;
        private readonly ICaminhaoService _caminhaoService;

        public DIController(
            ICarroService carroService,
            IMotoService motoService,
            ICaminhaoService caminhaoService
        )
        {
            _carroService = carroService;
            _motoService = motoService;
            _caminhaoService = caminhaoService;
        }


        [Route("/")]
        public string Entregas()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string carga1 = "leve";
            string carga2 = "media";
            string carga3 = "pesada";


            //carga 1 - Leve
            switch (carga1)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 1 - " + _motoService.RealizarEntrega(carga1));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 1 - " + _carroService.RealizarEntrega(carga1));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 1 - " + _caminhaoService.RealizarEntrega(carga1));
                    break;

                default:
                    stringBuilder.Append("Carga 1 - Tipo de carga nao identificado");
                    break;
            }

            stringBuilder.AppendLine("\n");

            //carga 2 - media
            switch (carga2)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 2 - " + _motoService.RealizarEntrega(carga2));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 2 - " + _carroService.RealizarEntrega(carga2));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 2 - " + _caminhaoService.RealizarEntrega(carga2));
                    break;

                default:
                    stringBuilder.AppendLine("Carga 2 - Tipo de carga nao identificado");
                    break;
            }


            stringBuilder.AppendLine("\n");


            //carga 3 - pesada
            switch (carga3)
            {
                case "leve":
                    stringBuilder.AppendLine("Carga 3 - " + _motoService.RealizarEntrega(carga3));
                    break;

                case "media":
                    stringBuilder.AppendLine("Carga 3 - " + _carroService.RealizarEntrega(carga3));
                    break;

                case "pesada":
                    stringBuilder.AppendLine("Carga 3 - " + _caminhaoService.RealizarEntrega(carga3));
                    break;

                default:
                    stringBuilder.AppendLine("Carga 3 - Tipo de carga nao identificado");
                    break;
            }


            return stringBuilder.ToString();
        }
    }
}