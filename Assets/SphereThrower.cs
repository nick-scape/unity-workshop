using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereThrower : MonoBehaviour
{
	public GameObject sphere;

	public float startSpeed = 100.0f;


    // Update is called once per frame
    void Update()
    {
    	if (Input.GetKeyDown("space"))
        {
            GameObject instance = Instantiate(sphere);

            Rigidbody rb = instance.GetComponent<Rigidbody>() as Rigidbody;

            Vector3 startPos = this.gameObject.transform.position + 
            (this.gameObject.transform.forward * -2.0f);
            startPos.y += 100.0f;

            instance.transform.position = startPos;

            rb.velocity = this.gameObject.transform.forward * -startSpeed;
        }  
    }
}
