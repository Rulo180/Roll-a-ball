using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 rotation = new Vector3(15, 30, 45);
        transform.Rotate(rotation * Time.deltaTime);
	
	}
}
