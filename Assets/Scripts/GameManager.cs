using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int correctAnswer = 4;

    public GameObject resultImage;
    public GameObject tutorialResult;
    public GameObject wrongImage;

    public void SelectAnswer(int answerNumber)
    {
        StopAllCoroutines();

        if (answerNumber == correctAnswer)
        {
            // 正解！
            resultImage.SetActive(true);
            wrongImage.SetActive(false);

            StartCoroutine(ShowTutorialResult());
        }
        else
        {
            // 不正解
            wrongImage.SetActive(true);

            StartCoroutine(HideWrongAfterDelay());
        }
    }

    IEnumerator ShowTutorialResult()
    {
        // 正解！を1秒表示
        yield return new WaitForSeconds(1f);

        // 正解！を消す
        resultImage.SetActive(false);

        // リザルト画面を表示
        tutorialResult.SetActive(true);
    }

    IEnumerator HideWrongAfterDelay()
    {
        // 不正解を1秒表示
        yield return new WaitForSeconds(1f);

        wrongImage.SetActive(false);
    }
}