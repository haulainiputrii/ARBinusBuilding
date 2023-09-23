using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ChangeScene(){
        SceneManager.LoadScene(1);
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Back(){
        SceneManager.LoadScene(0);
    }
}
