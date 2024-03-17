using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcsiostraController : MonoBehaviour
{
    [SerializeField] private GameObject dialog;
    public void activatedialog()
    {
        dialog.SetActive(true);
    }
    public bool dialogactive()
    {
        return dialog.activeInHierarchy;
    }
}
