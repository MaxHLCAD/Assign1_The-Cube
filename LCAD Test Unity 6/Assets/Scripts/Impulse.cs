using NUnit.Framework.Constraints;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    //Stores forces to be applied upon start
    public float impulse = 100.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Getting rigidbody from gameobject
        Rigidbody body = GetComponent<Rigidbody>();

        //Maximum amount of torque that can be applied
        float torqueRange = 20.0f;

        //Creating random torque
        torqueRange = (Random.value * 2.0f - 1.0f) * torqueRange;

        //Applying forces/torques to rigidbody
        body.AddForce(new Vector3(0.0f, impulse, 0.0f));
        body.AddTorque(new Vector3(torqueRange, torqueRange, torqueRange));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
