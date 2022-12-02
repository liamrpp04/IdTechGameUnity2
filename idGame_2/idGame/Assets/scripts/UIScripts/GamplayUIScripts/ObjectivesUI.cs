using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using System;

public class ObjectivesUI : MonoBehaviour
{
    public static ObjectivesUI Instance;
    [SerializeField] private RectTransform content;
    [SerializeField] private TextMeshProUGUI textRef;
    private Dictionary<string, TextMeshProUGUI> objectives = new Dictionary<string, TextMeshProUGUI>();

    private void Awake()
    {
        Instance = this;
        content.anchoredPosition = new Vector2(-content.sizeDelta.x, content.anchoredPosition.y);
        textRef.gameObject.SetActive(false);
        //Show();
    }

    public static void Show(Action OnComplete = null) => Instance._Show(OnComplete);
    public static void Hide(Action OnComplete = null) => Instance._Hide(OnComplete);
    public static void AddObjective(string id, string text) => Instance._AddObjective(id, text);
    public static void CompleteObjective(string id, Action OnComplete = null) => Instance._CompleteObjective(id, OnComplete);
    public static void Clear() => Instance._Clear();

    public void _Show(Action OnComplete = null)
    {
        content.DOAnchorPosX(30, 0.65f).OnComplete(() => OnComplete?.Invoke());
    }


    public void _Hide(Action OnComplete = null)
    {
        content.DOAnchorPosX(-content.sizeDelta.x, 0.65f).OnComplete(() => OnComplete?.Invoke());

    }

    public void _AddObjective(string id, string text)
    {
        var newTask = Instantiate(textRef, content);
        newTask.text = "* "+ text;
        newTask.gameObject.SetActive(true);
        newTask.color = Color.black;
        newTask.alpha = 0;
        newTask.DOFade(1, 0.65f).OnComplete(() =>
        {
            newTask.DOColor(Color.white, 0.7f);
        });
        objectives.Add(id, newTask);
    }

    public void _CompleteObjective(string id, Action OnComplete = null)
    {
        if (!objectives.ContainsKey(id)) return;
        var task = objectives[id];
        task.DOColor(Color.green, 0.5f).OnComplete(() =>
        {
            task.DOFade(0, 0.5f).OnComplete(() =>
            {
                objectives.Remove(id);
                Destroy(task.gameObject);
                OnComplete?.Invoke();
            });
        });
    }

    public void _Clear()
    {
        foreach (var task in objectives.Values) Destroy(task.gameObject);

        objectives.Clear();
    }

}
