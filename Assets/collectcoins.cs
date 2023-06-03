using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectcoins : MonoBehaviour
{
    public int coins;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            Debug.Log("Coin collected");
            coins += 1;
            col.gameObject.SetActive(false);
        }
    }
}
