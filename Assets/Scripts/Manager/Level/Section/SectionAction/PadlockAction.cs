using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PadlockAction : BaseSectionAction
{
    public override void Execute()
    {
        var shackle = transform.Find("Shackle");

        transform.DOLocalRotate(new Vector3(0, 90, 0), 1f).SetEase(Ease.OutBounce);
        shackle.DOLocalMoveY(0.5f, 1f).SetEase(Ease.OutBounce);
    }
}