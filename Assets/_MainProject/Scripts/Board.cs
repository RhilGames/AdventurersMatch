using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //Sets height and width of board
    public int height, width;

    //Sets the background tile to gameobject
    public GameObject bgTilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    // Sets up board
    private void Setup()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 pos = new Vector2(x, y);
                GameObject bgTile = Instantiate(bgTilePrefab, pos, Quaternion.identity);
                bgTile.transform.parent = transform;
            }
        }
    }


}
