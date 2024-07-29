using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelforward2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag == "Player")
   {
    Debug.Log("LevelGecildi !!");
    DataBase.SaveData();
    SceneManager.LoadScene("Level02");
   }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
