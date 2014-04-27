////-- Expander.cs -- ////////////////////////////////////////////////////////
// Projekt-Notfalldusche 2014                                               //
// Die Expander-Klasse dient aus ausklappbarer Container für den Testinhalt.//
// Sie wird dem Accordion als Inhalt zugewiesen.                            //
// von Kevin Morgenthaler, Kjell Ita, Ramon Boss                            //
//////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜberwachungNotfalldusche
{
  public partial class Expander : UserControl
  {
    public event EventHandler StateChanged;
    public event CancelEventHandler StateChanging;
    public bool Expanded { get; private set; }
    private Control header;
    private Control content;
    private int contentHeight = 0;

    public Expander()
    {
      InitializeComponent();
      this.Expanded = true;
    }

    public Control Header
    {
      get { return this.header; }

      set
      {
        if (this.header != null)
          this.Controls.Remove(this.header);

        this.header = value;
        this.header.Dock = DockStyle.Top;
        this.Controls.Add(this.header);
        this.Controls.SetChildIndex(this.header, this.Controls.Count > 1 ? 1 : 0);
      }
    }

    public Control Content
    {
      get { return this.content; }

      set
      {
        if (this.content != null)
          this.Controls.Remove(this.content);

        this.content = value;
        this.Size = new Size(this.Width, this.header.Height + this.content.Height);
        this.content.Top = this.header.Height;

        this.Controls.Add(this.content);
        this.Controls.SetChildIndex(this.content, 0);
      }
    }

    public void Expand()
    {
      if (this.Expanded)
        return;

      if (StateChanging != null)
      {
        CancelEventArgs args = new CancelEventArgs();
        StateChanging(this, args);
        if (args.Cancel)
          return;
      }

      this.Expanded = true;
      ArrangeLayout();

      if (StateChanged != null)
        StateChanged(this, null);
    }

    public void Collapse()
    {
      if (!this.Expanded)
        return;

      if (StateChanging != null)
      {
        CancelEventArgs args = new CancelEventArgs();
        StateChanging(this, args);
        if (args.Cancel)
          return;
      }

      if (this.Content != null)
        this.contentHeight = this.Content.Height;
      this.Expanded = false;
      ArrangeLayout();

      if (StateChanged != null)
        StateChanged(this, null);
    }

    public void Toggle()
    {
      if (this.Expanded)
        Collapse();
      else
        Expand();
    }

    private void ArrangeLayout()
    {
      int h = 0;
      if (this.header != null)
        h += this.header.Height;
      if (this.Expanded && this.content != null)
        h += this.content.Height;
      this.Size = new Size(this.Width, h);
    }
  }

  /// <summary>
  /// Eine Helper-Klasse im Expander um den Header vereinfacht zu erstellen. 
  /// </summary>
  public static class ExpanderHelper
  {
    public static Label CreateLabelHeader(Expander expander, string text, Color backColor, Image collapsedImage = null, Image expandedImage = null, int height = 25, Font font = null)
    {
      Label headerLabel = new Label();
      headerLabel.Text = text;
      headerLabel.AutoSize = false;
      headerLabel.Height = height;
      if (font != null)
        headerLabel.Font = font;
      headerLabel.TextAlign = ContentAlignment.MiddleLeft;
      if (collapsedImage != null && expandedImage != null)
      {
        headerLabel.Image = collapsedImage;
        headerLabel.ImageAlign = ContentAlignment.MiddleRight;
      }
      headerLabel.BackColor = backColor;
      if (collapsedImage != null && expandedImage != null)
      {
        expander.StateChanged += delegate { headerLabel.Image = expander.Expanded ? collapsedImage : expandedImage; };
      }
      headerLabel.Click += delegate { expander.Toggle(); };
      expander.Header = headerLabel;
      return headerLabel;
    }
  }
}
