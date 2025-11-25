using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnlockNewSkill : MonoBehaviour
{
    public static UnlockNewSkill instance;
    
    
    public GameObject Skill;
    public GameObject Skill2;
    public GameObject Skill3;
    public GameObject LockSkill;
    public GameObject LockSkill2;
    public GameObject LockSkill3;

    void Awake()
    {
        instance = this;
    }

    public void UnlockSkill()
    {
        Skill.SetActive(true);
        LockSkill.SetActive(false);
    }
    public void UnlockSkill2()
    {
        Skill2.SetActive(true);
        LockSkill2.SetActive(false);
    }
    public void UnlockSkill3()
    {
        Skill3.SetActive(true);
        LockSkill3.SetActive(false);
    }
}
