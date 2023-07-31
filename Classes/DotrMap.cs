using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOTR_Modding_Tool.MainForm;
using System.Windows.Forms;

namespace DOTR_MODDING_TOOL.Classes
{
    public class DotrMap
    {
        public MapTile[] tiles;


        public DotrMap()
        {
            // creates a blank map of all NORMAL
            tiles = new MapTile[49];
            for (int i = 0; i < tiles.Length; i++)
            {
                tiles[i] = new MapTile();
            }
        }

        public DotrMap(byte[] arr)
        {
            // loads a map from a byte array.
            tiles = new MapTile[49];
            for (int i = 0; i < tiles.Length; i++)
            {
                try
                {
                    tiles[i] = new MapTile((Terrain)arr[i]);
                }
                catch
                {
                    MessageBox.Show("The map you loaded was corrupt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public MapTile GetTile(int tilenum)
        {
            if (tilenum > tiles.Length - 1)
            {
                return tiles[tiles.Length - 1];
            }
            else if (tilenum < 0)
            {
                return tiles[0];
            }
            else
            {
                return tiles[tilenum];
            }
        }
        public void SetTile(int tilenum, Terrain t)
        {
            if (tilenum > tiles.Length - 1)
            {
                tiles[tiles.Length - 1].SetTerrain(t);
            }
            else if (tilenum < 0)
            {
                tiles[0].SetTerrain(t);
            }
            else
            {
                tiles[tilenum].SetTerrain(t);
            }
        }

        public void SetTileHovered(int tilenum, bool state)
        {
            if (tilenum > tiles.Length - 1)
            {
                tiles[tiles.Length - 1].SetHovered(state);
            }
            else if (tilenum < 0)
            {
                tiles[0].SetHovered(state);
            }
            else
            {
                tiles[tilenum].SetHovered(state);
            }
        }

        public void Draw(Graphics g, int startx, int starty)
        {
            int x = startx;
            int y = starty;
            for (int i = 0; i < tiles.Length; i++)
            {
                // if divisible by 7, go to new row
                if (i > 0 && i % 7 == 0)
                {
                    x = startx;
                    y += MapTile.tileSize;
                }
                tiles[i].SetRect(x, y);
                tiles[i].Draw(g);
                x += MapTile.tileSize;
            }
        }
    }
}
