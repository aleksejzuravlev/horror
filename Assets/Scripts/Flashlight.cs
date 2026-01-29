using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject lightObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(lightObject.activeSelf == true)
            {
                lightObject.SetActive(false);
            }

            else
            {
                lightObject.SetActive(true);
            }
        }
    }
}
