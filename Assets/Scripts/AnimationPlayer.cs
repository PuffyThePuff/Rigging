using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] public Animator headAnimator;
    [SerializeField] public Animator tentacle1Animator;
    [SerializeField] public Animator tentacle2Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAnimation(string name)
    {
        headAnimator.Play("Reset");
        headAnimator.Play(name);
    }

    public void PlayTentanimaton(string name)
    {
        tentacle1Animator.Play("Reset");
        tentacle2Animator.Play("Reset");
        tentacle1Animator.Play(name);
        tentacle2Animator.Play(name);
    }
}