using UnityEngine;
using DG.Tweening;
using System.Collections;
using TMPro;

public class Part_4 : MonoBehaviour
{
    public GameObject root;
    private void Awake()
    {
        root.SetActive(false);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            root.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            root.SetActive(true);
        
    }
}
