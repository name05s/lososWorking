
using UnityEngine;

public class npcbratController : MonoBehaviour
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
