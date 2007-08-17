using System;
using System.Collections.Generic;
using System.Text;

namespace Enrick.Games.CampaignManager.Data
{
    public class Character
    {
        #region Properties

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<CharacterTrait> _characterTraits;
        public List<CharacterTrait> CharacterTraits
        {
            get { return _characterTraits; }
            set { _characterTraits = value; }
        }

        private Species _species;
        public Species Species
        {
            get { return _species; }
            set { _species = value; }
        }


        #endregion

        public Character()
        {
            // TODO: Add Constructor Logic Here
        }

        public Character(int Id)
        {
            // TODO: Add Constructor Logic Here
            // Fetch the entity
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
