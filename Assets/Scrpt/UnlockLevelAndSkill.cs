using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnlockLevelAndSkill : MonoBehaviour
{
    public static UnlockLevelAndSkill instance;
    
    public GameObject Col;
    public GameObject Col2;
    public GameObject Sign1;
    public GameObject Sign2;
    
    void Awake()
    {
        instance = this;
    }

    public void UnlockNewLvl()
    {
        Col.SetActive(false);
        Sign1.SetActive(true);
    }
    public void UnlockNewLvl2()
    {
        Col2.SetActive(false);
        Sign2.SetActive(true);
    }


}
