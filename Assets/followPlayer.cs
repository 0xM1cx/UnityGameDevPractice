using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject playerPosition;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(playerPosition.transform.position.x + 3.4f, playerPosition.transform.position.y, -15.29f);
    }
}
