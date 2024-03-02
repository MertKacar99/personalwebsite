 

namespace PortfolioWeb.Entity ;
 
    public class Post
    {
        public int PostId { get; set; }
        public string? Title { get; set; } 
         public string? context { get; set; } 
        public DateTime PublishedOn { get; set; }
        public bool IsActive { get; set; }  

        //TODO tag kısmını entegre etmen gerekiyor
        public List<Tag> Tags { get; set; } = new List<Tag>(); 
 
        
    }
 