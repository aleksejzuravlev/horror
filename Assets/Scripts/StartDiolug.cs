using UnityEngine;
using DialogueEditor;
using StarterAssets;
using Unity.VisualScripting.FullSerializer;

public class StartDiolug : MonoBehaviour
{
    NPCConversation Conv;

    FirstPersonController fpc;

    // Start is called on
    // ce before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Conv = GetComponent<NPCConversation>();

        ConversationManager.Instance.StartConversation(Conv);

        Cursor.lockState = CursorLockMode.None;

        fpc = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
    }

    public void ActivateFPC()
    {
        fpc.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
