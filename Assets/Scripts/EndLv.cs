using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLv : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.name == "Goku")
        {
            SceneManager.LoadScene("gamecomplete");
        }
    }

}
