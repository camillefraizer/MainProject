using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Barrel2 : MonoBehaviour
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
        Destroy(gameObject);
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
        objectText.text = "This barrel looks a little weird, maybe there's something neat in it?";
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