using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileClickSensor : MonoBehaviour {

    GameObject mLastClicked;
    TileInfoScript mTIS;

    // Use this for initialization
    void Start ()
    {
        mTIS = GameObject.Find("InfoKeeper").GetComponent<TileInfoScript>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray lRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit lHit;
            if (Physics.Raycast(lRay,out lHit))
            {
                mLastClicked = lHit.collider.gameObject;
                if (mLastClicked.name.StartsWith("Tile"))
                {
                    mLastClicked.GetComponent<Renderer>().material.mainTexture = mTIS.mNameTex[mTIS.mCurrentTile];
                    mTIS.processClick(mLastClicked.name.Substring(4));
                }
            }
        }
    }
}
