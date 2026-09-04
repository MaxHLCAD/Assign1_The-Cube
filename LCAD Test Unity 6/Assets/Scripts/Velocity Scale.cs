using UnityEngine;

public class VelocityScale : MonoBehaviour
{

    Vector3 velocityLast = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocityLast = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocityCurrent = transform.position;

        Vector3 velocity = (velocityCurrent - velocityLast) * Time.fixedDeltaTime;

        /*

        //Silly thing, ignore this

        Vector3 globalScale = Vector3.one + velocity * 5f;

        // https://discussions.unity.com/t/reading-and-setting-an-objects-global-scale-with-transform-functions/143857

        transform.localScale = Vector3.one;
        transform.localScale = new Vector3(globalScale.x / transform.lossyScale.x, globalScale.y / transform.lossyScale.y, globalScale.z / transform.lossyScale.z);

        */
    }
}
