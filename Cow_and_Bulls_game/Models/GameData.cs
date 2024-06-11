using System.ComponentModel.DataAnnotations;

namespace Cow_and_Bulls_game.Models
{
    public class GameData
    {
        [Display(Name ="Загадайте четырехзначное число")]
        public string number { get; set; }
        public int? bulls { get; set; }
        public int? cows { get; set; }
        public bool isWon { get; set; }
        public string msg { get; set; }
        public int? turns { get; set; }
    }
}
