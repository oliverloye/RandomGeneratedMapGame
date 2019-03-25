using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGen : MonoBehaviour {

    public GameObject defaultTile; // tile to be generated

    public int widthGen; // how many tiles to generate
    public int heightGen;
    public float widthMultiplier; // distance between tiles
    public float heightMultiplier;

    // Use this for initialization
    void Start () {

        GetComponent<SpriteRenderer>().enabled = false; // hide the generator start

        for (int x = 0; x < widthGen; x++)
        {
            for (int y = 0; y < heightGen; y++)
            {
                Vector2 pos = new Vector2(transform.position.x + x * widthMultiplier, transform.position.y + y * heightMultiplier); // prepare where to instantiate tile
                GameObject tile = Instantiate(defaultTile, pos, Quaternion.identity); // instantiate tile
                tile.GetComponent<tileScript>().id = x + "-" + y; // assign id to tile
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
