using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinsScore : MonoBehaviour
{

    public static CoinsScore instance;
    public TMP_Text coinText;
    public int currentCoins = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        coinText.text = "Coins: " + currentCoins.ToString();
    }

    // Update is called once per frame
    public void IncreaseCoins(int v)
    {
        currentCoins += v;
        coinText.text = "Coins: " + currentCoins.ToString();

        Score.instance.UpdateScore();
    }
}

