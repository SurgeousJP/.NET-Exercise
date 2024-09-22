using FarmPJ.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FarmPJ.Repositories
{
    public class AnimalRepository
    {
        public List<AnimalDTO> GetAllAnimals()
        {
            using (DOTNETEntities db = new DOTNETEntities())
            {
                var animals = (from a in db.Animals
                               join at in db.AnimalTypes
                               on a.AnimalTypeId equals at.AnimalTypeId
                               select new AnimalDTO
                               {
                                   AnimalId = a.AnimalId,
                                   AnimalTypeId = a.AnimalTypeId ?? 1,
                                   AnimalTypeName = at.AnimalTypeName,
                                   Milk = a.Milk,
                                   Count = a.Count,
                                   ChildCount = a.ChildCount,
                                   Sound = at.Sound
                               }).ToList();
                return animals;
            }
        }

        public List<AnimalTypeDTO> GetAnimalTypes()
        {
            using (DOTNETEntities db = new DOTNETEntities())
            {
                return db.AnimalTypes.Select(at => new AnimalTypeDTO
                {
                    AnimalTypeId = at.AnimalTypeId,
                    AnimalTypeName = at.AnimalTypeName,
                    Sound = at.Sound
                }).ToList();
            }
        }

        public void SaveAnimal(AnimalDTO animalDTO)
        {
            using (DOTNETEntities db = new DOTNETEntities())
            {
                Animal animal = new Animal
                {
                    AnimalId = animalDTO.AnimalId,
                    AnimalTypeId = animalDTO.AnimalTypeId,
                    Milk = animalDTO.Milk,
                    ChildCount = animalDTO.ChildCount,
                    Count = animalDTO.Count
                };

                if (animal.AnimalId == 0)
                    db.Animals.Add(animal);
                else
                    db.Entry(animal).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void DeleteAnimal(int animalId)
        {
            using (DOTNETEntities db = new DOTNETEntities())
            {
                var animal = db.Animals.FirstOrDefault(a => a.AnimalId == animalId);
                if (animal != null)
                {
                    db.Animals.Remove(animal);
                    db.SaveChanges();
                }
            }
        }
    }
}
