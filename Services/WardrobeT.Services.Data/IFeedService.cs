namespace WardrobeT.Services.Data
{
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

    public interface IFeedService
    {
        public Task<string> MakeWearPublicAsync(string id);

        public Task<string> MakeOutfitPublicAsync(string id);
    }
}
