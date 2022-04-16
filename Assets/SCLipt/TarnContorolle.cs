using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarnContorolle : MonoBehaviour
{ 
    private int[,] Cells = new int [9,5];

    private int XCharaPosition = 0;
    private int YCharaPosition = 0;

    public GameObject Card1 = null;
    public GameObject Card2 = null;
    public GameObject Card3 = null;
    public GameObject Card4 = null;
    public GameObject up = null;
    public GameObject down = null;
    public GameObject right = null;
    public GameObject left = null;

    private bool IsAblePush = true;
    void Start()
    {
        XCharaPosition = 0;
        YCharaPosition = 3;                 //主人公のポジション

        Cells = new int [,] {               //マスの有無
            {0,0,0,0,1,2,1,2,1},
            {0,0,0,0,2,0,0,0,2},
            {1,2,1,2,1,2,1,1,1},
            {0,0,2,0,0,0,0,0,0},
            {0,0,1,2,1,2,1,0,0}
        };

        up.SetActive(false);
        down.SetActive(false);
        right.SetActive(false);
        left.SetActive(false);
        IsAblePush = true;
        Card1.GetComponent<Button>().onClick.AddListener(() => { Card1Effect();}); 
        Card2.GetComponent<Button>().onClick.AddListener(() => { Card2Effect();}); 
        Card3.GetComponent<Button>().onClick.AddListener(() => { Card3Effect();}); 
        Card4.GetComponent<Button>().onClick.AddListener(() => { Card4Effect();}); 
    }

    void Card1Effect ()
    {
        if(!IsAblePush)
        {
            return;
        }

        IsAblePush = false;
        Debug.Log(XCharaPosition > 0 && Cells[YCharaPosition,XCharaPosition - 1] == 2);
        Debug.Log(XCharaPosition < 9 && Cells[YCharaPosition,XCharaPosition + 1] == 2);
        Debug.Log(YCharaPosition > 0 && Cells[YCharaPosition - 1,XCharaPosition] == 2);
        Debug.Log(XCharaPosition < 5 && Cells[YCharaPosition + 1,XCharaPosition] == 2);

        if(XCharaPosition > 0 && Cells[YCharaPosition,XCharaPosition - 1] == 2)
        {
            left.SetActive(true);
        }
        if(XCharaPosition < 9 && Cells[YCharaPosition,XCharaPosition + 1] == 2)
        {
            right.SetActive(true);
        }
        if(YCharaPosition > 0 && Cells[YCharaPosition - 1,XCharaPosition] == 2)
        {
            up.SetActive(true);
        }
        if(XCharaPosition < 5 && Cells[YCharaPosition + 1,XCharaPosition] == 2)
        {
            down.SetActive(true);
        }
        

        Debug.Log("カード1クリック！！"); 
    }
    void Card2Effect ()
    {
        if(!IsAblePush)
        {
            return;
        }
        IsAblePush = false;

        Debug.Log("カード2クリック！！");
    }
    void Card3Effect ()
    {
        if(!IsAblePush)
        {
            return;
        }

        Debug.Log("カード3クリック！！");   
    }

    void Card4Effect ()
    {
        if(!IsAblePush)
        {
            return;
        }
  
        Debug.Log("カード４クリック！！");
    }


}
