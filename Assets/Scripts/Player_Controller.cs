using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("A"))
        {
            Debug.Log("A has been pressed");
        }
        if (Input.GetKey("A"))
        {
            Debug.Log("A is being held down");
        }
        if (Input.GetKeyUp("A"))
        {
            Debug.Log("A has been released");
        }
    }
}
