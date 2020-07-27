using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgView : MonoBehaviour
{
    private Text _scoreText;
    public Text ScoreText { get { return _scoreText; } }

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
        _scoreText.text = "";
    }

    //テキスト更新処理
    public void JudgText(bool flag)
    {
        if (flag)
        {
            _scoreText.text = "You Win!!";
        }
        else {
            _scoreText.text = "";
        }
    }

}
