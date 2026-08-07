using UnityEngine;
using DG.Tweening;
using System.Collections;
using TMPro;

public class Part_4 : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public TMP_Text endText;
    void Start()
    {
        
    }
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvasGroup.gameObject.SetActive(true);
            StartCoroutine(IEAlpha());
            if (Part_1.isEnter && !Part_2.isEnter && !Part_3.isEnter)
            {
                endText.text = "The photo freezes that familiar smile.Although many things have become blurry, my mother's presence still remains in my heart.I only retrieved the memories of my mother.";
                transform.Find("Audios/1").gameObject.SetActive(true);
            }
            else if (!Part_1.isEnter && Part_2.isEnter && !Part_3.isEnter)
            {
                endText.text = "The recorder started playing again, and that familiar voice seemed to have never left.My father's words accompanied me, but they couldn't fill in the other missing memories.I only retrieved memories of my father.";
                transform.Find("Audios/2").gameObject.SetActive(true);

            }
            else if (!Part_1.isEnter && !Part_2.isEnter && Part_3.isEnter)
            {
                endText.text = "I opened my diary and recalled my younger self.Those memories of growing up were still vivid, but there were nomemories about my family.I only retrieved my own memories.";
                transform.Find("Audios/3").gameObject.SetActive(true);

            }

            else if (Part_1.isEnter && Part_2.isEnter && !Part_3.isEnter)
            {
                endText.text = "The photos and the recordings pieced together the image of my parents in the past. I seemed to see their happy smiles when they were young, but I couldn't find any memories about my own childhood.I retrieved the memories of my father and mother.";
                transform.Find("Audios/4").gameObject.SetActive(true);

            }
            else if (Part_1.isEnter && !Part_2.isEnter && Part_3.isEnter)
            {
                endText.text = "Photos and diaries reconnect the past.I recalled the countless moments when my mother accompanied me as I grew up, but I never heard my father's voice.I retrieved the memories of myself and my mother.";
                transform.Find("Audios/5").gameObject.SetActive(true);

            }
            else if (!Part_1.isEnter && Part_2.isEnter && Part_3.isEnter)
            {
                endText.text = "The recordings and diaries enabled me to re-examine the past. Memories remained blank.My father's teachings and my childhood self resurfaced, while regarding my mother, I retrieved my own memories of myself and my father.";
                transform.Find("Audios/6").gameObject.SetActive(true);

            }
            else if(Part_1.isEnter && Part_2.isEnter && Part_3.isEnter)
            {
                endText.text = "When the last memory emerged, everything finally fell into place.The voice of my father, the smile of my mother, and that once - again - present self.All of them have returned to my heart again.I finally retrieved all the memories related to this home.";
                transform.Find("Audios/7").gameObject.SetActive(true);
            }
            else 
            {
                endText.text = "I stood in silence with empty hands. No fragments of memory surfaced. The past stayed hidden behind thick haze, and I retrieved none of the lost memories.";
                transform.Find("Audios/8").gameObject.SetActive(true);
            }
        }
    }
    private IEnumerator IEAlpha() {
        float value = 0;
        while (value < 1) {
            value += Time.deltaTime;
            canvasGroup.alpha = value;
            yield return new WaitForEndOfFrame();
        }
    }
}
