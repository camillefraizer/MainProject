using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LabDevice : MonoBehaviour
{
    float xPosition;
    float yPosition;
    float zPosition;
    public GameObject uiObject;
    [SerializeField] TextMeshProUGUI objectText;
    public bool mouseIsOver = false;
    public bool wasClicked = false;
    [SerializeField] Barrel2 barrel2;

    
    // Start is called before the first frame update
    void Start()
    {
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        zPosition = transform.position.z;
    }

    private void OnMouseDown()
    {
        if (!wasClicked && barrel2.wasClicked) 
        {
            transform.rotation *= Quaternion.Euler(0, 0, -90);
            transform.position = new Vector3(xPosition, yPosition - 3.5f, zPosition);
        }
        wasClicked = true;
    }


    private void OnMouseEnter() 
    {
        objectText.text = "Precarious.";
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
