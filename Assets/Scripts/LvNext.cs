using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LvNext : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Goku")
        {
            SceneManager.LoadScene("map3");
        }
    }
}
