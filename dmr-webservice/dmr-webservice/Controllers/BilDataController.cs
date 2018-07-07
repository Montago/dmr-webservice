#pragma warning disable 1591;

namespace dmr_webservice.Controllers
{
    using dmr_webservice.Code;
    using dmr_webservice.Models;
    using System;
    using System.Threading.Tasks;
    using System.Net.Http;
    using System.Web;
    using System.Web.Http;
    using WebApi.OutputCache.V2;
    using System.Net;

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
            try
            {
                return await DMRProxy.HentOplysninger(nummerplade, DateTime.Now);
            }
            catch (HttpException ex)
            {
                Request.CreateErrorResponse((HttpStatusCode)ex.ErrorCode, ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
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
            try
            {
                return await DMRProxy.HentOplysninger(nummerplade, dato);
            }
            catch (HttpException ex)
            {
                Request.CreateErrorResponse((HttpStatusCode)ex.ErrorCode, ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
            
        }
    }
}
