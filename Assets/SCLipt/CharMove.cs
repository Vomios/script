// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class CharMove : MonoBehaviour //UTF8
// {

//     private void Start()        //�ړ������@�ŏ��̒i�K�ł�UI��\��
//     {   
//         up.SetActive(false);
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);

//         face.SetActive(false);
//         windows.SetActive(false);
//     }
//     public void stageDate1()    //�ʒu�̊Ǘ�
//     {   
//         int a = 0;
//         int b = 0;
//         first(a, b);
//         Move1(ref a, ref b);
//         Move2(ref a, ref b);
//         Move3(ref a, ref b);
//         Move4(ref a, ref b);
//     }

//     public void stageDate2()    //�C�x���g�̊Ǘ�
//     {
//         int c = 0;
//         int d = 0;
//         second(c, d);
//         Move1(ref c, ref d);
//         Move2(ref c, ref d);
//         Move3(ref c, ref d);
//         Move4(ref c, ref d);
//     }

//     //�@�R�Â�
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


//     public void first (int a, int b)  // a��b���擾�@���ʒu�̊m�F
//     {
        
        
//                                     //  �J�[�h�ɐ�����U�� n ���߁@m=1 �̈����Z���s�� n�����炵 n=0�ɂȂ����ꍇsuprize
//             Card1.SetActive(false);  //�@�ړ����̃J�[�h���\��
//             Card2.SetActive(false);
//             Card3.SetActive(false);
//             Card4.SetActive(false);

//             if (Card1)�@// 1 �ړ�
//             {
//                 if (a == 0 && b == 0)�@// �E�̂ݕ\���@�@�@//�ړ��������w��
//                 {   
//                     right.SetActive(true); // �ړ���\��
//                     Debug.Log(a);
//                 }

//             }

//             if (Card2)�@//�Q�@�ړ�
//             {
//                 if(a == 0 && b == 0)
//                 {
//                     right.SetActive(true); // �ړ���\��
//                     down.SetActive(true); // �ړ���\��
//                 }

            
//              �@�@�@�@�@�@�@�@�@�@�@�@//�@card1�@�̏����ֈڍs
//             }
//             if (Card3)�@//3 �ړ�
//             {
 
//                                     //  card2 �@�̏����ֈڍs

//             }
//             if (Card4)  //???
//             {

//                                     // 

//             }
//     }

//     //second
//     public void Move1(ref int a ,ref int c)
//     {
//         up.SetActive(false);                // �{�^������������@�ړ������̔�\��
//         down.SetActive(false);              
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(4f, 0,0);
//         a++;
//         c++;                                // a + 1�@c+1
//                                             //Else�̃��[�v���s��
//     }

//     public void Move2(ref int a, ref int c)
//     {
//         up.SetActive(false);                // �{�^������������@�ړ������̔�\��
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(-4f, 0, 0);
//         a--;
//         c--;
//                                                 // a - 1�@c-1
//     }

//     public void Move3(ref int b, ref int d)
//     {
//         up.SetActive(false);                // �{�^������������@�ړ������̔�\��
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
//         up.SetActive(false);                // �{�^������������@�ړ������̔�\��
//         down.SetActive(false);
//         right.SetActive(false);
//         left.SetActive(false);
//         Image.transform.Translate(0, -4f, 0);
//         b--;
//         d--;
//                                                 // b - 1 d-1
//     }

//     public void second (int c,int d)  //���ׂĂ�first (card1) �������������ƂɃX�^�[�g

//     {
//         if (c == 1 && d == 0)
//         {
        
//         }                                  //stageDate2�@���Q�Ƃ��ăC�x���g���N����






//         Card1.SetActive(true);                      //�C�x���g������
//         Card2.SetActive(true);
//         Card3.SetActive(true);
//         Card4.SetActive(true);
//                                                     //�^�[����������
//     }

// }

