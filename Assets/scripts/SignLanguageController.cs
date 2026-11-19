using UnityEngine;
public class
SignLanguageController :
    MonoBehaviour
{
    public Animator animator;
    public void PlaySalam()
    {
        animator.Play("Salam_Alaikum");  
    }
}