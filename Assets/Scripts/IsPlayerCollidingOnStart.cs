using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsPlayerCollidingOnStart : MonoBehaviour
{


    public bool imColliding = false;
    public GameObject player;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        if(imColliding == false)
        {
            Instantiate(player, transform.position, Quaternion.identity);
            Destroy(gameObject,1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (imColliding == true)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "tile")
        {
            print("COLLISION");
            imColliding = true;
        }
    }
}

