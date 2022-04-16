using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
    public GameObject face;
    public GameObject windows;

    public GameObject windows_object = null;

    
    public void normal()  //画像とメッセージの表示
    {
        face.SetActive(true);
        windows.SetActive(true);
    }

    public void  Update ()　//テキストの表示　イベントごとにデータをここに送る
    {
        Text window_text = windows_object.GetComponent<Text>();
        window_text.text = "猫ひろしを倒せ";
    }

    public void Getcd() //イベント　c,d を参照して下のイベントに移行
    {
        
    }
    public void root () //通常イベント（マスを踏んだ際に起こる）
    {
                                                    //確率で　戦闘　アイテムゲット あと他何か　を起こします
    }
    public void poot () //ランダムイベント
    {
                                                    //通常イベントではないランダムイベントを入れます
    }
    public void loot () //マス固定イベント
    {
                                                    //毒マス　宝箱マス　街　ボス固定イベントを起こします
    }

    public void voot () //ミッションイベント　　　　アイテムを持っていると発生
    {

    }

    //すべて終了した後]
    public void normalemd()
    {
        face.SetActive(false);
        windows.SetActive(false);
    }

}
