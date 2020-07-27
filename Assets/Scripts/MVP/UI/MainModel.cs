using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class MainModel
{
    //外部通知メソッド
    private ReactiveProperty<int> _score = new ReactiveProperty<int>(0);
    public IReadOnlyReactiveProperty<int> Score { get { return _score; }}

    [SerializeField]
    private int _judgScore = 0;

    //コンストラクタ
    public MainModel(ZenjectScriptableSample data)
    {
        _judgScore = data.JudgScore;
    }


    //データロジック
    public void AddScore(int num)
    {
        _score.Value = Score.Value + num;
    }

    public void SubScore(int num)
    {
        _score.Value = Score.Value - num;
    }

    public bool Judg()
    {
        if (_score.Value >= _judgScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}


