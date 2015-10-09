using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcZooStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ZooStoreEntities>
    {
        protected override void Seed(ZooStoreEntities context)
        {
            var kinds = new List<Kind>
            {
                new Kind { Name = "Cat" },
                new Kind { Name = "Dog" },
                new Kind { Name = "Humster" },
                new Kind { Name = "Rat/Mouse" },
                new Kind { Name = "Parrot" },
                new Kind { Name = "Fish" },
                new Kind { Name = "Tortoise" },                
                new Kind { Name = "Snail" },
                new Kind { Name = "Shrimp" },
                new Kind { Name = "Exotic" }
            };

            var companies = new List<Company>
            {
                new Company { Name = "Zoo" },             
                new Company { Name = "BabushkaMasha" },              
                new Company { Name = "AnimalShelter" },            
                new Company { Name = "AquaWorld" },                 
                new Company {Name="JummyHummy"},               
                new Company { Name = "Humsterlica" },
                new Company { Name = "ZooFactory" }                 
            };

            new List<Pet>
            {
                new Pet { Title = "Deutsche hund", Kind = kinds.Single(g => g.Name == "Dog"),Description="This dog is the best friend. He's very fast and smart", Price = 5M, Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/ovcharka.jpg" },
                new Pet { Title = "Buldog", Kind = kinds.Single(g => g.Name == "Dog"),Description="This dog was invented in France", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/buldog.jpg" },
                new Pet { Title = "Chihuahua", Kind = kinds.Single(g => g.Name == "Dog"),Description="This is the smallest dog in the world", Price = 5M, Company = companies.Single(a => a.Name == "AnimalShelter"), PetArtUrl = "/Content/Images/chihuahua.jpg" },
                new Pet { Title = "Save your ass", Kind = kinds.Single(g => g.Name == "Dog"),Description="This dog is very DANGEROUS!! RUN!!", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/default.png" },
                new Pet { Title = "Rex", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="It's just like dinosaur", Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/лог.jpg" },
                new Pet { Title = "Pudel", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="Very hairfull and not angry", Company = companies.Single(a => a.Name == "AnimalShelter"), PetArtUrl = "/Content/Images/pudel.jpg" },
                new Pet { Title = "Brodjaga", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="dog from the street. was found in Freedom Square", Company = companies.Single(a => a.Name == "AnimalShelter"), PetArtUrl = "/Content/Images/default.png" },
                new Pet { Title = "Taksa", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="This dog was invented for hunting", Company = companies.Single(a => a.Name == "AnimalShelter"), PetArtUrl = "/Content/Images/taksa.jpg" },
                new Pet { Title = "Peace", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="Very peaceful dog", Company = companies.Single(a => a.Name == "AnimalShelter"), PetArtUrl = "/Content/Images/лог.jpg" },
                new Pet { Title = "Chack Norris", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="He'll save you", Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/chack.jpg" },
                new Pet { Title = "Colly", Kind = kinds.Single(g => g.Name == "Dog"), Price = 5M,Description="Big dog for big people", Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/colly.bmp" },


                new Pet { Title = "Persian", Kind = kinds.Single(g => g.Name == "Cat"),Description="Very soft cat", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/persian.jpg" },
                new Pet { Title = "Siam", Kind = kinds.Single(g => g.Name == "Cat"), Price = 5M, Description="Very proud cat",Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/siam.jpg" },
                new Pet { Title = "Cheeta", Kind = kinds.Single(g => g.Name == "Cat"), Price = 5M,Description="They're very nice", Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/cheeta.jpg" },            
                new Pet { Title = "Tom", Kind = kinds.Single(g => g.Name == "Cat"), Price = 5M,Description="He'll save you from mice", Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/tom.jpg" },
             
                new Pet { Title = "Wave", Kind = kinds.Single(g => g.Name == "Parrot"),Description="He'll talk with you all the time", Price = 5M, Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/wave.jpg" },
                new Pet { Title = "Ara", Kind = kinds.Single(g => g.Name == "Parrot"),Description="It's very big and beautiful dog", Price = 5M, Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/ara.jpg" },
                new Pet { Title = "Nerazluchnik", Kind = kinds.Single(g => g.Name == "Parrot"),Description="They can't live without each other, they're a couple.", Price = 5M, Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/nerazluchnik.jpg" },
                new Pet { Title = "Kakadu", Kind = kinds.Single(g => g.Name == "Parrot"),Description="Definetly big bird", Price = 5M, Company = companies.Single(a => a.Name == "ZooFactory"), PetArtUrl = "/Content/Images/kakadu.jpg" },
                
                new Pet { Title = "Mouse", Kind = kinds.Single(g => g.Name == "Rat/Mouse"), Description="Very small and fast creature",Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/mouse.jpg" },
                new Pet { Title = "Hummyk", Kind = kinds.Single(g => g.Name == "Rat/Mouse"), Description="Small rodent",Price = 5M, Company = companies.Single(a => a.Name == "Humsterlica"), PetArtUrl = "/Content/Images/лог.jpg" },
                new Pet { Title = "Jungar Hummy", Kind = kinds.Single(g => g.Name == "Rat/Mouse"),Description="Very nice and soft small creature, you'll definetly love it! ", Price = 5M, Company = companies.Single(a => a.Name == "JummyHummy"), PetArtUrl = "/Content/Images/лог.jpg" },
                
                new Pet { Title = "Royal", Kind = kinds.Single(g => g.Name == "Shrimp"),Description="It got it's name for royal color", Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/royal.jpg" },
                new Pet { Title = "Brightend Cherry", Kind = kinds.Single(g => g.Name == "Shrimp"), Description="She's brightend.If you buy it, soon you'll have more tham 1 red shrimp",Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/brightend.jpg" },
                new Pet { Title = "Blue", Kind = kinds.Single(g => g.Name == "Shrimp"),Description="Just nice blue colour", Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/blue.jpg" },
                new Pet { Title = "Black", Kind = kinds.Single(g => g.Name == "Shrimp"), Description="obviously black",Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/black.jpg" },
                new Pet { Title = "Silver", Kind = kinds.Single(g => g.Name == "Shrimp"),Description="strange", Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/default.png" },
                new Pet { Title = "Cherry", Kind = kinds.Single(g => g.Name == "Shrimp"), Description="Got name for colour just like cherry. As good is her life, as more cherry it's",Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/cherry.jpg" },
                new Pet { Title = "Red", Kind = kinds.Single(g => g.Name == "Shrimp"),Description="It got it's name for red color", Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/red.jpg" },
                new Pet { Title = "RoyalBlue", Kind = kinds.Single(g => g.Name == "Shrimp"), Description="It got it's name for royal blue color",Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/royalblue.jpg" },
               

                new Pet { Title = "Jungar", Kind = kinds.Single(g => g.Name == "Humster"),Description="He's nice and soft", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/jungar.jpg" },
                new Pet { Title = "Sea Pig", Kind = kinds.Single(g => g.Name == "Humster"),Description="she can swim. maybe.", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/sea_pig.jpg" },
                new Pet { Title = "Shinshilla", Kind = kinds.Single(g => g.Name == "Humster"), Description="She's VERY soft. Don't use it for your coat",Price = 5M, Company = companies.Single(a => a.Name == "Humsterlica"), PetArtUrl = "/Content/Images/shinshilla.jpg" },
           

                new Pet { Title = "Red Ohr", Kind = kinds.Single(g => g.Name == "Tortoise"), Description="Eat all your aqua's floras",Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/red_ohr.jpg" },
                new Pet { Title = "Little", Kind = kinds.Single(g => g.Name == "Tortoise"), Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/little.jpg" },
                new Pet { Title = "Big", Kind = kinds.Single(g => g.Name == "Tortoise"), Description="It's really giant",Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/big.jpg" },
            

                new Pet { Title = "Spider Tarantula", Kind = kinds.Single(g => g.Name == "Exotic"),Description="He' really hairfull", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/tarantula.jpg" },
                new Pet { Title = "Chameleon", Kind = kinds.Single(g => g.Name == "Exotic"), Description="It'll hide and eat all your flies",Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/chameleon.jpg" },
                                              
                new Pet { Title = "Golden", Kind = kinds.Single(g => g.Name == "Fish"),Description="Make a wish =)", Price = 5M, Company = companies.Single(a => a.Name == "JummyHummy"), PetArtUrl = "/Content/Images/golden.jpg" },
                new Pet { Title = "Somik", Kind = kinds.Single(g => g.Name == "Fish"),Description="It'll clean your aquarium's glass", Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/somik.jpg" },
                new Pet { Title = "Guppy Red", Kind = kinds.Single(g => g.Name == "Fish"), Description="Simple fish",Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/guppy_red.jpg" },
                new Pet { Title = "Guppy Blue", Kind = kinds.Single(g => g.Name == "Fish"), Price = 5M, Company = companies.Single(a => a.Name == "AquaWorld"), PetArtUrl = "/Content/Images/guppy_blue.jpg" },

                new Pet { Title = "Akhatina", Kind = kinds.Single(g => g.Name == "Snail"),Description="Giant snail", Price = 5M, Company = companies.Single(a => a.Name == "Zoo"), PetArtUrl = "/Content/Images/akhatina.jpg" },
               
            }.ForEach(a => context.Pets.Add(a));
        }
    }
}