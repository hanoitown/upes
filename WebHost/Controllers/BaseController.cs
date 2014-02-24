using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using UPES.Core.Interfaces;

namespace WebHost.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IStudentAdmin _repo;

        public BaseController(IStudentAdmin repo)
        {
            _repo = repo;
        }
        public BaseController()
        {

        }
    }
}
