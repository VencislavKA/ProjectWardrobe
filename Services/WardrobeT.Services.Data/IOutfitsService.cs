namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Security.Policy;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;
    using WardrobeT.Data.Models;

    public interface IOutfitsService
    {
        public Task<ICollection<Outfit>> GetMyOutfitsAsync(string username);

        public Task CreateOutfitAsync(string top, string middle, string bottom);

        public Task<List<Outfit>> GetOutfitsAsync(string username);

        public Task DeleteOutfitAsync(string username, string id);

        public Task<string> LikeAsync(string id);

        public Task<string> UnlikeAsync(string id);
    }
}
