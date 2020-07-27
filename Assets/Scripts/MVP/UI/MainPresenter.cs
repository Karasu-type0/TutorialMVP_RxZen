using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UniRx;
using UniRx.Triggers;
using Zenject;

//Presenter
public class MainPresenter : MonoBehaviour
{
    //Model
    [Inject]
    private MainModel _mainModel;

    //View
    [Inject]
    private PlayerItemView _playerItemView;
    [Inject]
    private UpView _upView;
    [Inject]
    private DownView _downView;
    [Inject]
    private ScoreView _scoreView;
    [Inject]
    private JudgView _judgView;


    private void Start()
    {
        Init();
    }

    public void Init()
    {
        //イベント処理
        _mainModel.Score
            .Subscribe(_ =>
            {
                _scoreView.OnScoreChaged(_mainModel.Score.Value);
                _judgView.JudgText(_mainModel.Judg());
            });


        _upView.OnClick
            .Subscribe(_ => _mainModel.AddScore(1));

        _downView.OnClick
            .Subscribe(_ => _mainModel.SubScore(1));


        _playerItemView.OnTrEnter
            .Subscribe(_ => _mainModel.AddScore(1));
    }

}

