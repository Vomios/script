using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{

    void Update()
    {
        Transform myTransform = this.transform;

        Vector2 worldPos = myTransform.position;
        float x = worldPos.x;
        float y = worldPos.y;
    }
}
