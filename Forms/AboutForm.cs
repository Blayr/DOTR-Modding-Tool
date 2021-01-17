using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTR_MODDING_TOOL.Forms
{
  public partial class AboutForm : Form
  {
    public AboutForm()
    {
      InitializeComponent();
      setDynamicLabels();
    }

    private void setDynamicLabels()
    {
      AssemblyName assemblyName = Assembly.GetCallingAssembly().GetName();
      toolNameLabel.Text = assemblyName.Name;
      versionNumberLabel.Text = $"Version {assemblyName.Version}";
    }

    private void authorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      authorLinkLabel.LinkVisited = true;
      System.Diagnostics.Process.Start("https://github.com/Blayr");
    }
  }
}
