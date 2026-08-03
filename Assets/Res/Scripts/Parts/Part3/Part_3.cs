using UnityEngine;
using DG.Tweening;
using System.Collections;
using UnityEngine.Video;

public class Part_3 : MonoBehaviour
{
    public InteractableGeneral preBtn;
    public InteractableGeneral nextBtn;
    public Transform[] books;
    private int mCurIndex;
    public static bool isEnter;
    public MeshRenderer alphaMat;
    private bool mIsShow;
    void Start()
    {
        alphaMat = transform.Find("AlphaModel").GetComponent<MeshRenderer>();

        preBtn.onPrimaryInteract.AddListener(() =>
        {
            isEnter = true;
            mCurIndex--;
            if (mCurIndex < 0)
            {
                mCurIndex =0;
                return;
            }
            float angle =  books[mCurIndex].GetComponent<BookPage>().closeAngle;
            books[mCurIndex ].DOLocalRotate(new Vector3(0, angle, 0),1);

        });

        nextBtn.onPrimaryInteract.AddListener(() =>
        {
            if (!mIsShow)
            {
                mIsShow = true;
                StartCoroutine(IEShowDad());
            }

            isEnter = true;
            mCurIndex++;
            if (mCurIndex >= books.Length)
            {
                mCurIndex = books.Length-1;
                return;
            }
            float angle = books[mCurIndex-1].GetComponent<BookPage>().openAngle;
            books[mCurIndex-1].DOLocalRotate(new Vector3(0, angle, 0), 1);
        });
    }
    private IEnumerator IEShowDad()
    {
        alphaMat.gameObject.SetActive(true);
        alphaMat.material.color = new Color(1, 1, 1, 0);
        float alpha = 0;
        while (alpha < 0.5f)
        {
            alpha += Time.deltaTime * 0.3f;
            alphaMat.material.color = new Color(1, 1, 1, alpha);
            yield return new WaitForEndOfFrame();
        }
    }

}
