using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] public Animator headAnimator;
    [SerializeField] public Animator[] tentacleAnimators;

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
        headAnimator.Play(name);
    }

    public void PlayTentanimaton(string name)
    {
        for(int i = 0; i < tentacleAnimators.Length; i++)
        {
            tentacleAnimators[i].Play(name);
        }
    }
}