using UnityEngine;

public class Part_2 : MonoBehaviour
{
    public InteractableGeneral playBtn;
    public InteractableGeneral stopBtn;
    public AudioSource audioSource;
    void Start()
    {
        playBtn.onPrimaryInteract.AddListener(() =>
        {
            playBtn.gameObject.SetActive(false);
            stopBtn.gameObject.SetActive(true);
            audioSource.Play();
        });

        stopBtn.onPrimaryInteract.AddListener(() =>
        {
            playBtn.gameObject.SetActive(true);
            stopBtn.gameObject.SetActive(false);
            audioSource.Pause();
        });
    }
    void Update()
    {

    }
}
