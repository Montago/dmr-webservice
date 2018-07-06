namespace dmr_webservice.Controllers
{
    using dmr_webservice.Code;
    using dmr_webservice.Models;
    using System;
    using System.Threading.Tasks;
    using System.Web.Http;
    using WebApi.OutputCache.V2;

    [System.Web.Http.Route("api")]
    public class BildataController : ApiController
    {
        /// <summary>
        /// Hent DMR oplysninger om køretøj
        /// </summary>
        /// <param name="nummerplade">Nummerplade på køretøj</param>
        /// <returns>Bildata objekt</returns>
        [System.Web.Http.Route("api/{nummerplade}")]
        [CacheOutput(ClientTimeSpan = 7200, ServerTimeSpan = 7200)]
        public async Task<Bildata> Get(string nummerplade)
        {
            return await DMRProxy.HentOplysninger(nummerplade, DateTime.Now);
        }

        /// <summary>
        /// Hent historiske DMR oplysninger om køretøj
        /// </summary>
        /// <param name="nummerplade">Nummerplade på køretøj</param>
        /// <param name="dato">Dato for historisk opslag</param>
        /// <returns>Bildata objekt</returns>
        [System.Web.Http.Route("api/{nummerplade}/{dato}")]
        [CacheOutput(ClientTimeSpan = 7200, ServerTimeSpan = 7200)]
        public async Task<Bildata> Get(string nummerplade, DateTime dato)
        {
            return await DMRProxy.HentOplysninger(nummerplade, dato);
        }
    }
}
