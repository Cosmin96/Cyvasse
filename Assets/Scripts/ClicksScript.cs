using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ClicksScript : MonoBehaviour {


    TileInfoScript mTIS;  


    // Use this for initialization
    void Start () {
        mTIS = GameObject.Find("InfoKeeper").GetComponent<TileInfoScript>();

        //initializing texture dictionary
        {
            mTIS.mNameTex = new Dictionary<string, Texture>();

            Texture lTexture;

            lTexture = GameObject.Find("ForestTile").GetComponent<RawImage>().texture;
            mTIS.mNameTex["Forest"] = lTexture;

            lTexture = GameObject.Find("FortressTile").GetComponent<RawImage>().texture;
            mTIS.mNameTex["Fortress"] = lTexture;

            lTexture = GameObject.Find("GrassTile").GetComponent<RawImage>().texture;
            mTIS.mNameTex["Grass"] = lTexture;

            lTexture = GameObject.Find("MountainTile").GetComponent<RawImage>().texture;
            mTIS.mNameTex["Mountain"] = lTexture;

            lTexture = GameObject.Find("WaterTile").GetComponent<RawImage>().texture;
            mTIS.mNameTex["Water"] = lTexture;

            lTexture = GameObject.Find("NoTile").GetComponent<RawImage>().texture;
            mTIS.mNameTex["No"] = lTexture;
        }

        //initializing button dictionary
        {
            mTIS.mNameButton = new Dictionary<string, Button>();

            Button lButton;

            lButton = getButtonByName("ForestButton");
            mTIS.mNameButton["Forest"] = lButton;

            lButton = getButtonByName("FortressButton");
            mTIS.mNameButton["Fortress"] = lButton;

            lButton = getButtonByName("GrassButton");
            mTIS.mNameButton["Grass"] = lButton;

            lButton = getButtonByName("MountainButton");
            mTIS.mNameButton["Mountain"] = lButton;

            lButton = getButtonByName("WaterButton");
            mTIS.mNameButton["Water"] = lButton;

            lButton = getButtonByName("NoButton");
            mTIS.mNameButton["No"] = lButton;
        }

        mTIS.mCurrentTile = "No";
        mTIS.mNameButton[mTIS.mCurrentTile].interactable = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private Button getButtonByName(string pName)
    {
        return GameObject.Find(pName).GetComponent<Button>();
    }

    private void switchButton(string pTileName)
    {
        mTIS.mNameButton[mTIS.mCurrentTile].interactable = true;
        mTIS.mCurrentTile = pTileName;
        mTIS.mNameButton[mTIS.mCurrentTile].interactable = false;
    }

    public void ForestClick()
    {
        switchButton("Forest");
    }

    public void FortressClick()
    {
        switchButton("Fortress");
    }

    public void GrassClick()
    {
        switchButton("Grass");
    }

    public void MountainClick()
    {
        switchButton("Mountain");
    }

    public void WaterClick()
    {
        switchButton("Water");
    }

    public void NoClick()
    {
        switchButton("No");
    }
}
