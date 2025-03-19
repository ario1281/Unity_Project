using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ButtonStart()
    {
        Debug.Log("START");
        SceneManager.LoadScene("GameScene");
    }

    public void ButtonOption()
    {
        Debug.Log("OPTION");
    }

    public void ButtonQuit()
    {
        Debug.Log("QUIT");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
