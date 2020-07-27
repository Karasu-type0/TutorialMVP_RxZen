using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;
using UniRx.Triggers;

public class PlayerItemView : MonoBehaviour
{
    private readonly Subject<Unit> _subject = new Subject<Unit>();
    public IObservable<Unit> OnTrEnter { get { return _subject; } }

    private void Start()
    {
        //衝突通知
        this.OnTriggerEnterAsObservable()
               .Subscribe(hit =>
               {
                   if (hit.gameObject.tag == "ItemTag") {
                       Destroy(hit.gameObject);
                       GetItem();
                       _subject.OnNext(Unit.Default);
                   }
               })
               .AddTo(this.gameObject);
    }

    private void GetItem()
    {
        Debug.Log("Get!!");
    }
}
