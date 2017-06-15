using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
    public GameObject uiCanvas1;
    public GameObject uiCanvas2;
    public GameObject vedioPanel;
    // Use this for initialization
    public void StartGameGo () {
        Debug.Log("go");
        Application.LoadLevel("vedio");
    }
	public  void InstructionVisable()
    {
        uiCanvas1.SetActive(false);
        uiCanvas2.SetActive(true);

    }
    public void InstructionVisable1()
    {
        uiCanvas1.SetActive(true);
        uiCanvas2.SetActive(false);

    }
    public void VedioVisable()
    {
        uiCanvas1.SetActive(false);
       vedioPanel.SetActive(true);

    }

    public void InstructionVisable3()
    {
        uiCanvas1.SetActive(true);
        uiCanvas2.SetActive(false);
        vedioPanel.SetActive(false);
    }



}
