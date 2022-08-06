using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour
{
    // Slow Motion
    [SerializeField] Animator vignetteAnim;
    [SerializeField] float vignetteTimeIn;

    void Start()
    {
        vignetteAnim = GetComponent<Animator>();
        vignetteAnim.SetBool("Vignette", true);
    }

    void Update()
    {
        Vignette();
    }
    void Vignette()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            vignetteAnim.SetBool("Vignette", false);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            vignetteAnim.SetBool("Vignette", false);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            StartCoroutine(VignetteIn());
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            StartCoroutine(VignetteIn());
        }
    }
    IEnumerator VignetteIn()
    {
        yield return new WaitForSeconds(vignetteTimeIn);
        vignetteAnim.SetBool("Vignette", true);
    }
}
