using Microsoft.AspNetCore.Mvc;
using Todo_List.Tools;

namespace Todo_List.Controllers
{
    public class TodoListController : Controller
    {
        private DataDbContext _dataDbContext;
        private IDevice _device;

        public TodoListController(IDevice device, DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
            _device = device;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TodoListWindow()
        {
            return View();
        }

        public IActionResult SubmitForm(Task task)
        {
            //_dataDbContext.Add(task);
            //if (_dataDbContext.SaveChanges() > 0)
            //{
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
