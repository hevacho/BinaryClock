
using UnityEngine;

public class BinaryItem : MonoBehaviour
{
    private void Awake()
    {
        OnExitTypeOf();
    }

    public void OnEnterTypeOf()
    {
        LeanTween.scaleY(gameObject, 2f, .1f);
        LeanTween.moveY(gameObject, 1.5f, .1f);
    }
    public void OnExitTypeOf()
    {
        LeanTween.scaleY(gameObject, .1f, .1f);
        LeanTween.moveY(gameObject, 0, .1f);
    }
}

