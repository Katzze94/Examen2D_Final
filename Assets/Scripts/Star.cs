using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
  




  void OnTriggerEnter2D(Collider2D collider)
  {

if(collider.transform.CompareTag("Player"))
{

    SceneManager.LoadScene("You Win");

}




  }
}
