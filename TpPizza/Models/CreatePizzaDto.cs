using BO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;

namespace TpPizza.Models
{
    public class CreatePizzaDto
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        [StringLength(30, MinimumLength = 2)]
        public string Nom { get; set; }

        [Required]
        [DisplayName("Pate")]
        public int IdPate { get; set; }
        public SelectList ChoixPate => new SelectList(Pizza.PatesDisponibles, "Id", "Nom");

       
        [Remote("VerifIngredientsOriginaux", "Pizza", AdditionalFields = nameof(Id))]
        [DisplayName("Ingredients")]
        public List<int> IdsIngredients { get; set; }
        public SelectList ChoixIngredients => new SelectList(Pizza.IngredientsDisponibles, "Id", "Nom");

        public List<Pate> Pates { get; set; }
        public List<Ingredient> Ingredients{ get; set; }
    }
}
