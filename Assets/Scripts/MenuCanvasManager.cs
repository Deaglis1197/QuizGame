using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvasManager : MonoBehaviour
{
    GameObject menuCanvas;
    GameObject gameRulesCanvas;
    void Awake() {
        menuCanvas = GameObject.Find("MenuCanvas");
        gameRulesCanvas = GameObject.Find("GameRulesCanvas");
    }
    void Start(){
        MenuCanvasEnable();
    }
    public void MenuCanvasEnable()
    {

        menuCanvas.SetActive(true);
        gameRulesCanvas.SetActive(false);
    }
    public void GameRulesCanvasEnable()
    {

        menuCanvas.SetActive(false);
        gameRulesCanvas.SetActive(true);
    }
}
