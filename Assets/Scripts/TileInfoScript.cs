using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TileInfoScript : MonoBehaviour {

    public Dictionary<string, int> mNameCount; //how many tiles string can be still used
    public Dictionary<string, Button> mNameButton;
    public Dictionary<string, Texture> mNameTex;

    public string mCurrentTile;
    public string[][] mBoardTiles;

    // Use this for initialization
    void Start () {

        mNameCount = new Dictionary<string, int>();

        mBoardTiles = new string[8][];
        for (int l = 0; l < 8; l++)
        {
            mBoardTiles[l] = new string[8];
            for (int c=0;c<8;c++)
            {
                mBoardTiles[l][c] = "No";
            }
        }

        mNameCount["Forest"] = 6;
        mNameCount["Fortress"] = 1;
        mNameCount["Grass"] = 14;
        mNameCount["Mountain"] = 6;
        mNameCount["Water"] = 5;
        mNameCount["No"] = 1;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void processClick(string pLC)
    {
        int lLine = pLC[0] - '0';
        int lColumn = pLC[1] - '0';

        string lClicked = mBoardTiles[lLine][lColumn];
        mNameCount[lClicked]++;
        mNameButton[lClicked].GetComponentInChildren<Text>().text = lClicked + " (" + mNameCount[lClicked] + ")";
        if (mNameCount[lClicked] == 1)
        {
            mNameButton[lClicked].interactable = true;
        }
        mBoardTiles[lLine][lColumn] = mCurrentTile;
        mNameCount[mCurrentTile]--;
        mNameButton[mCurrentTile].GetComponentInChildren<Text>().text = mCurrentTile + " (" + mNameCount[mCurrentTile] + ")";
        if (mNameCount[mCurrentTile]==0)
        {
            mNameButton[mCurrentTile].interactable = false;
            mCurrentTile = "No";
            mNameButton[mCurrentTile].interactable = false;
        }
    }
}
