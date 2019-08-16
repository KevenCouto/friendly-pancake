using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Script : MonoBehaviour
{
    public int life1 = 80;
    public int life2 = 80;
    public GameObject Pikashu;
    public GameObject Chinchar;
    Animator A;
    public Text p1;
    public Text p2;
    public bool ataque = true;
    // Start is called before the first frame update
    void Start()
    {
       A= Pikashu.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        int critico;
        if (life1>0&life2>0)
        {
            p1.text = "LIFE: " + life1.ToString();
            p2.text = "LIFE: " + life2.ToString();
        }
        //if (life2 > 0)
        //{
           
        //}
       
        if (ataque==true& Input.GetKeyDown(KeyCode.C)&life1>0)
        {
            critico = Random.Range(1, 10);
            if (critico==10)
            {
                life2 -= 60;

            }
            else
            {
                life2 -= 30;
            }
            if (life2<=0)
            {
                p2.text = "MORREU ";
                p1.text = "VENCEU";
                Destroy(Chinchar);
            }
            
            ataque = false;
        }

        if (ataque == false & Input.GetKeyDown(KeyCode.Alpha1)&life2>0)
        {
            critico = Random.Range(1, 10);
            if (critico == 10)
            {
                life1 -= 60;

            }
            else
            {
                life1 -= 30;
            }
            if (life1 <= 0)
            {
                p1.text = "MORREU ";
                p2.text = "VENCEU ";
                Destroy(Pikashu);
            }
           // A.SetInteger,"dA");
            ataque = true;
        }
    }
}
