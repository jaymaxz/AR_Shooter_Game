using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform spawnObject;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)){
            GameObject go = Instantiate(bulletPrefab, spawnObject.position, spawnObject.rotation) as GameObject;
            go.GetComponent<Rigidbody>().AddForce(transform.forward * 30, ForceMode.VelocityChange);
        }
	    
	}
}
