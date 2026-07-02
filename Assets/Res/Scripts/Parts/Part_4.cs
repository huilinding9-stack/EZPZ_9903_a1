using UnityEngine;
using DG.Tweening;
using System.Collections;

public class Part_4 : MonoBehaviour
{
    public CanvasGroup canvasGroup;
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
