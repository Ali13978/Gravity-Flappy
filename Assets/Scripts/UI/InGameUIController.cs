using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameUIController : MonoBehaviour
{
    #region Singleton
    public static InGameUIController Instance;

    private void Awake()
    {
        Instance = this;
    }
    #endregion

    [Header("Score")]
    [SerializeField] TMP_Text ScoreText;



    public void UpdateScore(int _score)
    {
        ScoreText.text = "Score: " + _score; 
    }
}
