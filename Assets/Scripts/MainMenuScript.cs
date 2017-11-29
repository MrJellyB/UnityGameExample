using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private string instraction;


    void OnGUI()
    {
        instraction = "Instraction \n Press Left and Right ....";
        GUI.Label(new Rect(10,10,300,200), instraction);

        if (GUI.Button(new Rect(10, 60, 200, 50), "Start Game"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
