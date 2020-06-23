using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPalette
{
    public partial class ColorPaletteForm : Form
    {
        /// <summary>
        /// Цветовая палитра
        /// </summary>
        public ColorPaletteForm()
        {
            InitializeComponent();
            Repaint();
        }

        /// <summary>
        /// Перекраска цветной панели
        /// </summary>
        private void Repaint()
        {
            Clipboard.SetText(
                String.Format("#{0}{1}{2}",
                    redBar.Value.ToString("X2"),
                    greenBar.Value.ToString("X2"),
                    blueBar.Value.ToString("X2")
                )
            );

            colorPanel.BackColor = ColorTranslator.FromHtml(Clipboard.GetText());
            colorTooltip.SetToolTip(colorPanel, Clipboard.GetText());
        }

        private void redBar_Scroll(object sender, EventArgs e) => Repaint();
        private void greenBar_Scroll(object sender, EventArgs e) => Repaint();
        private void blueBar_Scroll(object sender, EventArgs e) => Repaint();
    }
}
