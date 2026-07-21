using UnityEngine;
using DG.Tweening;
using System.Collections;
using UnityEngine.Video;

public class Part_3 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    void Start()
    {
        string videoPath = $"{Application.streamingAssetsPath}/Videos.mp4";
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = videoPath;
        videoPlayer.Prepare();
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
