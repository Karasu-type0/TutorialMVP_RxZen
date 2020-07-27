using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

public class DownView : MonoBehaviour
{
    private Button _downButton;

    private readonly Subject<Unit> _subject = new Subject<Unit>();
    public IObservable<Unit> OnClick { get { return _subject; } }

    private void Start()
    {
        _downButton = GetComponent<Button>();

        //ボタン押下通知
        _downButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                _subject.OnNext(Unit.Default);
                DownButton();
            })
            .AddTo(this.gameObject);
    }

    private void DownButton()
    {
        Debug.Log("Down!!");
    }
}


