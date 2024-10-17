using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2;
    float currentXThrow = 0f;
    float defaultz;
    float defaulty;
    
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
        currentXThrow = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.RightArrow))
	    {
	    	transform.position = new Vector3(speed * Time.deltaTime, 0, -10);
            Debug.Log(transform.position);
	    }
	    if(Input.GetKeyDown(KeyCode.LeftArrow))
	    {
	    	transform.position = new Vector3(speed * Time.deltaTime, 0, -10);
	    }
        if (Input.GetButtonDown("Fire1")) {
            Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(convertedPosition.x, 0, -10);
            //Vector3 move = new Vector3(convertedPosition.x *dragSpeed, 0, -10);
            //transform.Translate(move, Space.World);
        }
        var xMove = currentXThrow * moveSpeed;
       // transform.position = new Vector3(xMove, defaulty, defaultz);
    }

    
}
