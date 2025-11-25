using UnityEngine;

public class SpawnerCommand : ICommand
{
    private SpawnerManager _spawner;
    private int _level; 

    public SpawnerCommand(SpawnerManager spawner, int level)
    {
        _spawner = spawner;
        _level = level;
    }

    public void Execute()
    {
        if (_level == 1)
        {
            _spawner.SpawnerChange();
        }
        else if (_level == 2)
        {
            _spawner.SpawnerChange2();
        }
    }
}