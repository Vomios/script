using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarnContorolle : MonoBehaviour
{ 
    public GameObject Card1 = null;
    public GameObject Card2 = null;
    public GameObject Card3 = null;
    public GameObject Card4 = null;
    void Start()
    {
        Card1.GetComponent<Button>().onClick.AddListener(() => { PutStone(x + "," + y); }); 
        Card2.GetComponent<Button>().onClick.AddListener(() => { PutStone(x + "," + y); }); 
        Card3.GetComponent<Button>().onClick.AddListener(() => { PutStone(x + "," + y); }); 
        Card4.GetComponent<Button>().onClick.AddListener(() => { PutStone(x + "," + y); }); 
    }

    void Card1Effect ()
    {
        Card1.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card2.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card3.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card4.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); });
        Debug.Log("カード1クリック！！"); 
    }
    void Card2Effect ()
    {
        Card1.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card2.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card3.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card4.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); });
        Debug.Log("カード2クリック！！");
    }
    void Card3Effect ()
    {
        Card1.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card2.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card3.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card4.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); });
        Debug.Log("カード3クリック！！");   
    }

    void Card4Effect ()
    {
        Card1.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card2.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card3.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); }); 
        Card4.GetComponent<Button>().onClick.RemoveListener(() => { PutStone(x + "," + y); });   
        Debug.Log("カード４クリック！！");
    }


}
