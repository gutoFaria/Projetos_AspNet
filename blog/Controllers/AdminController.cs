using blog.Models;
using blog.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace blog.Controllers
{

    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IRepositoryBase<User> _userRepository;

        public AdminController(ILogger<AdminController> logger,
                            IRepositoryBase<User> userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public async Task<IActionResult> Register(User model)
        {
            var newUser = new User(Guid.NewGuid(),model.Name,model.Password,model.Email);
            await _userRepository.AddAsync(newUser);
            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Logged()
        {
            await Task.Yield();
            return View();
        }
    }
}