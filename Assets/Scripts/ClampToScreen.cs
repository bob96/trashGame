using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampToScreen : MonoBehaviour {

    
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -7.5f, 7.5f),
            Mathf.Clamp(transform.position.y, -3.5f, 5.5f),
            transform.position.z);
	}
}
