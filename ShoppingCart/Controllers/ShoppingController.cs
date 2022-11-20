using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        IList<Shopping> product = new List<Shopping>()
        {
            new Shopping()
        {
            ItemId=101,
            ItemName="Iphone",
            price=80000
        },
            new Shopping()
        {
            ItemId=102,
            ItemName="TV",
            price=15000
        },
            new Shopping()
        {
            ItemId=103,
            ItemName="Washing Machine",
            price=25000
        },
            new Shopping()
        {
            ItemId=104,
            ItemName="Laptop",
            price=35000
        },

        };
        [HttpGet]
        [Route("/getall")]
        public IList<Shopping> GetAllItems()
        {
            return product;
        }
        [HttpGet]
        [Route("/getitembyid/{id}")]
        public Shopping GetItem(int id)
        {
            return product.FirstOrDefault(e => e.ItemId == id);
        }
        [HttpDelete]
        [Route("/deleteitembyid/{id}")]
        public IList<Shopping> DeleteItem(int id)
        {
            product.Remove(product.FirstOrDefault(e => e.ItemId == id));
            return product;
        }
    }
}
