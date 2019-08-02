using UnityEngine;
using System.Collections;

public class CarLight : MonoBehaviour
{
    
    public int showObject;

    void Start()
    {
        StartCoroutine(Light());
        if (PlayerPrefs.GetString("Misic") != "no")
            StartCoroutine(sound());
    }

    IEnumerator Light ()
    {
        yield return new WaitForSeconds(0.2f);
        GameObject Light = gameObject.transform.GetChild(showObject).gameObject;
        while (true)
        {
            Light.SetActive(!Light.activeSelf);
            yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator sound()
    {
        GameObject s = Instantiate(GetComponent <MoveCar>().turnsignal , new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        yield return new WaitForSeconds(2f);
        Destroy(s.gameObject);
    }
}