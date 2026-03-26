using UnityEngine;

public class OutlineRenderDistenc : MonoBehaviour
{

    [SerializeField] float OutlineLineDistenc = 10;

    Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position, transform.position) < OutlineLineDistenc)
        {
            gameObject.layer = 3;
        }
        else
        {
            gameObject.layer = 0;
        }
    }
}
