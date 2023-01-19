using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Anime
    {
        [Key]
        public int AnimeID { get; set; }
        public string AnimeName { get; set; }
        public string AnimeDescription { get; set; }
        public string AnimeEpisode { get; set; }
        public string AnimeStatus  { get; set; }
        public string AnimeImageUrL  { get; set; }
        public string AnimeGenre  { get; set; }
        public string Quality  { get; set; }
        public string Duration  { get; set; }

       
    }
}
