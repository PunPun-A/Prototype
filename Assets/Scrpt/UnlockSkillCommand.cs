using UnityEngine;


public class UnlockSkillCommand : ICommand
{

    private UnlockNewSkill _unlockSystem;
    private int _skillId;

    public UnlockSkillCommand(UnlockNewSkill unlockSystem, int skillId)
    {
        _unlockSystem = unlockSystem;
        _skillId = skillId;
    }

    public void Execute()
    {
        _unlockSystem.UnlockSpecificSkill(_skillId);
    }
}
