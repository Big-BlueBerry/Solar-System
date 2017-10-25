using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solar_System : MonoBehaviour {
    public GameObject Sun;
    public GameObject Earth;

	// Use this for initialization
	void Start () {
        Earth.GetComponent<Rigidbody>().AddForce(0,100,0);
	}

    // Update is called once per frame
    void Update(){
        //   Sun.transform.Translate(0, 0.1f, 0.1f);
        Earth.GetComponent<Rigidbody>().AddForce(Sun.transform.position - Earth.transform.position);
    }
}
