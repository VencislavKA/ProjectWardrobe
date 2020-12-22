using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeT.Data.Common.Repositories;
using WardrobeT.Data.Models;

namespace WardrobeT.Services.Data
{
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

            await this.OutfitpostsRepository.AddAsync(new OutfitPost
            {
                Outfit = outfit,
                Likes = 0,
            });
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

            await this.WearpostsRepository.AddAsync(new WearPost
            {
                Wear = wear,
                Likes = 0,
            });
            await this.WearpostsRepository.SaveChangesAsync();
            return string.Empty;
        }
    }
}
