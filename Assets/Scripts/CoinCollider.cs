using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreCoins.coinAmount += 1;
        Destroy(gameObject);
    }
}
