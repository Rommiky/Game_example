using System.Collections;
using UnityEngine;

public class Showlocations : MonoBehaviour {

    public GameObject[] locations;

    void Start()
    {
        if (PlayerPrefs.HasKey("Location"))
        {
            //Debug.Log("Работает");
            for (int i = 0; i < locations.Length; i++)
                 if (PlayerPrefs.GetString("Location") == locations[i].name)
                 {
                    //  Debug.Log("Raz" + i);
                    locations[i].SetActive(true);
                    break;
                 }

                
        }
        else
            locations[0].SetActive(true);
    }
    
}
