using Microsoft.AspNetCore.Mvc;
using Zoo.Models;

namespace Zoo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZooController : ControllerBase
    {
        private Models.Zoo _zoo;
        public ZooController()
        {
            Lion lion = new Lion()
            {
                HasMane = false,
                Name = "John"
            };

            Elephant elephant = new Elephant()
            {
                TrunkLength = 3.5,
                Name = "Lenny"
            };

            List<Animal> animals = new List<Animal>();
            animals.Add(lion);
            animals.Add(elephant);
            _zoo = new Models.Zoo()
            {
                ZooKeeper = "Hannes",
                Animals = animals
            };
        }

        [HttpGet]
        public Models.Zoo WholeZoo()
        {
            return _zoo;
        }
    }
}
