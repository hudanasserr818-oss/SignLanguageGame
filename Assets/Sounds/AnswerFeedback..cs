
using UnityEngine;

public class AnswerFeedback : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip correctSound;
    public AudioClip wrongSound;

    public void CorrectAnswer()
    {
        audioSource.PlayOneShot(correctSound);
        Debug.Log("Correct Answer!");
    }

    public void WrongAnswer()
    {
        audioSource.PlayOneShot(wrongSound);
        Debug.Log("Wrong Answer!");
    }
}
