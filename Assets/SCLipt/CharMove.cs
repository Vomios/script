// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class CharMove : MonoBehaviour //UTF8
// {

//     private void Start()        //移動方向　最初の段階ではUI非表示
//     {   
//         up.SetActive(false);
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);

//         face.SetActive(false);
//         windows.SetActive(false);
//     }
//     public void stageDate1()    //位置の管理
//     {   
//         int a = 0;
//         int b = 0;
//         first(a, b);
//         Move1(ref a, ref b);
//         Move2(ref a, ref b);
//         Move3(ref a, ref b);
//         Move4(ref a, ref b);
//     }

//     public void stageDate2()    //イベントの管理
//     {
//         int c = 0;
//         int d = 0;
//         second(c, d);
//         Move1(ref c, ref d);
//         Move2(ref c, ref d);
//         Move3(ref c, ref d);
//         Move4(ref c, ref d);
//     }

//     //　紐づけ
//     public GameObject Card1;
//     public GameObject Card2;
//     public GameObject Card3;
//     public GameObject Card4;
//     public GameObject up;
//     public GameObject down;
//     public GameObject right;
//     public GameObject left;

//     public GameObject Image;
//     public GameObject face;
//     public GameObject windows;


//     public void first (int a, int b)  // aとbを取得　→位置の確認
//     {
        
        
//                                     //  カードに数字を振り n を定め　m=1 の引き算を行い nを減らし n=0になった場合suprize
//             Card1.SetActive(false);  //　移動数のカードを非表示
//             Card2.SetActive(false);
//             Card3.SetActive(false);
//             Card4.SetActive(false);

//             if (Card1)　// 1 移動
//             {
//                 if (a == 0 && b == 0)　// 右のみ表示　　　//移動方向を指定
//                 {   
//                     right.SetActive(true); // 移動を表示
//                     Debug.Log(a);
//                 }

//             }

//             if (Card2)　//２　移動
//             {
//                 if(a == 0 && b == 0)
//                 {
//                     right.SetActive(true); // 移動を表示
//                     down.SetActive(true); // 移動を表示
//                 }

            
//              　　　　　　　　　　　　//　card1　の処理へ移行
//             }
//             if (Card3)　//3 移動
//             {
 
//                                     //  card2 　の処理へ移行

//             }
//             if (Card4)  //???
//             {

//                                     // 

//             }
//     }

//     //second
//     public void Move1(ref int a ,ref int c)
//     {
//         up.SetActive(false);                // ボタンを押したら　移動方向の非表示
//         down.SetActive(false);              
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(4f, 0,0);
//         a++;
//         c++;                                // a + 1　c+1
//                                             //Elseのループを行う
//     }

//     public void Move2(ref int a, ref int c)
//     {
//         up.SetActive(false);                // ボタンを押したら　移動方向の非表示
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(-4f, 0, 0);
//         a--;
//         c--;
//                                                 // a - 1　c-1
//     }

//     public void Move3(ref int b, ref int d)
//     {
//         up.SetActive(false);                // ボタンを押したら　移動方向の非表示
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(0, 4f, 0);
//         b++;
//         d++;
//                                                 // b + 1 d+1
//     }

//     public void Move4(ref int b, ref int d)
//     {
//         up.SetActive(false);                // ボタンを押したら　移動方向の非表示
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(0, -4f, 0);
//         b--;
//         d--;
//                                                 // b - 1 d-1
//     }

//     public void second (int c,int d)  //すべてのfirst (card1) が完了したあとにスタート

//     {
//         if (c == 1 && d == 0)
//         {
        
//         }                                  //stageDate2　を参照してイベントを起こす






//         Card1.SetActive(true);                      //イベント完了後
//         Card2.SetActive(true);
//         Card3.SetActive(true);
//         Card4.SetActive(true);
//                                                     //ターン数を引く
//     }

// }

