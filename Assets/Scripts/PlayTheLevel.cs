using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayTheLevel : MonoBehaviour
{
    public int curLevel;
    public float targetTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0.0f)
        {
            SceneManager.LoadScene(curLevel);
        }
    }

    // public void Play(){
    //     SceneManager.LoadScene(curLevel);
    // }
}
