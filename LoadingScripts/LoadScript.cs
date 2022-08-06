using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScript : MonoBehaviour
{
    public Image loadingImage;
    private float loadingSpeed = 0.1f;
    public Text loadingPercentage;
    private int intPercentage;
    private void Start()
    {
        loadingImage.fillAmount = 0;
        intPercentage = 0;
        loadingSpeed = 0.01f;
    }

    private void Update()
    {
        if(intPercentage < 100)
        {
            intPercentage++;
        }
        if(intPercentage == 100)
        {
            SceneManager.LoadScene("Press_Start");
        }

        loadingImage.fillAmount += loadingSpeed;
        loadingPercentage.text = intPercentage + "%";

    }
}
