using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameboardObject : MonoBehaviour
{
    #region fields
    private Gameboard gameboard;
    #endregion

    #region monobehaviour
    // Start is called before the first frame update
    void Start()
    {
        gameboard = new Gameboard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region public methods
    public void Reroll()
    {
        Debug.Log("Rerolling Board...");
        gameboard.GenerateSolution();
        gameboard.PrintSolution();
    }
    #endregion

}