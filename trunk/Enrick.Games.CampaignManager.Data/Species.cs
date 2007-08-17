using System;
using System.Collections.Generic;
using System.Text;

namespace Enrick.Games.CampaignManager.Data
{
    public class Species
    {
        #region Properties
        #endregion

        public Species()
        {
            // TODO: Add Constructor Logic Here
        }

        public Species(int Id)
        {
            // TODO: Add Constructor Logic Here
        }

        public bool Save()
        {
            // TODO: Add Save Logic Here
            // Should check a bool for whether it is in the database to see if it is an update.
            // Make sure that only the dirty fields are saved. On initial creation all should be saved.
            throw new NotImplementedException();
        }
    }
}
