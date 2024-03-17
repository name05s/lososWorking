using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("finish1"))
        {
            gameObject.transform.position = new Vector3(-62.42f, 4.32f, 0f);
        }
    }
    
}
