using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScale : EnemyBase
{
    [Header("Enemy Scale")]
    public float Scale = 1.5f;
    public float Duration = 1f;

    [Space()]
    public MeshRenderer meshRenderer;

    private bool _attacking = false;
    private Coroutine _currentCoroutine;

    public override void Attack()
    { 
         
        base.Attack();

        if (!_attacking)
        {
            _attacking = true;
            transform.localScale *= Scale;
            StartCoroutine(ChangeColorCoroutine());
            //ChangeColor();
        }
       
    }

    public void ResetScale()
    {
        transform.localScale = Vector3.one;
        _attacking = false;
    }
    IEnumerator DelayCall()
    {
        //entro e espero um segundo
        yield return new WaitForSeconds(Duration);

        transform.localScale *= Scale;

        yield return new WaitForSeconds(Duration);

        //faça o que temm que fazer
        transform.localScale = Vector3.one;
        _attacking = false;
    }

    private void ChangeColor()
    {
        for (float i = 1f; i >= 0; i -= 00.1f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, Color.red, 1 - i));
        }

    }

    IEnumerator ChangeColorCoroutine()
    {
        for (float i = 1f; i >= 0; i -= 00.1f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, enemyData.colorDamageable, 1 - i));
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForSeconds(.1f);

        for (float i = 1f; i >= 0; i -= 00.1f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.red, enemyData.colorDamageable, 1 - i));
            yield return new WaitForEndOfFrame();
        }
    }

    #region OVERRIDES
    public override void onDamage()
    {
        base.onDamage();
        if (_currentCoroutine == null)
        {
            _currentCoroutine = StartCoroutine(ChangeColorCoroutine());
        }
    }
    #endregion

}
