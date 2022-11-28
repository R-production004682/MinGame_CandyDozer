using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyManager : MonoBehaviour
{
    const int candyHoldCount = 30;
    public int candy = candyHoldCount;

    [Header("ここに対象のオブジェクトを入れる," +
        "テキストの保持数表記の名前を変えられる")]
    
    public string tagName = "Candy　: ";

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
