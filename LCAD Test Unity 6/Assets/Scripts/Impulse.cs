using UnityEngine;

public class Impulse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        body.AddForce(new Vector3(0.0f, 500.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
