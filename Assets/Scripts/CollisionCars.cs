using UnityEngine;

[RequireComponent (typeof (MoveCar))]
public class CollisionCars : MonoBehaviour {

    public GameObject explode;
    public static bool lose = false;
    private bool onceStop;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && !onceStop)
        {
            lose = true;
            onceStop = true;
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * -1000);
            other.gameObject.GetComponent<MoveCar>().speed = 0f;
            gameObject.GetComponent<MoveCar>().speed = 0f;
            MoveCar.moveON = false;
            if (gameObject.transform.position.x < other.gameObject.transform.position.x)
            {
                Vector3 pos = Vector3.Lerp(gameObject.transform.position, other.transform.position, 0.5f);
                Instantiate(explode, new Vector3(pos.x, 1, pos.z), Quaternion.identity);
            }   
         }
    }
}
