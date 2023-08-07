namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.ComponentModel;
  using System.Windows.Forms;
  using DOTR_MODDING_TOOL.Classes;

  public partial class MainForm : Form
  {
    #region Map
    Terrain selectedTile = Terrain.NORMAL;
    DotrMap currentMap;
    private bool isClickAndDrag = false;
    bool haveMapsLoaded = false;
    #endregion

    private void dOTRMapEditorToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/rjoken/DOTRMap");
    }

    private void btnLoadDefaultMaps_Click(object sender, EventArgs e)
    {
      LoadDefaultMaps();
    }

    private void splitContainer4_Panel2_MouseDown(object sender, MouseEventArgs e)
    {
      // Determine the clicked tile based on the mouse position
      for (int i = 0; i < currentMap.tiles.Length; i++)
      {
        MapTile tile = currentMap.tiles[i];
        if (tile.GetRect().Contains(e.Location))
        {
          isClickAndDrag = true;
          break;
        }
      }
    }

    private void MapEditor_MouseMove(object sender, MouseEventArgs e)
    {
      for (int i = 0; i < currentMap.tiles.Length; i++)
      {
        if (currentMap.GetTile(i).GetRect().Contains(e.Location))
        {
          currentMap.SetTileHovered(i, true);
        }
        else
        {
          currentMap.SetTileHovered(i, false);
        }
      }
      if (e.Button == MouseButtons.Left)
      {
        if (isClickAndDrag)
        {
          // Update the image of the tiles as the mouse moves over them
          for (int i = 0; i < currentMap.tiles.Length; i++)
          {
            MapTile tile = currentMap.tiles[i];
            if (tile.GetRect().Contains(e.Location))
            {

              currentMap.SetTile(i, selectedTile);
            }
          }
        }
      }
      if (e.Button == MouseButtons.Right)
      {
        if (isClickAndDrag)
        {
          // Update the image of the tiles as the mouse moves over them
          for (int i = 0; i < currentMap.tiles.Length; i++)
          {
            MapTile tile = currentMap.tiles[i];
            if (tile.GetRect().Contains(e.Location))
            {

              currentMap.SetTile(i, Terrain.NORMAL);
            }
          }
        }
      }
    }

    private void SaveMaps()
    {
      dataAccess.SaveMaps();
    }

    private void PictureBox_Click(object sender, EventArgs e)
    {
      PictureBox clickedPictureBox = (PictureBox)sender;
      TableLayoutPanelCellPosition cellPosition = tbPallete.GetCellPosition(clickedPictureBox);
      int column = cellPosition.Column;
      int row = cellPosition.Row;
      int value = row * tbPallete.ColumnCount + column;
      // Do something with the column and row values, such as displaying them
      ChangeSelectedTile((Terrain)value);
    }

    void ChangeSelectedTile(Terrain terrain)
    {
      selectedTile = terrain;
      pbSelectedTile.Image = MapTile.GetImageFromTerrain(terrain);
    }

    private void lbDuelistMaps_SelectedIndexChanged(object sender, EventArgs e)
    {
      currentMap = dataAccess.maps[lbDuelistMaps.SelectedIndex];
      if (lbDuelistMaps.SelectedIndex != -1) // Check if an item is selected
      {
        string selectedText = lbDuelistMaps.Items[lbDuelistMaps.SelectedIndex].ToString();
        lblDotrMap.Text = $"Current Map: {selectedText}";
      }
    }
    private void RefreshEditor_Tick(object sender, EventArgs e)
    {
      scBatzpupEditMapTiles.Panel2.Invalidate();
    }

    private void pbForest_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbWasteland_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbMountain_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbMeadow_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbSea_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbDark_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbToon_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbNormal_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbLab_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }

    private void pbCrush_Click(object sender, EventArgs e)
    {
      PictureBox_Click(sender, e);
    }
    private void EditMap_Paint(object sender, PaintEventArgs e)
    {
      currentMap.Draw(e.Graphics, 75, 75);
    }

    private void MapEditor_MouseUp(object sender, MouseEventArgs e)
    {
      isClickAndDrag = false;
    }

    private void HandleLoadMaps()
    {
      if (!haveMapsLoaded)
      {
        SetDoubleBuffered(scBatzpupEditMapTiles);
        SetDoubleBuffered(scBatzpupEditMapTiles.Panel2);
        RefreshEditor.Interval = 1000 / 60;
        RefreshEditor.Enabled = true;
        scBatzpupEditMapTiles.IsSplitterFixed = true;
        scBatzpupEditMapPallete.IsSplitterFixed = true;
        scBatzpupEditDuelMapSelect.IsSplitterFixed = true;
        dataAccess.LoadMapsFromIso();
        currentMap = dataAccess.maps[0];
        lbDuelistMaps.SelectedIndex = 0;
        haveMapsLoaded = true;
      }
    }

    private void LoadDefaultMaps()
    {
      for (int i = 0; i < dataAccess.maps.Length; i++)
      {
        dataAccess.maps[i] = new DotrMap(VanillaMapBytes.Maps[i]);
      }
      currentMap = dataAccess.maps[0];
      lbDuelistMaps.SelectedIndex = 0;
    }

    private void mapEditorSaveButton_Click(object sender, EventArgs e)
    {
      SaveMaps();
    }
  }
}
