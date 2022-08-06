using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InformationPanel : MonoBehaviour
{
    [SerializeField] GameObject instructionPanel;
    [SerializeField] GameObject stageSelectorPanel;

    public void ShowPanel()
    {
        instructionPanel.SetActive(true);
        stageSelectorPanel.SetActive(false);
    }
    public void HidePanel()
    {
        instructionPanel.SetActive(false);
        stageSelectorPanel.SetActive(true);
    }
    private void Update()
    {
        if (instructionPanel.activeSelf == true)
        {
            stageSelectorPanel.SetActive(false);
        }
        else
        {
            stageSelectorPanel.SetActive(true);
        }
    }
}
