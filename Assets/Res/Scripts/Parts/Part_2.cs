using System.Collections;
using UnityEngine;

public class Part_2 : MonoBehaviour
{
    public InteractableGeneral playBtn;
    public InteractableGeneral stopBtn;
    public AudioSource audioSource;
    public static bool isEnter;
    public MeshRenderer alphaMat;
    private bool mIsShow;
    void Start()
    {
        alphaMat = transform.Find("Dad/AlphaModel").GetComponent<MeshRenderer>();
        playBtn.onPrimaryInteract.AddListener(() =>
        {
            playBtn.gameObject.SetActive(false);
            stopBtn.gameObject.SetActive(true);
            audioSource.Play();
            isEnter = true;
            if (!mIsShow)
            {
                mIsShow = true;
                StartCoroutine(IEShowDad());
            }
        });

        stopBtn.onPrimaryInteract.AddListener(() =>
        {
            playBtn.gameObject.SetActive(true);
            stopBtn.gameObject.SetActive(false);
            audioSource.Pause();
            isEnter = true;
        });
    }

    private IEnumerator IEShowDad()
    {
        alphaMat.material.color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (alpha < 0.5f)
        {
            alpha += Time.deltaTime * 0.3f;
            alphaMat.material.color = new Color(1, 1, 1, alpha);
            yield return new WaitForEndOfFrame();
        }
    }

    void Update()
    {

    }
}
