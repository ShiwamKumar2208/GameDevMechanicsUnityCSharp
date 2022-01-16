using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    void Update() {
        if (Input.GetKeyDown(KeyCode.R)){              
            // This Statement Checks if Button R is pressed
            // if Button R is pressed Reload the scene
            SceneManager.LoadScene("MainScene");  
            // in my case the scene i want to reload 
            // or just load is MainScene in yours case 
            // it might be different like SampleScene
        }
    }
}