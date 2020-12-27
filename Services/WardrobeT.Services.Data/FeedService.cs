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

    public class FeedService : IFeedService
    {
        public FeedService(
            IRepository<Wear> wearsRepository,
            IRepository<Outfit> outfitsRepository,
            IRepository<WearPost> wearpostsRepository,
            IRepository<OutfitPost> outfitpostsRepository)
        {
            this.WearsRepository = wearsRepository;
            this.OutfitsRepository = outfitsRepository;
            this.WearpostsRepository = wearpostsRepository;
            this.OutfitpostsRepository = outfitpostsRepository;
        }

        public IRepository<Wear> WearsRepository { get; }

        public IRepository<Outfit> OutfitsRepository { get; }

        public IRepository<WearPost> WearpostsRepository { get; }

        public IRepository<OutfitPost> OutfitpostsRepository { get; }

        public async Task<List<OutfitPost>> GetOutfitPostsAsync(string username)
        => await this.OutfitpostsRepository.All().Select(x => x).Where(x => x.Outfit.Top.Owner.UserName != username).OrderBy(x => x.Likes)
            .Include(x => x.Outfit)
            .Include(x => x.Outfit.Top)
            .Include(x => x.Outfit.Top.Owner)
            .Include(x => x.Outfit.Middle)
            .Include(x => x.Outfit.Bottom)
            .ToListAsync();

        public async Task<List<WearPost>> GetWearPostsAsync(string username)
            => await this.WearpostsRepository.All().Select(x => x).Where(x => x.Wear.Owner.UserName != username).OrderBy(x => x.Likes)
            .Include(x => x.Wear)
            .Include(x => x.Wear.Owner)
            .ToListAsync();

        public async Task<string> MakeOutfitPublicAsync(string id)
        {
            if (id == null)
            {
                return null;
            }

            var outfit = await this.OutfitsRepository.All().FirstOrDefaultAsync(x => x.Id == id);
            if (outfit == null)
            {
                return null;
            }

            outfit.IsPublic = true;

            await this.OutfitpostsRepository.AddAsync(new OutfitPost
            {
                Outfit = outfit,
                Likes = 0,
            });
            await this.OutfitpostsRepository.SaveChangesAsync();
            return string.Empty;
        }

        public async Task<string> MakeOutfitPrivateAsync(string id)
        {
            if (id == null)
            {
                return null;
            }

            var outfit = await this.OutfitsRepository.All().FirstOrDefaultAsync(x => x.Id == id);
            if (outfit == null)
            {
                return null;
            }

            outfit.IsPublic = false;

            this.OutfitpostsRepository.Delete(await this.OutfitpostsRepository.All().Where(x => x.Outfit == outfit).FirstOrDefaultAsync());
            await this.OutfitpostsRepository.SaveChangesAsync();
            return string.Empty;
        }

        public async Task<string> MakeWearPublicAsync(string id)
        {
            if (id == null)
            {
                return null;
            }

            var wear = await this.WearsRepository.All().FirstOrDefaultAsync(x => x.Id == id);
            if (wear == null)
            {
                return null;
            }

            wear.IsPublic = true;

            await this.WearpostsRepository.AddAsync(new WearPost
            {
                Wear = wear,
                Likes = 0,
            });
            await this.WearpostsRepository.SaveChangesAsync();
            return string.Empty;
        }

        public async Task<string> MakeWearPrivateAsync(string id)
        {
            if (id == null)
            {
                return null;
            }

            var wear = await this.WearsRepository.All().FirstOrDefaultAsync(x => x.Id == id);
            if (wear == null)
            {
                return null;
            }

            wear.IsPublic = false;

            this.WearpostsRepository.Delete(await this.WearpostsRepository.All().Where(x => x.Wear == wear).FirstOrDefaultAsync());
            await this.WearpostsRepository.SaveChangesAsync();
            return string.Empty;
        }
    }
}
