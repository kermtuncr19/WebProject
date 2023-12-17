namespace Blog.Web.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; }
        public string Heading { get; set; }
        // soru işareti koymak değer olarak sıfır olabilir anlamına geliyor
        // eğer bu özelliğe sıfır yazmayı denersek entity framework bize hata verir.e
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }
        public ICollection<Tag> Tags { get; set; }
        //tags can have multiple blogposts
    }
}
