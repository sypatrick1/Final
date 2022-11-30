using System.ComponentModel.DataAnnotations;

namespace CharacterSeries.Models
{
    public class Character
    {
        public int PokemonID {get; set;} // Primary Key
        [Required]
        public string Description {get; set;} = string.Empty;
        public List<CharacterSeries> CharacterSeries {get; set;} = default!; // Navigation Property. Course can have MANY StudentCourses
    }

    public class StudentCourse
    {
        
        public int PokemonID {get; set;}     // Composite Primary Key, Foreign Key 1
        public int CharacterID {get; set;}    // Composite Primary Key, Foreign Key 2
        public PokemonSeries PokemonSeries {get; set;} = default!; // Navigation Property. One Student per StudentCourse
        public PokemonName PokemonName {get; set;} = default!;   // Navigation Property. One Course per StudentCourse
    }
}