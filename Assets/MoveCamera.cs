using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject playerPosition;
    const float zPosition = -30.6f;
    void FixedUpdate()
    {
        transform.position = new Vector3(playerPosition.transform.position.x, playerPosition.transform.position.y, zPosition);
    }
}
