using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private List<Order> orders;

        public OrdersController() {
            orders = new List<Order>();
            orders.Add(new Order(108, "7a27481f-dff9-4198-96b0-0af897eddfc6", "Glasgow" ));
            orders.Add(new Order(571, "b85a7970-d24b-4910-95f3-3ce4b497eee1", "London" ));
            orders.Add(new Order(877, "7a8e0d62-2cda-444a-85a1-3846af8a9dfb", "Outer Mongolia" ));
            orders.Add(new Order(263, "0ec68792-4e6c-42ed-b5fa-7f2f106d44b0", "Cardiff" ));
        }

        // GET api/orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return orders;
        }

        // GET api/orders/5
        [HttpGet("{id}")]
        public ActionResult<dynamic> Get(string id)
        {
            Order order = orders.Find(o => o.Id.Equals(id));
            if(order == null) 
                return NotFound();
            
            return order;
        }
    }

    public class Order {
        public Order(int a, string i, string l) {
            this.Amount = a;
            this.Id = i;
            this.Location = l;
        }

        public int Amount { get; set; }
        public string Id { get; set; }
        public string Location { get; set; }
    }
}
