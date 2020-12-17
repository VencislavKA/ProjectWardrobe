namespace WardrobeT.Services.Data
{
    using Microsoft.AspNetCore.Http;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using WardrobeT.Data.Models;

    public interface IOutfitsService
    {
        public Task<ICollection<Outfit>> GetMyOutfitsAsync(string username);

        public Task CreateOutfitAsync(string top, string middle, string bottom);

        public Task<List<Outfit>> GetOutfitsAsync(string username);

        public Task DeleteOutfitAsync(string username, string id);
    }
}
