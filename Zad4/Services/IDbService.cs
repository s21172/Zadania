using System.Collections.Generic;
using Zad4.Models;

namespace Zad4.Services
{
    public interface IDbService
    {
        public IEnumerable<Animal> GetAnimals(string orderBy);

        public void PostAnimal(Animal animal);

        public void PutAnimal(int idAnimal, Animal animal);

        public void DeleteAnimal(int idAnimal);

        public Animal GetAnimalById(int idAnimal);

    }
}
