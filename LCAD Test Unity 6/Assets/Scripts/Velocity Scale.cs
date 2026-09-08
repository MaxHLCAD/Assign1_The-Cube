using UnityEngine;

public class VelocityScale : MonoBehaviour
{
    //Stores rigidbody of object
    Rigidbody rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Getting rigidbody
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Getting velocity of the rigidbody
        Vector3 velocity = rigidBody.linearVelocity;

        //Getting up, forward, right directions of object
        Vector3 up      = transform.rotation * Vector3.up;
        Vector3 forward = transform.rotation * Vector3.forward;
        Vector3 right   = transform.rotation * Vector3.right;

        //Calculating axis to apply scale based upon velocity and direction
        float scaleX = Mathf.Abs(Vector3.Dot(velocity, right));
        float scaleY = Mathf.Abs(Vector3.Dot(velocity, up));
        float scaleZ = Mathf.Abs(Vector3.Dot(velocity, forward));

        //Combinging X, Y, Z scales into vector
        Vector3 scale = new Vector3(scaleX, scaleY, scaleZ);

        //Applying scale to object
        transform.localScale = (scale * 0.15f) + Vector3.one;

        /*
        Quaternion rotation = transform.rotation;

        rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(velocity), velocity.magnitude * 0.02f);

        transform.rotation = rotation;
        */
        

    }

    //Drawing gizmos for debug
    public void OnDrawGizmos()
    {
        Vector3 up      = transform.rotation * Vector3.up;
        Vector3 forward = transform.rotation * Vector3.forward;
        Vector3 right   = transform.rotation * Vector3.right;

        Vector3 velocity = new Vector3(0.0f, 0.0f, 1.0f);

        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, up * (Vector3.Dot(up, velocity) + 1.0f));

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, forward * (Vector3.Dot(forward, velocity) + 1.0f));

        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, right * (Vector3.Dot(right, velocity) + 1.0f));
    }
}
