using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUp : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void onClick()
    {
        transform.localScale += new Vector3(0.002f, 0.002f, 0.002f);
    }

}
