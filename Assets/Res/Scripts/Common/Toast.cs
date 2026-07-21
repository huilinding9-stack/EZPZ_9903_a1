using TMPro;
using UnityEngine;

public class Toast : MonoBehaviour
{
    public static Toast Instance;
    public TMP_Text toastContent;
    private float mTimer;
    private float mTime = 3;
    private void Awake()
    {
        Instance = this;
        gameObject.SetActive(false);
    }
    public void ShowContent(string content)
    {
        toastContent.text = content;
        gameObject.SetActive(true);
        mTimer = 0;
    }
    private void Update()
    {
        mTimer += Time.deltaTime;
        if (mTimer > mTime) 
        {
            mTimer = 0;
            gameObject.SetActive(false);
        }   
    }
}
