namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Wardrobe.Data;
    using WardrobeT.Data.Common.Repositories;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;

    public class WearsService : IWearsService
    {
        public WearsService(
            IRepository<Wear> repository,
            IRepository<TypeOfWear> tofrepository,
            IUsersService usersService,
            IRepository<Outfit> outfitsRepository)
        {
            this.Repository = repository;
            this.TOFrepository = tofrepository;
            this.UsersService = usersService;
            this.OutfitsRepository = outfitsRepository;
        }

        public IRepository<Wear> Repository { get; }

        public IRepository<TypeOfWear> TOFrepository { get; }

        public IUsersService UsersService { get; }

        public IRepository<Outfit> OutfitsRepository { get; }

        public async Task<ICollection<Wear>> GetTopsAsync(string username)
             => await this.Repository.All().Where(x => x.Owner.UserName == username
                                                     && x.Type.Cover == Cover.top)
                                                 .Select(x => x).ToListAsync();

        public async Task<ICollection<Wear>> GetMiddlesAsync(string username)
            => await this.Repository.All().Where(x => x.Owner.UserName == username
                                                    && x.Type.Cover == Cover.middle)
                                                .Select(x => x).ToListAsync();

        public async Task<ICollection<Wear>> GetBottomsAsync(string username)
            => await this.Repository.All().Where(x => x.Owner.UserName == username
                                                    && x.Type.Cover == Cover.bottom)
                                                .Select(x => x).ToListAsync();

        public async Task<ICollection<Wear>> GetWearsAsync(string username)
            => await this.Repository.All().Where(x => x.Owner.UserName == username).ToListAsync();

        public async Task<ICollection<TypeOfWear>> GetTypeOfWearsAsync() => await this.TOFrepository.All().ToListAsync();

        public async Task CreateWearAsync(string wearType, string seasonId, string colorId, string imagePath, string username)
        {
            var type = await this.TOFrepository.All().FirstOrDefaultAsync(x => x.Id == wearType);
            Season season;
            Color color;
            _ = Enum.TryParse(seasonId, true, out season);
            _ = Enum.TryParse(colorId, true, out color);
            ApplicationUser user = await this.UsersService.GetUserAsync(username);
            var wear = new Wear
            {
                ImageUrl = imagePath,
                Type = type,
                Season = season,
                Color = color,
                Owner = user,
            };
            await this.Repository.AddAsync(wear);
            await this.Repository.SaveChangesAsync();
        }

        public async Task DeleteWearAsync(string id, string username)
        {
            if (await this.Repository.All().FirstOrDefaultAsync(x => x.Id == id) != null &&
               await this.Repository.All().Where(x => x.Owner.UserName == username && x.Id == id).FirstOrDefaultAsync() != null)
            {
                var wear = await this.Repository.All().FirstOrDefaultAsync(x => x.Id == id);
                var toRemove = new List<Outfit>();
                toRemove.AddRange(this.OutfitsRepository.All().Where(x => x.Top == wear));
                toRemove.AddRange(this.OutfitsRepository.All().Where(x => x.Middle == wear));
                toRemove.AddRange(this.OutfitsRepository.All().Where(x => x.Bottom == wear));
                foreach (var item in toRemove)
                {
                    this.OutfitsRepository.Delete(item);
                }

                this.Repository.Delete(await this.Repository.All().FirstOrDefaultAsync(x => x.Id == id));
                await this.Repository.SaveChangesAsync();
            }
        }
    }
}
