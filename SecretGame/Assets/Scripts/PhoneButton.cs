using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneButton : MonoBehaviour
{
    public string WriteNumber = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (Phone.StartWrite == false)
        {

            if (Phone.PhoneNumber.Length < 4)
            {
                Phone.PhoneNumber += WriteNumber;
                Debug.Log(Phone.PhoneNumber);
            }
            else
            {
                Phone.PhoneNumber = "";
            }
        }
    }
}
