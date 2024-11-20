
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Computer1 : MonoBehaviour
{
    float xPosition;
    float yPosition;
    float zPosition;
    public GameObject uiObject;
    [SerializeField] TextMeshProUGUI objectText;
    public bool mouseIsOver = false;
    public bool wasClicked = false;
    [SerializeField] NoteBoard noteBoard;
    public GameObject inputField;
    private TMP_Text reactionTextBox;
    string password = "PILOT2";
    [SerializeField] Door door;
    
    //string text = inputField.GetComponent<TMP_InputField>().text;

    
    // Start is called before the first frame update
    void Start()
    {
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        zPosition = transform.position.z;
    }

   

    private void OnMouseDown()
    {
        if (noteBoard.wasClicked)
        {
            inputField.SetActive(true);
            wasClicked = true;
        }
        if (password == inputField.GetComponent<TMP_InputField>().text) {
            
            Debug.Log("yay");
        } 
    }

    private void OnMouseEnter() 
    {
        
        objectText.text = "Looks like it's password protected...";
    }

    private void OnMouseExit() 
    {
        objectText.text = " ";

    }

    // Update is called once per frame
    void Update()
    {
        
       if(Input.GetKeyDown(KeyCode.Return)) {
        if (password == inputField.GetComponent<TMP_InputField>().text) {
            //door.SetActive(false);
            wasClicked = true;
            door.gameObject.SetActive(false);
            Debug.Log("yay");
        } 
        inputField.SetActive(false);
       }
        
    }
}
