using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarAnimation : MonoBehaviour
{
    #region VARIAVEIS
    public float duration = 2;
    public Ease ease = Ease.Linear;
    #endregion.

    #region METODOS
    // Start is called before the first frame update
    void Start()
    {
        //se mover ate 6 na posiçaõ x, na duração duration usando o ease Ease.
        transform.DOMoveX(2, duration).SetEase(ease);
    }
    #endregion
}
