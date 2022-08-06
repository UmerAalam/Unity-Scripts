using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipsPanel : MonoBehaviour
{
    [SerializeField] GameObject instructionPanel;
    [SerializeField] GameObject[] tipsText;
    int tipNumber;
    void Start()
    {
        tipNumber = 1;
    }
    public void AddTipNumber()
    {
        tipNumber++;
    }
    public void DecreaseTipNumber()
    {
        tipNumber--;
    }
    public void CloseIntructionPanel()
    {
        instructionPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(tipNumber > 3)
        {
            tipNumber -= 3;
        }
        if (tipNumber < 1)
        {
            tipNumber += 3;
        }
        switch(tipNumber)
        {
            case 1 :
                tipsText[0].SetActive(true);
                tipsText[1].SetActive(false);
                tipsText[2].SetActive(false);

                break;
            case 2 :
                tipsText[0].SetActive(false);
                tipsText[1].SetActive(true);
                tipsText[2].SetActive(false);
                break;
            case 3 :
                tipsText[0].SetActive(false);
                tipsText[1].SetActive(false);
                tipsText[2].SetActive(true);
                break;
        }
    }
}
