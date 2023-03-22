namespace choreScore.Repositories
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class ChoresRepository
    {
        private List<Chore> dbChores = new List<Chore>();

        public ChoresRepository()
        {
            dbChores.Add(new Chore("Sweep", "Kitchen", 11));
            dbChores.Add(new Chore("Mop", "Kitchen", 12));
            dbChores.Add(new Chore("Vacuum", "Living Room", 1));
            dbChores.Add(new Chore("Dishes", "Kitchen", 2));
        }

    internal Chore CreateChore(Chore choreData)
    {
      dbChores.Add(new Chore(choreData.Name, choreData.Location, choreData.Time));
      return choreData;
    }

    internal List<Chore> GetAllChores()
    {
        return dbChores;
    }

    internal Chore GetOneChore(string name)
    {
        Chore chore = dbChores.Find(chore => chore.Name == name);
        return chore;
    }

    internal bool RemoveChore(string name)
    {
        int count = dbChores.RemoveAll(chore => chore.Name == name);
        return count > 0;
    }
  }
}