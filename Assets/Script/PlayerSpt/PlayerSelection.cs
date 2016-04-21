using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour {

    public GameObject plyer;        /// Adding the player to the game
    public Text plname, plGender;  /// player name and gender
    bool MrF = true;               ////// female r male; 
    GUIText plInput;
     

	// Use this for initialization
	void Start () {


        Destroy(plyer);

        plGender = plGender.GetComponent<Text>();
        //plInput = 

    }

    public GameObject Createplayer(GameObject plCreate)
    {
        plCreate = Instantiate(plCreate);
        return plCreate;
    }


    public void playerinfo(string name)
    {

        plname.text = plInput.text;


            if(MrF = true)
        {

            plGender.text.Insert(0, "Male");
        }
        else
        {
            plGender.text.Insert(0, "Female");
        }


    }

    public void KartSelection()
    {

    }
}
