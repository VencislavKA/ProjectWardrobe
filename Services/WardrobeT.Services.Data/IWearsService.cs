namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Wardrobe.Data;
    using WardrobeT.Data.Models;

    public interface IWearsService
    {
        public Task<ICollection<Wear>> GetTopsAsync(string username);

        public Task<ICollection<Wear>> GetMiddlesAsync(string username);

        public Task<ICollection<Wear>> GetBottomsAsync(string username);

        public Task<ICollection<Wear>> GetWearsAsync(string username);

        public Task<ICollection<TypeOfWear>> GetTypeOfWearsAsync();

        public Task CreateWearAsync(string wearType, string season, string color, string imagePath, string username);

        public Task DeleteWearAsync(string id, string username);
    }
}
