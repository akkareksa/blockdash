using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour{
    public string sceneName;

    void Start(){
        StartCoroutine(GameScene());    
    }

    IEnumerator GameScene() {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(sceneName);
    }
}
