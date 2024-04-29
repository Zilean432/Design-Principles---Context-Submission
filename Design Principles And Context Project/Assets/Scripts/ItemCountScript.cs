using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCountScript : MonoBehaviour
{
    public float itemCount = 0f;
    public TextMeshProUGUI itemCounter;

    public void IncreaseCount()
    {
        itemCount = itemCount + 1;
        itemCounter.text = "Items Collected: " + itemCount.ToString();
    }

}
