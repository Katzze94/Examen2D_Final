using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    


    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.transform.CompareTag("Player"))
        {

            Destroy(gameObject);
        }
    }
}
