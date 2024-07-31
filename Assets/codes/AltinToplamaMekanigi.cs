using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class AltinToplamaMekanigi : MonoBehaviour
{
    [SerializeField] Vector3 donmeYonu;
    [SerializeField] TextMeshProUGUI goldTxt;
    private void Start()
    {
      goldTxt.text=$"Gold={DataBase.AltinSayisi}";
    }
// Update is called once per frame
    void Update()
    {
      transform.Rotate(donmeYonu);
    }
private void OnTriggerEnter(Collider other)
{    
  if (other.gameObject.tag =="Player")
  {
   gameObject.SetActive(false);
    DataBase.AltinSayisi++;
    goldTxt.text=$"Gold={DataBase.AltinSayisi}";
    Debug.Log(DataBase.AltinSayisi);
  }
}
}