using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // public void PlayGame() {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

    public void goLevel1(){
        SceneManager.LoadScene("Level01");
    }

    public void goLevel2(){
        SceneManager.LoadScene("Level02");
    }

    public void goLevel3(){
        SceneManager.LoadScene("Level03");
    }

     public void goLevel4(){
        SceneManager.LoadScene("Level04");
    }

     public void goLevel5(){
        SceneManager.LoadScene("Level05");
    }

     public void goLevel6(){
        SceneManager.LoadScene("Level06Target");
    }

     public void goLevel7(){
        SceneManager.LoadScene("Level07Target");
    }

     public void goLevel8(){
        SceneManager.LoadScene("Level08Target");
    }

     public void goLevel9(){
        SceneManager.LoadScene("Level09Target");
    }

     public void goLevel10(){
        SceneManager.LoadScene("Level10Target");
    }

    // public void goToWinScene(){
    //     SceneManager.LoadScene("WinScene");
    // }

    // public void goToLoseScene(){
    //     SceneManager.LoadScene("LoseScene");
    // }

    public void goToLevelSelection(){
        // Debug.Log("Selection Menu");
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
