using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            print("Level complete!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
