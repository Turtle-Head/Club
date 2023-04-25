namespace Club.Models
{
    public class Playlist : Song
    {
        public int PlaylistID { get; set; }
        public string PlaylistName { get; set; }
        public ICollection<Song> Songs { get; set; }
    
    }
    }

