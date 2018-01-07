using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
    
    public float standingThreshold = 30f;
    
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        print(name + IsStanding());
    }

    public bool IsStanding ()
    {
        Vector3 rotationInEuler = transform.rotation.eulerAngles;
        float tiltInX = Mathf.Abs(Mathf.DeltaAngle(rotationInEuler.x, 0));
        float tiltInZ = Mathf.Abs(Mathf.DeltaAngle(rotationInEuler.z, 0));

        return (tiltInX < standingThreshold && tiltInZ < standingThreshold);
    }
}
