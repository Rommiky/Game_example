using UnityEngine;

public class ShowStudyButtons : MonoBehaviour {

    [SerializeField]
    private GameObject repeat, gonext;
    private bool swich;

    void Start()
    {
        swich = false;
    }

    void FixedUpdate()
    {
        if (SpawnStudyCars.buttonsoff)
        {
            if (!swich)
            {
                repeat.SetActive(false);
                gonext.SetActive(false);
                swich = true;
            }
        }
        else if (!SpawnStudyCars.buttonsoff)
        {
            if (swich)
            {
                repeat.SetActive(true);
                gonext.SetActive(true);
                swich = false;
            }
        }
    }
}
