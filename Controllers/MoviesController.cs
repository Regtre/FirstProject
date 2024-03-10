using FirstProject.Models;
using FirstProject.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers
{
    public class MoviesController : Controller
    {

        private StoreContext _context;

        public MoviesController()
        {
            _context = new StoreContext();
        }


        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Random()
        {
            Movie movie = new Movie() { Title = "Hitler" };
            List<Customer> customers = new List<Customer>
            {
                new Customer() { Name = "Rémy" },
                new Customer() { Name = "Paul" }
            };

            RandomMovieViewModel viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            List<Movie> movies = _context.Movies.ToList();
            return View(movies);
        }

        [Route("movies/released/{{year:regex(\\d{4})}}/{{month:regex(\\d{2}):range(1,12)}}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Details(int id)
        {
            Movie? movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        public IActionResult New()
        {
            NewMovieViewModel viewModel = new NewMovieViewModel();
            return View("CustomerForm", viewModel);
        }
    }
}