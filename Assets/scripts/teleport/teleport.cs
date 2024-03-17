using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            gameObject.transform.position = new Vector3(-59.28f, 39.01f, 0f);
        }
    }
    
}
