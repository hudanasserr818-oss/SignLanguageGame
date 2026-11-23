using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation :
    MonoBehaviour

{
    public void OpenLevelSelection()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void OpenLevel1()
    {
        SceneManager.LoadScene("Learn1");
    }
    public void OpenLevel2()
    {
        SceneManager.LoadScene("Learn2");
    }
    public void OpenTest1()
    {
        SceneManager.LoadScene("Learn3");
    }
    public void OpenLearn4()
    {
        SceneManager.LoadScene("Learn4");
    }
    public void OpenLearn5()
    {
        SceneManager.LoadScene("Learn5");
    }
    public void OpenLearn6()
    {
        SceneManager.LoadScene("Learn6");
    }
    public void OpenLearn7()
    {
        SceneManager.LoadScene("Learn7");
    }
    string[] letterPages =
    {

        "Learn1",
        "Learn2",
        "Learn3",
        "Learn4",
        "Learn5",
        "Learn6",
        "Learn7"
    };
    public void NextLetterPage()
    {
        string current = SceneManager.GetActiveScene().name;

        switch (current)
        {
            case "Learn1":
                SceneManager.LoadScene("Test1");
                break;

            case "Learn2":
                SceneManager.LoadScene("Test2");
                break;

            case "Learn3":
                SceneManager.LoadScene("Test3");
                break;

            case "Learn4":
                SceneManager.LoadScene("Test4");
                break;

            case "Learn5":
                SceneManager.LoadScene("Test5");
                break;

            case "Learn6":
                SceneManager.LoadScene("Test6");
                break;

            case "Learn7":
                SceneManager.LoadScene("Test7");
                break;
        }
    }
    public void BackLetterPage()
    {
        int index = Array.IndexOf(letterPages, SceneManager.GetActiveScene().name);
        if (index > 0)
            SceneManager.LoadScene(letterPages[index - 1]);
        else if (index == 0)
            SceneManager.LoadScene("LevelSelection");

    }


    string[] sentencepages =
    {
        "sentence1",
         "sentence2",
          "sentence3"
    };
    public void NextSentencePages()
    {
        int index = Array.IndexOf(sentencepages, SceneManager.GetActiveScene().name);
        if (index >= 0 && index < sentencepages.Length - 1)
            SceneManager.LoadScene(sentencepages[index + 1]);
        else if (index == sentencepages.Length - 1)
            SceneManager.LoadScene("Test1");
    }
    public void BackSentencePage()
    {
        int index = Array.IndexOf(sentencepages, SceneManager.GetActiveScene().name);
        if (index > 0)
            SceneManager.LoadScene(sentencepages[index - 1]);
        else if (index == 0)
            SceneManager.LoadScene("LevelSelection");


    }
}









