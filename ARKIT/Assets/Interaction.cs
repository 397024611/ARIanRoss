using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour {
    public GameObject Player, Screen;
    public GameObject CheckPoint1, CheckPoint2,path2male, path2conf,path2indicator;
    private float D1,D2;
    public Text INDI;
    private bool ScreenShown;



	// Use this for initialization
	void Start () {
        Screen.SetActive(false);
        path2indicator.SetActive(true);
        ScreenShown = false;
    }
	
	// Update is called once per frame
	void Update () {
        D1 = DistanceBPandC(Player, CheckPoint1);
        D2 = DistanceBPandC(Player, CheckPoint2);
        INDI.text = D1.ToString() +"  "+ D2.ToString();

        if (D1 <= 2f && ScreenShown == false)
        {
            Screen.SetActive(true);
            ScreenShown = true;
        }
        else if ((D2 <= 3f && ScreenShown == false))
        {
            Screen.SetActive(true);
            ScreenShown = true;
        }
        else if (D1 > 2f && D2 > 3f)
        {
            Screen.SetActive(false);
            ScreenShown = false;
        }
    }

    public float DistanceBPandC(GameObject A, GameObject B)
    {
        float distance = Vector3.Distance(A.transform.position, B.transform.position);
        return distance;
    }
    public void Click2male()
    {
        path2male.SetActive(true);
        path2conf.SetActive(false);
        path2indicator.SetActive(false);
        Screen.SetActive(false);
        ScreenShown = true;
    }
    public void Click2conf()
    {
        path2conf.SetActive(true);
        path2male.SetActive(false);
        path2indicator.SetActive(false);
        Screen.SetActive(false);
        ScreenShown = true;
    }
}
