using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMover : MonoBehaviour
{
    //[SerializeField] float moveSpeed = 2;
    //float currentXThrow = 0f;
    float defaultz;
    float defaulty;
    private float savedMousePosition;
    
    // Start is called before the first frame update
    void Start()
    {
        defaultz = transform.position.z;
        defaulty = transform.position.y;
    }

    // Update is called once per frame
    public float speed = 5.0f;
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.RightArrow))
	    {
	    	transform.position = new Vector3(speed * Time.deltaTime, 0, -10);
            Debug.Log(transform.position);
	    }
	    if(Input.GetKeyDown(KeyCode.LeftArrow))
	    {
	    	transform.position = new Vector3(speed * Time.deltaTime, 0, -10);
	    }
        if (Input.GetButton("Fire1")) {
            savedMousePosition += Input.GetAxis("Mouse X");
            Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(-savedMousePosition, 0, -10);
            //Vector3 move = new Vector3(convertedPosition.x *dragSpeed, 0, -10);
            //transform.Translate(move, Space.World);
        }
        
                    
       // transform.position = new Vector3(xMove, defaulty, defaultz);
    }

    
}
