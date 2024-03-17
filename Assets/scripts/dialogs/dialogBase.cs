using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace DialogSystem
{
        public class dialogBase : MonoBehaviour
    {
        public bool finished { get; private set; }
        protected IEnumerator WriteText(string input, Text textHolder, float delay)
        {
            
            for (int i=0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                yield return new WaitForSeconds(delay);
            }
            yield return new WaitUntil(() => Input.GetMouseButton(0));
          
            finished = true;
        }
    }
}
