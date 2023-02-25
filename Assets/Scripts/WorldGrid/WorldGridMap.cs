using System;
using UnityEngine;

namespace WorldGrid
{
    public class WorldGridMap : MonoBehaviour
    {

        [SerializeField] private int width;
        [SerializeField] private int height;
        private GridCell[] allCells;
        
        private void Start()
        {
            allCells = new GridCell[width * height];
            for (int i = 0; i < height; i++)
            {


            }

            print("Sveiki");
        }

        public void GetCellAt(int x, int y)
        {
            
        }

        private void Update()
        {

        }
    }
}