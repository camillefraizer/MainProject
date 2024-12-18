using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteBoard : MonoBehaviour
{
    float xPosition;
    float yPosition;
    float zPosition;
    public GameObject uiObject;
    [SerializeField] TextMeshProUGUI objectText;
    public bool mouseIsOver = false;
    public bool wasClicked = false;
    [SerializeField] LabDevice labDevice;

    
    // Start is called before the first frame update
    void Start()
    {
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        zPosition = transform.position.z;
    }

    private void OnMouseDown()
    {
        if (labDevice.wasClicked)
        {
        transform.position = new Vector3(xPosition + 5, yPosition, zPosition);
        wasClicked = true;
        }
    }


    private void OnMouseEnter() 
    {
        objectText.text = "This board has a lot of stuff on it... 'PILOT2' seems to come up a lot in the text. Weird.";
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
