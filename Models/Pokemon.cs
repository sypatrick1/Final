using System;

// Step 3: Create the data model
namespace Final.Models
{
    public class Pokemon
    {
        public int PokemonID {get; set;} // Primary Key
        public string Individual {get; set;} = string.Empty;
        public string PokemonName {get; set;} = string.Empty;
        public string PokemonSeries {get; set;} = string.Empty;
    }
}