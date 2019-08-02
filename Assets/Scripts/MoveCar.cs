using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
[RequireComponent (typeof (Acceleration))]
public class MoveCar : MonoBehaviour {

    public GameObject turnsignal;
    private Rigidbody rb;
    public static bool moveON = true;
    public float speed = 9f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (moveON)
        rb.MovePosition(transform.position - transform.forward * Time.deltaTime * speed);
    }

}
