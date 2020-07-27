using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
	private Text _scoreText;
	public Text ScoreText { get { return _scoreText; } }

    private void Awake()
    {
        _scoreText = GetComponent<Text>();
        _scoreText.text = "";
    }

    //テキスト更新処理
    public void OnScoreChaged(int num)
	{
        _scoreText.text = num.ToString();
	}
}

