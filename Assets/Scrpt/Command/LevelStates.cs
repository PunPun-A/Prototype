using UnityEngine;

public interface ILevelState
{
    void HandleLevelUp(UnlockLevelAndSkill context);
}


public class Level1State : ILevelState
{
    public void HandleLevelUp(UnlockLevelAndSkill context)
    {
        Debug.Log("State Pattern: Unlocking Level 1 features...");

        
        if (context.Col != null) context.Col.SetActive(false);
        if (context.Sign1 != null) context.Sign1.SetActive(true);

        
        context.SetState(new Level2State());
    }
}


public class Level2State : ILevelState
{
    public void HandleLevelUp(UnlockLevelAndSkill context)
    {
        Debug.Log("State Pattern: Unlocking Level 2 features...");

        
        if (context.Col2 != null) context.Col2.SetActive(false);
        if (context.Sign2 != null) context.Sign2.SetActive(true);

        
        context.SetState(new MaxLevelState());
    }
}


public class MaxLevelState : ILevelState
{
    public void HandleLevelUp(UnlockLevelAndSkill context)
    {
        Debug.Log("State Pattern: Max Level Reached. No further unlocks.");
    }
}