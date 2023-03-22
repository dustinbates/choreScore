namespace choreScore.Services
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ChoresService
{
    private readonly ChoresRepository _repo;

    public ChoresService(ChoresRepository repo)
    {
        _repo = repo;
    }

    public List<Chore> GetAllChores()
    {
        return _repo.GetAllChores();
    }

    internal Chore GetOneChore(string name)
    {
        Chore chore = _repo.GetOneChore(name);
        if (chore == null) throw new Exception($"No chore at name:{name}");
        return chore;
    }
    internal Chore CreateChore(Chore choreData)
    {
      Chore chore = _repo.CreateChore(choreData);
      return chore;
    }

    internal string RemoveChore(string name)
    {
      Chore chore = this.GetOneChore(name);
      bool result = _repo.RemoveChore(name);
      if (!result) throw new Exception("Did not delete chore");
      return $"{chore.Name} was deleted";
    }

    internal Chore CompleteChore(string name)
    {
      Chore chore = this.GetOneChore(name);
      chore.CompleteChore();
      return chore;
    }
  }

}