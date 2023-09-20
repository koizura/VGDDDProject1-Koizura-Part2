using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToPlayer : MonoBehaviour
{
    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAt = Player.position;
        lookAt.y = transform.position.y;
        transform.LookAt(lookAt);
        //transform.Rotate(new Vector3(0, 90, 0));
    }
}
