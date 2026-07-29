using UnityEngine;

public class Part_2 : MonoBehaviour
{
    public InteractableGeneral playBtn;
    public InteractableGeneral stopBtn;
    public AudioSource audioSource;
    public static bool isEnter;

    void Start()
    {
        playBtn.onPrimaryInteract.AddListener(() =>
        {
            playBtn.gameObject.SetActive(false);
            stopBtn.gameObject.SetActive(true);
            audioSource.Play();
            isEnter = true;
        });

        stopBtn.onPrimaryInteract.AddListener(() =>
        {
            playBtn.gameObject.SetActive(true);
            stopBtn.gameObject.SetActive(false);
            audioSource.Pause();
            isEnter = true;
        });
    }
    void Update()
    {

    }
}
