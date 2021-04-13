using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]    
    [ApiController]               //Attrıbute 
    public class ProductsController : ControllerBase
    {
        // Loosely Coupled - gevşek bagımlılık- soyuta bagımlılık
        // Naming convertion c# and java da var 
        //Dependecy chain - bagımlılık  
        // IProductService productService = new ProductManager(new EfProductDal());
        //IoC Container -- inversion of control -- degişim  // arka planda senın yerıne new() ler
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        { 
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
