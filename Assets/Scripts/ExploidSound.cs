using UnityEngine;

public class ExploidSound : MonoBehaviour {

    void Start()
    {
        if (PlayerPrefs.GetString("Misic") != "no")
        {
            GetComponent<AudioSource>().Play();
        }


    }
}
