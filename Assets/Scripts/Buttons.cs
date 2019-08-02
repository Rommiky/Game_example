using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public Sprite button, pressed;

    public bool music;

    private Transform child;

    private Image img;

    private float yPos;

    

    private void Start()
    {
        if (music)
        {
            if (PlayerPrefs.GetString("Music") != "on")
            {
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
            }
        }
        child = transform.GetChild(0).transform;
        img = GetComponent<Image>();
    }

    void OnMouseDown()
    {
        img.sprite = pressed;
        yPos = child.localPosition.y;
        child.localPosition = new Vector3(child.localPosition.x, 0, child.localPosition.z);
    }

    private void OnMouseUp()
    {
        img.sprite = button;
        child.localPosition = new Vector3(child.localPosition.x, yPos, child.localPosition.z);
    }

    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString ("Music") != "no")
            GetComponent<AudioSource>().Play();
                switch (gameObject.name)
        {
            case "Play":
                StartCoroutine(LoadScene ("game"));
                break;
            case "Shop":
                StartCoroutine(LoadScene("Shop"));
                break;
            case "How To":
                StartCoroutine(LoadScene("Study"));
                break;
            case "Replay":
                StartCoroutine(LoadScene("game"));
                break;
            case "Home":
                StartCoroutine(LoadScene("Main"));
                break;
            case "Music":
                child.gameObject.SetActive(false);
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    PlayerPrefs.SetString("Music", "no");
                    child = transform.GetChild(1).transform;
                }
                else
                {
                    PlayerPrefs.DeleteKey ("Music");
                    child = transform.GetChild(0).transform;
                }
                child.gameObject.SetActive(true);
                break;
        }       
            
    }

    IEnumerator LoadScene (string scene)
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);
            }

}
