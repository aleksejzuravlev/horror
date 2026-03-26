using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RadColector : MonoBehaviour
{

    public string tipString;
    public Text tipText;
    public Image fillCircle;
    public float circleSpeed;

    public RadDialogueController1 radDialogueController1;

public GameObject radinHand;
    private bool inTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tipText.text = tipString;
            inTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tipText.text = "";
            inTrigger = false;
        }
    }
    IEnumerator Timer()
        {
            while (true)
            {
                fillCircle.fillAmount += circleSpeed;
                yield return new WaitForSeconds(1.0f / 30.0f);

                if (fillCircle.fillAmount == 1)
                {
                    break;
                }
            }
            radDialogueController1.StartDioluge();
            Destroy(gameObject);
            radinHand.SetActive(true);
            fillCircle.fillAmount = 0;
            tipText.text = "";
        }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inTrigger)
        {
            StartCoroutine("Timer");

        }
        if(Input.GetKeyUp(KeyCode.E))
        {
            StopAllCoroutines();
            fillCircle.fillAmount = 0;
        }
        
    }
}
