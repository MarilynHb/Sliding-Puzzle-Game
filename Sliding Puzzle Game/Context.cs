using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Puzzle_Game;

public class Context
{
    public ObservableCollection<Level> Levels { get; } = new ObservableCollection<Level>();

    public Context()
    {
        Levels.Add(new Level { Name = "First", ImageName = "CHECKLIST.jpg", Difficulty = LevelDifficulty.Easy }); 
    }
}