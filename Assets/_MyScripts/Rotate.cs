using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public bool enableRotate;
    public int speed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(enableRotate)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
		if (enableRotate) 
		{
			transform.Rotate (new Vector3(0,0,0) * 0);
		}
	}

   public void onClick()
   {
		if(enableRotate) 
			enableRotate = false;
		if (!enableRotate)
			enableRotate = true;
   }

}
