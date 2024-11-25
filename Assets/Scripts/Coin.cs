using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    

    [SerializeField]private Text _coinText;

   




    void OnTriggerEnter2D(Collider2D collider)
    {

        if(collider.transform.CompareTag("Player"))
        {

            AddCoin();

             _coinText.text = PlayerController._coinNumber.ToString();


            Destroy(gameObject);
        }
    }


    void AddCoin()
    {
        PlayerController._coinNumber ++;


        //_coinText.text = _coinNumber.ToString();

        
        
    }

    /*void Update()
    {
        _coinNumber.ToString();
    }*/
}
