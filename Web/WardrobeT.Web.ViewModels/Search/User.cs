namespace WardrobeT.Web.ViewModels.Search
{
    using WardrobeT.Data.Models;

    public class User
    {
        public string ProfilePictureUrl { get; set; }

        public string ProfileId { get; set; }

        public string Profile { get; set; }

        public bool IsFollowed { get; set; }
    }
}
