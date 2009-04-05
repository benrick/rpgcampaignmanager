using System.Collections.Generic;

namespace CampaignManager.Core.Domain.Repositories
{
    public interface IWorldRepository
    {
        List<World> ListAll();
        World GetById(int id);
        bool Save(World world);
    }
}