using System.Collections;
using UnityEngine;

public class Part_1 : MonoBehaviour
{
    public InteractableGeneral preBtn;
    public InteractableGeneral nextBtn;
    public SpriteRenderer spriteRender;
    public Sprite[] sps;
    private int mCurIndex;
    public static bool isEnter;
    public MeshRenderer alphaMat;
    private bool mIsShow;

    void Start()
    {
        alphaMat = transform.Find("AlphaModel").GetComponent<MeshRenderer>();

        preBtn.onPrimaryInteract.AddListener(() =>
        {
            mCurIndex--;
            if (mCurIndex < 0)
            {
                mCurIndex = sps.Length - 1;
            }
            spriteRender.sprite = sps[mCurIndex];
            isEnter = true;
        });

        nextBtn.onPrimaryInteract.AddListener(() =>
        {
            if (!mIsShow)
            {
                mIsShow = true;
                StartCoroutine(IEShowDad());
            }

            mCurIndex++;
            if (mCurIndex >= sps.Length)
            {
                mCurIndex = 0;
            }
            isEnter = true;
            spriteRender.sprite = sps[mCurIndex];
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
        yield return new WaitForSeconds(25);
        alphaMat.transform.GetComponent<Animator>().enabled = true;
    }

    void Update()
    {

    }
}
