using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockLevelAndSkill : MonoBehaviour
{
    public static UnlockLevelAndSkill instance;

    [Header("Level 1 Objects")]
    public GameObject Col;
    public GameObject Sign1;

    [Header("Level 2 Objects")]
    public GameObject Col2;
    public GameObject Sign2;


    private ILevelState _currentState;

    void Awake()
    {
        instance = this;
        _currentState = new Level1State();
    }


    public void SetState(ILevelState newState)
    {
        _currentState = newState;
    }


    public void LevelUp()
    {
        _currentState.HandleLevelUp(this);
    }
}