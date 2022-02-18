using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void MenuScene(){
        SceneManager.LoadScene("MainMenu");
    }
    public void GameScene(){
        SceneManager.LoadScene("Game");
    }
}
