using UnityEngine;

public class Part_1 : MonoBehaviour
{
    public InteractableGeneral preBtn;
    public InteractableGeneral nextBtn;
    public SpriteRenderer spriteRender;
    public Sprite[] sps;
    private int mCurIndex;
    public static bool isEnter;
    void Start()
    {
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
            mCurIndex++;
            if (mCurIndex >= sps.Length)
            {
                mCurIndex = 0;
            }
            isEnter = true;
            spriteRender.sprite = sps[mCurIndex];
        });
    }
    void Update()
    {

    }
}
