using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTile : MonoBehaviour
{
    [SerializeField] GameObject[] tiles;
     public GameOver gameOver;
    private void OnMouseDown()
    {
        int tileIndex = Random.Range(0,tiles.Length);
        if (tiles[tileIndex].gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
        else if (tiles[tileIndex].gameObject.layer == 9)
        {
            gameOver.GameOverTime();
        }
    }
 
}
