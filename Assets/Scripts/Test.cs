using UnityEngine;

public class Test : MonoBehaviour
{
    public bool koleso1 = false;
    public bool koleso2 = false;
    public bool koleso3 = false;
    public bool koleso4 = false;
    public bool faral = false;
    public bool farar = false;


    void Update()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(koleso1);
        gameObject.transform.GetChild(1).gameObject.SetActive(koleso2);
        gameObject.transform.GetChild(2).gameObject.SetActive(koleso3);
        gameObject.transform.GetChild(3).gameObject.SetActive(koleso4);
        gameObject.transform.GetChild(4).gameObject.SetActive(faral);
        gameObject.transform.GetChild(5).gameObject.SetActive(farar);
    }

}
