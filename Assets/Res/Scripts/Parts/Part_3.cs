using UnityEngine;
using DG.Tweening;
using System.Collections;
using UnityEngine.Video;

public class Part_3 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
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
            videoPlayer.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            videoPlayer.Stop();
        }
    }

}
