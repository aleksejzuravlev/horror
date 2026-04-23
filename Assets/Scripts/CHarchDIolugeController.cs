using UnityEngine;
using DialogueEditor;
using StarterAssets;

public class CHarchDIolugeController : MonoBehaviour
{
    public NPCConversation conv;
    public FirstPersonController fpc;

    public void StartDioluge()
    {
        ConversationManager.Instance.StartConversation(conv);
        StopMovment();
    }
    public void StopMovment()
    {
        fpc.enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }
    public void ContinedMovment()
    {
        fpc.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartDioluge();
        }
    }
    public void ActivateFPC()
    {
        fpc.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
