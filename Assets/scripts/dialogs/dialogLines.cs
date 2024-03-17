using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace DialogSystem
{
    public class dialogLines : dialogBase
    {
        private Text textHolder;
        [SerializeField] private string input;
        [SerializeField] private float delay;

        [SerializeField] private AudioClip sound;

        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image imageHolder;
        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";
                      
            imageHolder.sprite = characterSprite;
            imageHolder.preserveAspect = true;
        }
        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, delay, sound));
        }
    }
}
   
