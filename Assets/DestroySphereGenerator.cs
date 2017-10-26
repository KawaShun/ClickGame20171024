using UnityEngine;
using System.Collections;

public class DestroySphereGenerator : MonoBehaviour {

    public GameObject DestroySpherePrefab;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject DestroySphere = 
                Instantiate(DestroySpherePrefab) as GameObject;
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            DestroySphere.GetComponent<DestroySphereController>().Shot(worldDir.normalized * 2000);
        }
    }
}
