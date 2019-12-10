using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoat : MonoBehaviour
{
	public float rotationSpeed = 10.0f;
	
	float rotation = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	rotation += rotationSpeed;
        this.gameObject.transform.rotation = Quaternion.AngleAxis(rotation, Vector3.up);
    }
}
