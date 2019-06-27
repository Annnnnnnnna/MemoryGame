﻿using UnityEngine;

public class MainCard : MonoBehaviour {

    [SerializeField]
    private MemoryGameController controller;
    [SerializeField]
    private GameObject Card_Back;
    private int _id;

    public void OnMouseDown()
    {
        if(Card_Back.activeSelf && controller.canReveal)
        {
            Card_Back.SetActive(false);
            controller.CardRevealed(this);
        }
    }
   
    public int id
    {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreveal()
    {
        Card_Back.SetActive(true);
    }
}