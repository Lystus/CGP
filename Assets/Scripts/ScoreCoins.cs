using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCoins : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    public static int coinAmount = 0;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text= coinAmount.ToString();
    }
}
