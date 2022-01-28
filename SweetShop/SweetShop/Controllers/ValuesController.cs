using SweetShop.DataAcces;
using SweetShop.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MediatR;
using Ninject;
using SweetShop.CQRS;
using SweetShop.DataAcces.Models;

namespace SweetShop.Controllers
{
    public class ValuesController : ApiController
    {
        
        private IMediator mediatR = WebApiConfig.Container.Get<IMediator>();
        // GET api/values
        public List<Client> Get()
        { 
            var result =  mediatR.Send(new GetAllUsersQueryNotification());
           var reultd = result.Result.ToList();
           return reultd;
        }

        private void Do()
        {
            var shop = new SweetShopDbContext();
            
            var orders = shop.Clients.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Client client)
        { 
            mediatR.Publish(new UserNotification(client));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
