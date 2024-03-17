using System.Collections;
using UnityEngine;

namespace DialogSystem
{
    public class dialogHolder : MonoBehaviour
    {
        private void Awake()
        {
            StartCoroutine(dialogSekwancja());
        }
        private IEnumerator dialogSekwancja()
        {
            for (int i = 0; i< transform.childCount; i++)
            {
                Deactivate();
                transform.GetChild(i).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(i).GetComponent<dialogLines>().finished);
            }
            gameObject.SetActive(false);
        }
        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {

                transform.GetChild(i).gameObject.SetActive(false);
            }
        }


    }
}

