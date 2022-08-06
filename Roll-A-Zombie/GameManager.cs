using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private int selectedZombiePosition;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    void Start()
    {
        scoreText.text = "Score: " + score;
        SelectZombie(selectedZombie);
    }

    void Update()
    {
        if(Input.GetKeyDown("left"))
        {
            GetZombieLeft();
        }
        if (Input.GetKeyDown("right"))
        {
            GetZombieRight();
        }
        if (Input.GetKeyDown("up"))
        {
            PushUp();
        }
    }
    void GetZombieLeft()
    {
        if (selectedZombiePosition == 0)
        {
            selectedZombiePosition = 3;
            SelectZombie(zombies[3]);
        }
        else
        {
            selectedZombiePosition = selectedZombiePosition - 1;
            GameObject newZombie = zombies[selectedZombiePosition];
            SelectZombie(newZombie);
        }
    }
    void GetZombieRight()
    {
        if(selectedZombiePosition == 3)
        {
            selectedZombiePosition = 0;
            SelectZombie(zombies[0]);
        }
        else
        {
         selectedZombiePosition = selectedZombiePosition + 1;
         SelectZombie(zombies[selectedZombiePosition]);
        }
    }
    void SelectZombie(GameObject newZombie)
    {
        selectedZombie.transform.localScale = defaultSize;
        selectedZombie = newZombie;
        newZombie.transform.localScale = selectedSize;
    }
    void PushUp()
    {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }
    public void AddPoint()
    {
        score = score + 1;
        scoreText.text = "Score : " + score;
    }

  

}
