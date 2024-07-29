using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelfor : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
   if(collision.gameObject.tag == "Player")
   {
    Debug.Log("LevelGecildi !!");
    DataBase.SaveData();
    SceneManager.LoadScene("Level02");
   }
    }
}
