using UnityEngine;
using System.Collections;

public class DestroySphereController : MonoBehaviour {
    public void Shot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>();
        
    }


    // Use this for initialization
    void Start () {
        //Shot(new Vector3(0, 200, 2000));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
