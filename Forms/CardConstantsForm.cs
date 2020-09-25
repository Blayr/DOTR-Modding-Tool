namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Drawing;
  using System.Linq;
  using System.Reflection;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private CardConstants cardConstants;
    private BindingListView<CardConstant> cardConstantsBinding;

    private void LoadCardConstantsData()
    {
      byte[][] cardConstantsBytes = dataAccess.LoadCardConstantData();
      this.cardConstants = new CardConstants(cardConstantsBytes);
      this.cardConstantsBinding = new BindingListView<CardConstant>(this.cardConstants.Constants);
      this.cardConstantsDataGridView.DataSource = cardConstantsBinding;
      this.cardConstantsDataGridView.DefaultCellStyle.Font = new Font("OpenSans", 9.75F, FontStyle.Regular);
    }

    private void cardConstantsFilterTextbox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        this.applyCardConstantSearchFilter();
        e.Handled = true;
        e.SuppressKeyPress = true;
      }
    }

    private void cardConstantsFilterButton_Click(object sender, EventArgs e)
    {
      this.applyCardConstantSearchFilter();
    }

    private void applyCardConstantSearchFilter()
    {
      string searchTerm = this.cardConstantsFilterTextbox.Text.ToLower().Trim();

      if (searchTerm == String.Empty)
      {
        this.cardConstantsBinding.RemoveFilter();
        return;
      }

      this.cardConstantsBinding.ApplyFilter(delegate (CardConstant cardConstant) { return cardConstant.Name.ToLower().Contains(searchTerm); });
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.cardConstantsFilterTextbox.Clear();
      this.cardConstantsBinding.RemoveFilter();
    }

    private void cardConstantsSaveButton_Click(object sender, EventArgs e)
    {
      byte[] cardConstantsBytes = this.cardConstants.Bytes;
      this.dataAccess.SetCardConstantData(cardConstantsBytes);
      this.LoadCardConstantsData();
    }


    private void SetupCardConstantsDataGridView()
    {
      this.cardConstantsDataGridView.AutoGenerateColumns = false;
      this.cardConstantsDataGridView.CellFormatting += this.FormatCardConstantTable;
      this.cardConstantsDataGridView.CellMouseClick += this.handleCardConstantsDataGridViewClick;
      this.cardConstantsContextStrip.Items.Add("Edit selected cards");
    }

    private void handleCardConstantsDataGridViewClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Right) {
        this.cardConstantsContextStrip.Show(Cursor.Position);
      }
    }

    private void FormatCardConstantTable(object sender, DataGridViewCellFormattingEventArgs e)
    {
      DataGridView bro = (DataGridView)sender;
      if (e.ColumnIndex != 1)
      {
        return;
      }

      ushort cardIndex = (ushort)this.cardConstantsDataGridView.Rows[e.RowIndex].Cells[0].Value;
      CardConstant cardConstant = this.cardConstants.Constants[cardIndex];
      Color rowColor;

      switch (cardConstant.CardColor)
      {
        case CardColorType.NormalMonster:
          rowColor = Color.FromArgb(160, 128, 0);
          break;
        case CardColorType.EffectMonster:
          rowColor = Color.FromArgb(160, 80, 0);
          break;
        case CardColorType.Ritual:
          rowColor = Color.FromArgb(81, 102, 141);
          break;
        case CardColorType.Trap:
          rowColor = Color.FromArgb(160, 16, 64);
          break;
        case CardColorType.Magic:
          rowColor = Color.FromArgb(0, 96, 48);
          break;
        default:
          rowColor = Color.FromArgb(160, 128, 0);
          break;
      }

      bro.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
      bro.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
    }
  }
}