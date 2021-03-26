using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public GameObject player;
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        move = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        transform.position = player.transform.position + move;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
