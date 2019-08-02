using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCntrl : MonoBehaviour {

    private bool play;

   void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        StartCoroutine(horn());
    }
    void Update()
    {
        if (PlayerPrefs.GetString("Music") != "no" && !play)
        {
            GetComponent<AudioSource>().Play();
            play = true;
        }
        else if (PlayerPrefs.GetString("Music") == "no" && play)
        {
            GetComponent<AudioSource>().Pause();
            play = false;
        }
    }

    IEnumerator horn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(12f, 22f));
            if (PlayerPrefs.GetString("Music") != "no")
                transform.GetChild(0).GetComponent<AudioSource>().Play();
        }
    }
}
