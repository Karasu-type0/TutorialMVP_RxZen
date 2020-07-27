using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _Speed;

    private void Start()
    {
        Rigidbody rigid = GetComponent<Rigidbody>();

        var input = this.UpdateAsObservable()
            .Select(_ => new Vector3(Input.GetAxis("Horizontal") * _Speed, transform.position.y, Input.GetAxis("Vertical") * _Speed));

        this.FixedUpdateAsObservable()
            .WithLatestFrom(input, (_, output) => output)
            .Subscribe(output => {
                rigid.AddForce(output, ForceMode.Acceleration);
            })
            .AddTo(this);
    }

}


