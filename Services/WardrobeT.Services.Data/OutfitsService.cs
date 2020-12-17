namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WardrobeT.Data.Common.Repositories;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;

    public class OutfitsService : IOutfitsService
    {
        public OutfitsService(IRepository<Wear> repository, IRepository<Outfit> outfitsRepository, IRepository<ApplicationUser> usersRepository)
        {
            this.WearsRepository = repository;
            this.OutfitsRepository = outfitsRepository;
            this.UsersRepository = usersRepository;
        }

        public IRepository<Wear> WearsRepository { get; }

        public IRepository<Outfit> OutfitsRepository { get; }

        public IRepository<ApplicationUser> UsersRepository { get; }

        public async Task<ICollection<Outfit>> GetMyOutfitsAsync(string username)
        {
            var tops = await this.WearsRepository.All().Where(x => x.Owner.UserName == username &&
                    x.Type.Cover == Cover.top).ToListAsync();
            var middles = await this.WearsRepository.All().Where(x => x.Owner.UserName == username &&
                    x.Type.Cover == Cover.middle).ToListAsync();
            var bottoms = await this.WearsRepository.All().Where(x => x.Owner.UserName == username &&
                    x.Type.Cover == Cover.bottom).ToListAsync();

            var result = new List<Outfit>();

            if (tops.Count() == 0 || middles.Count() == 0 || bottoms.Count() == 0)
            {
                return null;
            }

            var randum1 = new Random();
            var randum2 = new Random();
            var randum3 = new Random();

            for (int i = 0; i < 10; i++)
            {
                result.Add(new Outfit()
                {
                    Top = tops[randum1.Next(0, tops.Count)],
                    Middle = middles[randum2.Next(0, middles.Count)],
                    Bottom = bottoms[randum3.Next(0, bottoms.Count)],
                });
            }

            return result;
        }

        public async Task CreateOutfitAsync(string topId, string middleId, string bottomId)
        {
            var top = await this.WearsRepository.All().Where(x => x.Id == topId).FirstOrDefaultAsync();
            var middle = await this.WearsRepository.All().Where(x => x.Id == middleId).FirstOrDefaultAsync();
            var bottom = await this.WearsRepository.All().Where(x => x.Id == bottomId).FirstOrDefaultAsync();

            await this.OutfitsRepository.AddAsync(new Outfit
            {
                Top = top,
                Middle = middle,
                Bottom = bottom,
            });
            await this.OutfitsRepository.SaveChangesAsync();
        }

        public async Task<List<Outfit>> GetOutfitsAsync(string username)
            => await this.OutfitsRepository.All().Where(x => x.Top.Owner.UserName == username)
                .Select(x => x)
                .Include(x => x.Top)
                .Include(x => x.Middle)
                .Include(x => x.Bottom)
                .ToListAsync();

        public async Task DeleteOutfitAsync(string username, string id)
        {
            if (await this.OutfitsRepository.All().FirstOrDefaultAsync(x => x.Id == id) != null &&
                await this.OutfitsRepository.All().Include(x => x.Top).Where(x => x.Top.Owner.UserName == username && x.Id == id).FirstOrDefaultAsync() != null)
            {
                this.OutfitsRepository.Delete(await this.OutfitsRepository.All().FirstOrDefaultAsync(x => x.Id == id));
                await this.OutfitsRepository.SaveChangesAsync();
            }
        }
    }
}
