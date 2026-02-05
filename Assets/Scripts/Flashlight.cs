using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject lightObject;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        string clipName = animator.GetCurrentAnimatorClipInfo(0)[0].clip.name;
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(clipName == "idal")
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
}
