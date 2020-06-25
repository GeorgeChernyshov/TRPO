using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrownianMotionSimulation
{
    public partial class BrownianMotionForm : Form
    {
        /// <summary>
        /// Кисть
        /// </summary>
        private SolidBrush _brush;

        /// <summary>
        /// Логика симуляции
        /// </summary>
        private SimulationLogic _logic;

        /// <summary>
        /// Информация о молекулах
        /// </summary>
        private List<dynamic> _moleculeInfo;
        
        public BrownianMotionForm()
        {
            InitializeComponent();
            _brush = new SolidBrush(Color.Blue);
            _logic = new SimulationLogic((float)simulationPanel.Width, (float)simulationPanel.Height);
            _logic.CreateMolecule();
            _logic.Speed = speedTrack.Value;
            _moleculeInfo = new List<dynamic>();
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
        }

        private void simulationPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach(var molecule in _moleculeInfo)
                e.Graphics.FillEllipse(_brush, molecule.X, molecule.Y, molecule.Diameter, molecule.Diameter);
        }

        private void speedTrack_Scroll(object sender, EventArgs e) => _logic.Speed = speedTrack.Value;

        private void repaintTimer_Tick(object sender, EventArgs e)
        {
            var list = new List<dynamic>();
            foreach (var molecule in _logic.Molecules)
            {
                lock (molecule)
                {
                    list.Add(new
                    {
                        X = molecule.X,
                        Y = molecule.Y,
                        Diameter = molecule.Diameter
                    });
                }
            }

            _moleculeInfo = list;
            simulationPanel.Invalidate();
        }

        private void BrownianMotionForm_Load(object sender, EventArgs e)
        {
            repaintTimer.Start();
        }

        private void moleculeNumberTrack_Scroll(object sender, EventArgs e) => _logic.SetMoleculeCount(moleculeNumberTrack.Value);

        private void simulationPanel_SizeChanged(object sender, EventArgs e)
        {
            _logic.Width = (float)simulationPanel.Width;
            _logic.Height = (float)simulationPanel.Height;
        }
    }
}
