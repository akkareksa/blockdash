using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    int maxLevel;
    int curLevel;
    static LevelController instance;

    void Awake() {
        instance = this;
    }

    public int getMaxLevel() 
    {
        return this.maxLevel;
    }

    public int getCurLevel() 
    {
        return this.curLevel;
    }

    public void setMaxLevel(int newMaxLevel)
    {
        this.maxLevel=newMaxLevel;
    }

    public void setCurLevel(int newCurLevel)
    {
        this.curLevel=newCurLevel;
    }

    public static LevelController getInstance() 
    {
        return instance;
    } 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
