using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using UssdFramework;
using MPowerMiniUssd.Models;

namespace MPowerMiniUssd.Controllers
{
    public class DefaultController : ApiController
    {
        private readonly Setup _setup = new Setup("MPower Mini", "localhost", Screens.All);

        public async Task<IHttpActionResult> Index(UssdRequest ussdRequest)
        {
            var session = new Session(_setup, ussdRequest);
            return Ok(await session.AutoSetupAsync());
        }
    }
}
