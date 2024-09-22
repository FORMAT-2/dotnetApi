using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var Stocks = _context.Stocks.ToList()
            .Select(s=>s.ToStockDto());
            return Ok(Stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var Stock = _context.Stocks.Find(id);
            if (Stock == null)
            {
                return NotFound();
            }
            return Ok(Stock.ToStockDto());
        }
    }
}