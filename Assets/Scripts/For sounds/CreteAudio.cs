using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreteAudio : MonoBehaviour {

    public GameObject music;

    void Start()
    {
        if (GameObject.Find("Audio Cntrl(Clone)") == null)
            Instantiate(music, new Vector3(0, 0, 0), Quaternion.identity);
            }
}
