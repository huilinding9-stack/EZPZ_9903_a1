using TMPro;
using UnityEngine;

public class EndController : MonoBehaviour
    {
    public GameObject mon;
    public GameObject dad;
    public GameObject self;
    public TMP_Text endText;
    private void Awake()
    {
        if (Part_1.isEnter) 
        {
            mon.SetActive(true);
        }
        if (Part_2.isEnter)
        {
            dad.SetActive(true);
        }
        if (Part_3.isEnter)
        {
            self.SetActive(true);
        }
        if (Part_1.isEnter && !Part_2.isEnter && !Part_3.isEnter)
        {
            endText.text = "You only recovered memories of your mother.";
            transform.Find("Audios/1").gameObject.SetActive(true);
        }
        else if (!Part_1.isEnter && Part_2.isEnter && !Part_3.isEnter)
        {
            endText.text = "You only recovered memories of your father.";
            transform.Find("Audios/2").gameObject.SetActive(true);
        }
        else if (!Part_1.isEnter && !Part_2.isEnter && Part_3.isEnter)
        {
            endText.text = "You only recovered your own memories.";
            transform.Find("Audios/3").gameObject.SetActive(true);
        }
        else if (Part_1.isEnter && Part_2.isEnter && !Part_3.isEnter)
        {
            endText.text = "You recovered memories of your father and mother.";
            transform.Find("Audios/4").gameObject.SetActive(true);
        }
        else if (Part_1.isEnter && !Part_2.isEnter && Part_3.isEnter)
        {
            endText.text = "You recovered memories of yourself and your mother.";
            transform.Find("Audios/5").gameObject.SetActive(true);
        }
        else if (!Part_1.isEnter && Part_2.isEnter && Part_3.isEnter)
        {
            endText.text = "You recovered memories of yourself and your father.";
            transform.Find("Audios/6").gameObject.SetActive(true);
        }
        else if (Part_1.isEnter && Part_2.isEnter && Part_3.isEnter)
        {
            endText.text = "You recovered all memories of this family.";
            transform.Find("Audios/7").gameObject.SetActive(true);
        }
        else
        {
            endText.text = "You recovered none of the lost memories.";
            transform.Find("Audios/8").gameObject.SetActive(true);
        }
    }
}
