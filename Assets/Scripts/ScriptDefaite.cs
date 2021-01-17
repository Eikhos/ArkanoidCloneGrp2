using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptDefaite : MonoBehaviour
{
    public void Restart ()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quit ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
