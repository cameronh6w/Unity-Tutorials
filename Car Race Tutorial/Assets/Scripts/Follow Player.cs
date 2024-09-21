using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //7)
    public GameObject player;
    //9)
    private Vector3 offset = new Vector3(0,5,-10);

    // Update is called once per frame
    void Update()
    {
        //7) transform.position = player.transform.position;
        //8) transform.position = player.transform.position + new Vector3(0,5,-10);
        //9) transform.position = player.transform.position + offset;
    }

    //10) make it smoother
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}
