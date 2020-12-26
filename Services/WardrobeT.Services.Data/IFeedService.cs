namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using WardrobeT.Data.Models;

    public interface IFeedService
    {
        public Task<string> MakeWearPublicAsync(string id);

        public Task<string> MakeOutfitPublicAsync(string id);

        public Task<List<OutfitPost>> GetOutfitPostsAsync(string username);

        public Task<List<WearPost>> GetWearPostsAsync(string username);
    }
}
