using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneMover : MonoBehaviour
{
    //[SerializeField] float moveSpeed = 2;
    //float currentXThrow = 0f;
    float defaultz;
    float defaulty;
    private float savedMousePosition;
    [SerializeField] GameObject resetButton;
    
    
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
        
        if(Input.GetKey(KeyCode.RightArrow))
	    {
            if ( transform.position.x <= 13.86) 
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
	    	
            
	    }
	    if(Input.GetKey(KeyCode.LeftArrow))
	    {
            if (transform.position.x >= -14.04) 
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            }
	    }
        if (Input.GetButton("Fire1")) {
            savedMousePosition += Input.GetAxis("Mouse X");
            //Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(-savedMousePosition, 0, -10);
        }
        
    }

    //set up button
    public void restart() {
        SceneManager.LoadScene(0);
    }
}
