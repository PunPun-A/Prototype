using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnlockNewSkill : MonoBehaviour
{
    public static UnlockNewSkill instance;

    [Header("Skill 1")]
    public GameObject Skill;
    public GameObject LockSkill;

    [Header("Skill 2")]
    public GameObject Skill2;
    public GameObject LockSkill2;

    [Header("Skill 3")]
    public GameObject Skill3;
    public GameObject LockSkill3;

    void Awake()
    {
        instance = this;
    }

 
    public void UnlockSpecificSkill(int id)
    {
        switch (id)
        {
            case 1:
                UnlockSkill1();
                break;
            case 2:
                UnlockSkill2();
                break;
            case 3:
                UnlockSkill3();
                break;
            default:
                Debug.LogWarning("Skill ID not found: " + id);
                break;
        }
    }

    
    private void UnlockSkill1()
    {
        Debug.Log("Command Executed: Unlocking Skill 1");
        if (Skill) Skill.SetActive(true);
        if (LockSkill) LockSkill.SetActive(false);
    }
    private void UnlockSkill2()
    {
        Debug.Log("Command Executed: Unlocking Skill 2");
        if (Skill2) Skill2.SetActive(true);
        if (LockSkill2) LockSkill2.SetActive(false);
    }
    private void UnlockSkill3()
    {
        Debug.Log("Command Executed: Unlocking Skill 3");
        if (Skill3) Skill3.SetActive(true);
        if (LockSkill3) LockSkill3.SetActive(false);
    }
}