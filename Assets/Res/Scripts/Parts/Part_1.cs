using UnityEngine;

public class Part_1 : MonoBehaviour
{
    public InteractableGeneral preBtn;
    public InteractableGeneral nextBtn;
    public SpriteRenderer spriteRender;
    public Sprite[] sps;
    private int mCurIndex;
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
        });

        nextBtn.onPrimaryInteract.AddListener(() =>
        {
            mCurIndex++;
            if (mCurIndex >= sps.Length)
            {
                mCurIndex = 0;
            }
            spriteRender.sprite = sps[mCurIndex];
        });
    }
    void Update()
    {

    }
}
