public class LevelUpCommand : ICommand
{
    private UnlockLevelAndSkill _context;

    public LevelUpCommand(UnlockLevelAndSkill context)
    {
        _context = context;
    }

    public void Execute()
    {
        _context.LevelUp();
    }
}