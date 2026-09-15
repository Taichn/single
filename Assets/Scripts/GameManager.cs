using UnityEngine;
using TMPro;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int correctAnswer = 2;
    public GameObject resultText;
    public TMP_Text resultTextComponent;

    public void SelectAnswer(int answerNumber)
    {
        // すでに処理中なら無視
        StopAllCoroutines();

        if (answerNumber == correctAnswer)
        {
            resultText.SetActive(true);
            resultTextComponent.text = "正解！";
        }
        else
        {
            resultText.SetActive(true);
            resultTextComponent.text = "不正解！";

            StartCoroutine(HideResultAfterDelay());
        }
    }

    IEnumerator HideResultAfterDelay()
    {
        // 1秒待つ
        yield return new WaitForSeconds(1f);

        // 結果表示を消す
        resultText.SetActive(false);
    }
}