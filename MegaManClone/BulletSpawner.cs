using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public SpriteRenderer playerFlip;
    public GameObject bullet;
    public GameObject bulletSpawnerPos;
    float xPos;
    float yPos;
    float speed;

    private void Start()
    {
        speed = 9f;
    }

    void Update()
    {
        xPos = bulletSpawnerPos.transform.position.x;
        yPos = bulletSpawnerPos.transform.position.y;
        SpawnBullet();
        PlayerFlipCheck();
    }
    void SpawnBullet()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, new Vector2(xPos, yPos), Quaternion.identity);
        }
    }
    void PlayerFlipCheck()
    {
        if (playerFlip.flipX == true)
        {
            if (Input.GetButtonDown("Fire1"))
                bullet.GetComponent<Bullet>().Movement(speed);
        }
        if (playerFlip.flipX == false)
        {
            if (Input.GetButtonDown("Fire1"))
                bullet.GetComponent<Bullet>().Movement(-speed);
        }

    }
}