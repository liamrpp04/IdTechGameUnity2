using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System;
using ProjectUtils;

public class PlayerStateUI : MonoBehaviour
{
    public static PlayerStateUI Instance;
    [SerializeField] private float startLife = 10;
    [SerializeField] private Image render;
    float _life;
    bool _critical;
    bool _damageAllowed = true;

    private void Start()
    {
        Instance = this;
        _life = startLife;
    }

    public void RecoverLife(float amount = 1f)
    {
        _life += amount;
        if (_life > startLife) _life = startLife;

        DoRender(Color.green, CalculateRenderStrength(amount), () => SetState(CalculateCritic()));

    }

    public void TakeDamage(float amount = 1f)
    {
        if (!_damageAllowed) return;
        _damageAllowed = false;
        MouseLook.Instance.Shake();
        this.ActionAfterTime(0.7f, () => _damageAllowed = true);

        _life -= amount;
        if (_life <= 0)
        {
            Debug.Log("Dead");
            return;
        }
        DoRender(Color.red, CalculateRenderStrength(amount), () => SetState(CalculateCritic()));

    }

    float CalculateRenderStrength(float amount) => Mathf.InverseLerp(0, startLife / 8, amount);
    bool CalculateCritic() => (_life <= startLife / 8);

    public void SetState(bool critical)
    {
        if (this._critical == critical) return;
        if (critical)
        {
            SetColorWithClearAlpha(Color.red);
            render.DOFade(0.7f, 0.3f).SetLoops(-1, LoopType.Yoyo);
        }
        else
        {
            DOTween.Kill(render);
        }
        _critical = critical;
    }

    public void DoRender(Color color, float strength, Action OnComplete = null)
    {
        SetColorWithClearAlpha(color);
        render.DOFade(strength, 0.3f).OnComplete(() =>
        {
            render.DOFade(0, 0.3f).OnComplete(() =>
            {
                OnComplete?.Invoke();
            });
        });
    }

    void SetColorWithClearAlpha(Color color)
    {
        color.a = 0;
        render.color = color;
    }
}
