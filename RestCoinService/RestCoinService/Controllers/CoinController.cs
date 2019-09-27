using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestCoinService.Model;

namespace RestCoinService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinController : ControllerBase
    {
        #region original
        //// GET: api/Coin
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Coin/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Coin
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Coin/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        #endregion

        private static List<Coin> cList;
        public static int nextid = 0;

        static CoinController()
        {
           // id = 0;
            cList = new List<Coin>();
            Coin coin1 = new Coin("Gold DK 1640", 2500, "Mike");
            Coin coin2 = new Coin("Gold NL 1764", 5000, "Anbo");
            Coin coin3 = new Coin("Gold FR1644", 35000, "Hammer");

            cList.Add(coin1);
            cList.Add(coin2);
            cList.Add(coin3);
        }

        // GET: api/Coin
        [HttpGet]
        public List<Coin> Get()
        {
            return cList;
        }

        // GET: api/Coin/
        [HttpGet("{id}", Name = "Get")]
        public Coin Get(int id)
        {
            var item = cList.SingleOrDefault(c => c.ID == id);
            return item;
        }

        //POST: api/Coin
        [HttpPost]
        public Coin InsertCoin([FromBody] Coin coin)
        {
            Coin c = coin;
            //c.ID = nextid++;
            cList.Add(coin);
            return coin;
        }

    }
}
