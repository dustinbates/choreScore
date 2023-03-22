using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScore.Models;

public class Chore
{
    public Chore(string name, string location, int time)
    { 
        Name = name;
        Location = location;
        Time = time;
    }

    public string Name { get; set; }
    public string Location { get; set; }
    public int Time { get; set; }
    public bool Completed { get; private set; } = false;

    public void CompleteChore()
    {
        this.Completed = true;
    }

}
