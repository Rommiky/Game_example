using UnityEngine;

[RequireComponent (typeof (MoveCar))]
public class Acceleration : MonoBehaviour {

    public GameObject exhaust;
    private int accelerate = 0;

    void OnMouseDown()
    {
        if (accelerate !=2)
        {
            GetComponent<MoveCar>().speed *= 1.5f;
            ++accelerate;
            GameObject ex = Instantiate(exhaust, 
                new Vector3 (gameObject.transform.position.x,0.2f,gameObject.transform.position.z), Quaternion.Euler (90f,0,0)) as GameObject;
            Destroy(ex, 0.5f);
        }
    }
}
