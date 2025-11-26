using API.Models;
using API.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace WebApiCalculadora.Controllers
{
    public class HistorialController : ApiController
    {
        HistorialService service = new HistorialService();

        // api/historial
        [HttpGet]
        public IEnumerable<Historial> GetAll()
        {
            return service.GetAll();
        }

        // api/historial/sumas
        [HttpGet]
        [Route("api/historial/sumas")]
        public IEnumerable<Historial> GetSumas()
        {
            return service.GetByOperacion("+");
        }

        //api/historial/restas
        [HttpGet]
        [Route("api/historial/restas")]
        public IEnumerable<Historial> GetRestas()
        {
            return service.GetByOperacion("-");
        }

        // api/historial/multiplicaciones
        [HttpGet]
        [Route("api/historial/multiplicaciones")]
        public IEnumerable<Historial> GetMultiplicaciones()
        {
            return service.GetByOperacion("*");
        }

        //api/historial/divisiones
        [HttpGet]
        [Route("api/historial/divisiones")]
        public IEnumerable<Historial> GetDivisiones()
        {
            return service.GetByOperacion("/");
        }
    }
}