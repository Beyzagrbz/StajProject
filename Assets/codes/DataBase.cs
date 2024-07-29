
using UnityEngine;

public static class DataBase
{
   public static Vector3 SpawnPosition;
   public static int AltinSayisi;
//belleğe kaydetme
public static void LoadData()
{
   AltinSayisi = PlayerPrefs.GetInt("AltinSayisi");
}
   public static void SaveData()
   {
PlayerPrefs.SetInt("AltinSayisi", AltinSayisi);
   }
}
