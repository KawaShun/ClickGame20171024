using UnityEngine;
using System.Collections;

public class DestroySphereController : MonoBehaviour
{

    public void Shot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>();
        if (other.gameObject.tag == "Sphere")
        {
            Destroy(other.gameObject);
        }
    }
    

    // Use this for initialization
    void Start()
    {
        //Shot(new Vector3(0, 200, 2000));
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }
}

