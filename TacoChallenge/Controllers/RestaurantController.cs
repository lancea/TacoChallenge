using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TacoChallenge.Data.Repository.IRepository;
using TacoChallenge.Models;

namespace TacoChallenge.Controllers
{
    [ApiController]
    [Route("api/restaurants")]
    public class RestaurantController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Restaurant> GetAll()
        {
            return _unitOfWork.Restaurant.GetAll();
        }
    }
}