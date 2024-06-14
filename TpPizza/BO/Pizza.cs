using System;

namespace BO {
    public class Pizza {
        public int Id { get; set; }
        public string Nom { get; set; }
        public Pate Pate { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<int> IdsIngredients { get; set; }
  

        public static List<Ingredient> IngredientsDisponibles => new List<Ingredient> {
            new Ingredient{Id=1,Nom="Mozzarella"},
            new Ingredient{Id=2,Nom="Jambon"},
            new Ingredient{Id=3,Nom="Tomate"},
            new Ingredient{Id=4,Nom="Oignon"},
            new Ingredient{Id=5,Nom="Cheddar"},
            new Ingredient{Id=6,Nom="Saumon"},
            new Ingredient{Id=7,Nom="Champignon"},
            new Ingredient{Id=8,Nom="Poulet"}
        };

        public static List<Pate> PatesDisponibles => new List<Pate> {
            new Pate{ Id=1,Nom="Pate fine, base crême"},
            new Pate{ Id=2,Nom="Pate fine, base tomate"},
            new Pate{ Id=3,Nom="Pate épaisse, base crême"},
            new Pate{ Id=4,Nom="Pate épaisse, base tomate"}
        };

        public static List<Pate> GetListOfPates()
        {
            return PatesDisponibles;
        }

        public static List<Ingredient> GetListOfIngredients()
        {
            return IngredientsDisponibles;
        }


        public static List<Pizza> GetListOfPizzas()
        {
            var i = 1;
            return new List<Pizza> {
                new Pizza{Id=i++,Nom = "Margerita",Pate = PatesDisponibles[1],Ingredients = {IngredientsDisponibles[0], IngredientsDisponibles[2]} },
                new Pizza{Id=i++,Nom = "Veggi",Pate = PatesDisponibles[0],Ingredients = {IngredientsDisponibles[0], IngredientsDisponibles[2], IngredientsDisponibles[6]} },
              new Pizza{Id=i,Nom = "Reine",Pate = PatesDisponibles[3],Ingredients = {IngredientsDisponibles[0], IngredientsDisponibles[2], IngredientsDisponibles[6], IngredientsDisponibles[1]} },
            };
        }

 

    }
}
