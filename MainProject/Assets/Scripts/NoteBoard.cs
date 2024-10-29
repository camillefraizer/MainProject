using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteBoard : MonoBehaviour
{
    public GameObject uiObject;
    [SerializeField] TextMeshProUGUI objectText;
    public bool mouseIsOver = false;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        transform.position = new Vector3(-350, -196.7f, 0);
    }

    /*private void OnMouseOver() 
    {
        mouseIsOver = true;
        //uiObject.setActive(true);
        StartCoroutine("WaitForSec");
        //TextHandler();
    }*/

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
