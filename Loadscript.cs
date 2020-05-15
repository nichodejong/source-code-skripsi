using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoSkoliosis()
    {
        Application.LoadLevel("descriptionscoliosis");
    }
    public void Gotokifosis()
    {
        Application.LoadLevel("descriprionkifosis");
    }
    public void Gotolordosis()
    {
        Application.LoadLevel("descriptionlordosis");
    }

    public void Gotobackmainmenu()
    {
        Application.LoadLevel("SampleScene");
    }
    public void Gotovideoskoliosis()
    {
        Application.LoadLevel("videoskoliosis");
    }

    public void Gotovideokifosis()
    {
        Application.LoadLevel("videokifosis");
    }

    public void Gotovideolordosis()
    {
        Application.LoadLevel("videolordosis");
    }
    public void objectskoliosis()
    {
        Application.LoadLevel("skoliosisvirtual");
    }
    public void objectkifosis()
    {
        Application.LoadLevel("kifosisvirtual");
    }
    public void objectlordosis()
    {
        Application.LoadLevel("lordosisvirtual");
    }



}
