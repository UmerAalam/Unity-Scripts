using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PhysicController : MonoBehaviour
{
    [SerializeField] Slider jumpForceSlider;
    [SerializeField] Slider gravitySlider;
    [SerializeField] Slider massSlider;
    [SerializeField] Slider forwardForceSlider;
    private void Start()
    {
        jumpForceSlider.value = PlayerPrefs.GetFloat("JumpForce");
        gravitySlider.value = PlayerPrefs.GetFloat("Gravity");
        massSlider.value = PlayerPrefs.GetFloat("Mass");
        forwardForceSlider.value = PlayerPrefs.GetFloat("ForwardForce");
        jumpForceSlider.onValueChanged.AddListener(ForceSlider);
        gravitySlider.onValueChanged.AddListener(GravitySlider);
        massSlider.onValueChanged.AddListener(MassSlider);
        forwardForceSlider.onValueChanged.AddListener(ForwardForceSlider);
    }
    void ForceSlider(float forceValue)
    {
        jumpForceSlider.value = forceValue;
        PlayerPrefs.SetFloat("JumpForce", forceValue);
    }
    void GravitySlider(float gravityValue)
    {
        gravitySlider.value = gravityValue;
        PlayerPrefs.SetFloat("Gravity", gravityValue);
    }
    void MassSlider(float massValue)
    {
        massSlider.value = massValue;
        PlayerPrefs.SetFloat("Mass", massValue);
    }
    void ForwardForceSlider(float forwardForceValue)
    {
        forwardForceSlider.value = forwardForceValue;
        PlayerPrefs.SetFloat("ForwardForce", forwardForceValue);
    }
    public void Default()
    {
        jumpForceSlider.value = 3000f;
        gravitySlider.value = 3.8f;
        massSlider.value = 3.7f;
        forwardForceSlider.value = 300f;

    }

}
