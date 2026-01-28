using System;
using DG.Tweening;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    void Start()
    {
        StartAnimation();
    }

    private void StartAnimation()
    {
        transform.DOMoveY(transform.position.y + 1, .5F)
            .SetEase(Ease.InOutQuad)
            .SetLoops(-1, LoopType.Yoyo);
        transform.DORotate(Vector3.up * 90, .5f)
            .SetEase(Ease.Linear)
            .SetLoops(-1, LoopType.Incremental);
    }
}
