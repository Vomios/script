using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMove : MonoBehaviour
{
    public GameObject target;
    public Vector3 distanse;
    // Start is called before the first frame update
    void Start()
    {
        distanse = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + distanse;
    }
}
