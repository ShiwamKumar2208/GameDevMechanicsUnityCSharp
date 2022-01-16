using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    void Update() {
        if (Input.GetKeyDown(KeyCode.D)){  
            // This Statement Checks if Button D is pressed
            // if Button D is pressed Destroy the Game Object
            Destroy(gameObject);
        }
    }
}