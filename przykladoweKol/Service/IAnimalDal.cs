using przykladoweKol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace przykladoweKol.Service
{
    public interface IAnimalDal
    {
        public IEnumerable<Animal> GetAnimals(string sortBy);
    }
}
