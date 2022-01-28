using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MediatR;
using Ninject;
using SweetShop.CQRS;
using SweetShop.CQRS.Commands;
using SweetShop.DataAcces.Models;

namespace SweetShop.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            var dd = WebApiConfig.Container.Get<ICQRSCommand>();

            var mediatR = WebApiConfig.Container.Get<IMediator>();

            mediatR.Publish(new UserNotification(new Client()
            {
                FirstName = "GG",
                LastName = "DD"
            }));
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
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
