using System.Collections.Generic;
using CampaignManager.Core.Domain;
using CampaignManager.Core.Domain.Repositories;

namespace CampaignManager.Infrastructure.Repositories
{
    public class WorldRepository : IWorldRepository
    {
        private static World _world1 = new World {Name = "World 1", Description = "A place of magical adventure."};

        public List<World> ListAll()
        {
            return new List<World> {_world1};
        }

        public World GetById(int id)
        {
            return _world1;
        }

        public bool Save(World world)
        {
            _world1 = world;

            return true;
        }
    }
}