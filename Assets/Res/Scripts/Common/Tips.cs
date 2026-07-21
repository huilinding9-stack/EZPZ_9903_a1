using UnityEngine;

public class Tips : MonoBehaviour
{
    public GameObject nextTip;
    public string tipContent;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (tipContent != "")
            {
                Toast.Instance.ShowContent(tipContent);

            }
            nextTip?.SetActive(true);
            GameObject.Destroy(gameObject);
        }
    }
}
