using System.Collections;
using UnityEngine;

[RequireComponent(typeof(CarLight))]
[RequireComponent(typeof(MoveCar))]
public class RDmLD : MonoBehaviour
{

    private Rigidbody rb;
    private float eulerAngleVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<CarLight>().showObject = 4;

    }

    void FixedUpdate()
    {
        leftTurn();
    }

    void leftTurn()
    {
        float carRotation = Mathf.Round (transform.eulerAngles.y);
        if (transform.localPosition.x < -1.5f && carRotation != 0f)
        {
            if (carRotation >= -1f && carRotation <= 4f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, 0f, 0));
                return;
            }
            eulerAngleVelocity = GetComponent<MoveCar>().speed * -8.57f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }
    }

}
