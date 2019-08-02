using UnityEngine.UI;
using UnityEngine;

public class ScoreShow : MonoBehaviour {

    [SerializeField]
    private Text topRecord;

    void OnEnable()
    {
        GetComponent<Text>().text = "Score:" + DeleteCars.countCars.ToString();
        if (PlayerPrefs.GetInt("Score") < DeleteCars.countCars)
        {
            PlayerPrefs.SetInt("Score", DeleteCars.countCars);
            topRecord.text = "Top:" + DeleteCars.countCars.ToString();

        }
        else
            topRecord.text = "Top:" + PlayerPrefs.GetInt("Score").ToString();
    }
}
