using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

public class UpView : MonoBehaviour
{
    private Button _upButton;

    private readonly Subject<Unit> _subject = new Subject<Unit>();
    public IObservable<Unit> OnClick { get { return _subject; } }

    private void Start()
    {
        _upButton = GetComponent<Button>();

        //ボタン押下通知
        _upButton.OnClickAsObservable()
            .Subscribe(_ =>
            {
                _subject.OnNext(Unit.Default);
                UpButton();
            })
            .AddTo(this.gameObject);
    }

    private void UpButton()
    {
        Debug.Log("Up!!");
    }
}


