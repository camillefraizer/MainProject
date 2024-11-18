using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    float xPosition;
    float yPosition;
    float zPosition;
    public GameObject uiObject;
    [SerializeField] TextMeshProUGUI objectText;
    public bool mouseIsOver = false;
    public bool wasClicked = false;
    [SerializeField] Computer1 computer1;

    
    // Start is called before the first frame update
    void Start()
    {
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        zPosition = transform.position.z;
    }

    private void OnMouseDown()
    {
        if (computer1.wasClicked)
        {
        wasClicked = true;
        }
    }


    private void OnMouseEnter() 
    {
        objectText.text = "Locked.";
    }

    private void OnMouseExit() 
    {
        objectText.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        
       
        
    }
}
