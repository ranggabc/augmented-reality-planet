using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deskripsi : MonoBehaviour
{
    [Header("Deskripsi Planet")]
    public TrackableAR[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskripsi;

    [Header("UI Dekkripsi")]
    public Text txtNama;
    public Text txtDeskripsi;
    public GameObject goNama;
    public GameObject goDeskripsi;

    public GameObject Penanda;


    public bool[] cekMarker;
    int countMarker;
    // Start is called before the first frame update
    void Start()
    {
        cekMarker = new bool[tr.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < tr.Length; i++)
        {
            if(tr[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskripsi[i];

                if(!cekMarker[i])
                {
                    countMarker++;
                    cekMarker[i] = true;
                }
            } 
            else
            {
                if(cekMarker[i])
                {
                    countMarker--;
                    cekMarker[i] = false;
                }
            }
        }
        DeskripsiPanel();
    }

    private void DeskripsiPanel()
    {
        if(countMarker == 0)
        {
            goNama.SetActive(false);
            goDeskripsi.SetActive(false);

            Penanda.SetActive(true);
        }
        else
        {
            goNama.SetActive(true);
            goDeskripsi.SetActive(true);

            Penanda.SetActive(false);
        }
    }
}
