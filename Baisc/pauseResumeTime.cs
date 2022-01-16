using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseResumeTime : MonoBehaviour {

    void Update() {

        // To Pause Time
        Time.timeScale = 0;

        // To Resume Time
        Time.timeScale = 1;
    }

}