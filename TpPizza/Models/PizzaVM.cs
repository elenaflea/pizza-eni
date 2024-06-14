using BO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace TpPizza.Models
{
  
        public class PizzaVM
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            [DisplayName("Pâte")]
            public int IdPate { get; set; }
            public SelectList ChoixPate => new SelectList(Pizza.PatesDisponibles, "Id", "Nom");
            [DisplayName("Ingrédients")]
            public List<int> IdsIngredients { get; set; }
            public SelectList ChoixIngredients => new SelectList(Pizza.IngredientsDisponibles, "Id", "Nom");
        }
    
}

