namespace WardrobeT.Web.ViewModels.Search
{
    using WardrobeT.Data.Models;

    public class User
    {
        public string Id { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string ProfileId { get; set; }

        public string Profile { get; set; }

        public bool IsFollowed { get; set; }
    }
}
