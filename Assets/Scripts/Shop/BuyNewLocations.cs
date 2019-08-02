using UnityEngine;
using UnityEngine.UI;


public class BuyNewLocations : MonoBehaviour {

    public GameObject checkedButton;
    public Sprite unchekButton, checkedButtonSprite;
    public GameObject[] notCurrentLocationButtons;
    public GameObject[] buttonsToDisable;
    public Text coins;
    [SerializeField]
    private int price;
    [SerializeField]
    private string nameOfLocation;
    public AudioClip fail, success;

    void Awake ()
    {
        //Debug.Log(nameOfLocation);
        if (PlayerPrefs.GetString (nameOfLocation) == "Open")
        {
            //Debug.Log(nameOfLocation);
            for (int i = 0; i < buttonsToDisable.Length; i++)
            buttonsToDisable[i].SetActive(false);
            checkedButton.SetActive(true);
        }
    }

    void OnMouseUpAsButton()
    {
        //Debug.Log(nameOfLocation);
        if (PlayerPrefs.GetInt("Coins") >= price)
        {
            if (PlayerPrefs.GetString("Misic") != "no")
            {
                GameObject.FindGameObjectWithTag("QWERT").GetComponent<AudioSource>().clip = success;
                GameObject.FindGameObjectWithTag("QWERT").GetComponent<AudioSource>().Play();
            }
            PlayerPrefs.SetString("Location", nameOfLocation);
            PlayerPrefs.SetString(nameOfLocation, "Open");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - price);
            coins.text = PlayerPrefs.GetInt("Coins").ToString();
            for (int i = 0; i < buttonsToDisable.Length; i++)
                buttonsToDisable[i].SetActive(false);

            for (int i = 0; i < notCurrentLocationButtons.Length; i++)
            {
                notCurrentLocationButtons[i].GetComponent<Image>().sprite = unchekButton;
                checkedButton.SetActive(true);
                checkedButton.transform.GetChild(0).GetComponent<Image>().sprite = checkedButtonSprite;
            }
            
            
        }
        else if (PlayerPrefs.GetString("Misic") != "no")
        {
            gameObject.transform.GetChild(0).GetComponent<AudioSource>().clip = fail;
            gameObject.transform.GetChild(0).GetComponent<AudioSource>().Play();
        }
    }
}
