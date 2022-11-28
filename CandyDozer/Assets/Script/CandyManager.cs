using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyManager : MonoBehaviour
{
    const int candyHoldCount = 30;
    public int candy = candyHoldCount;

    [Header("�����ɑΏۂ̃I�u�W�F�N�g������," +
        "�e�L�X�g�̕ێ����\�L�̖��O��ς�����")]
    
    public string tagName = "Candy�@: ";

    public void ConsumeCandy()
    {
        if(candy > 0)
        {
            candy--;
        }

    }

    public int GetCandyAmount()
    {
        return candy;
    }

    public void AddCandy(int amount)
    {
        candy += amount;
    }

    private void OnGUI()
    {
        GUI.color = Color.black;

        string label = tagName + candy;

        GUI.Label(new Rect(50,50,100,30) , label);
    }

}
