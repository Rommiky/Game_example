using UnityEngine;

public class ShowLoosePanel : MonoBehaviour {

    [SerializeField]
    private GameObject losepanel, slowtime;
    private bool addOnce = false;

    void FixedUpdate()
    {
        if (CollisionCars.lose && !addOnce)
        {
            addOnce = true;
            losepanel.SetActive(true);
            slowtime.SetActive(false);
        }
    }
}
