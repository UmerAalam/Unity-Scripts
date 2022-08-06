using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDied : MonoBehaviour
{
    public delegate void EndGame();
    public static event EndGame endGame;

    void PlayerDiedEndGame()
    {
       if(endGame != null)
            endGame();

       Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Collector"))
        {
            PlayerDiedEndGame();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Zombie"))
        {
            PlayerDiedEndGame();
        }
    }
    void OutOFRange()
    {
        if(transform.position.x > -10f)
        {
            PlayerDiedEndGame();
        }
    }
}
