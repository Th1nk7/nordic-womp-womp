using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class EggManagerScriptEndless : MonoBehaviour
{
    private AudioSource audioSource;
    public GameObject eggTextObject;
    public int eggCount;
    public string eggCountString;
    public TMP_Text mText;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void UpdateEggCounter(){
        eggCount++;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        eggCountString = eggCount.ToString();
        mText.text = eggCountString;
    }
}
