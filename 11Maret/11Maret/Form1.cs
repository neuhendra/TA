using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using CCT.NUI.Visual;
using CCT.NUI.Core;
using CCT.NUI.Core.Clustering;
using CCT.NUI.HandTracking;
using CCT.NUI.Core.OpenNI;
using CCT.NUI.Core.Shape;
using CCT.NUI.KinectSDK;
using CCT.NUI.Core.Video;

namespace _11Maret
{
    public partial class Form1 : Form
    {
        private IList<IDataSource> activeDataSources;
        private IDataSourceFactory dataSourceFactory;

        private ClusterDataSourceSettings clusteringSetting = new ClusterDataSourceSettings();
        private ShapeDataSourceSettings shapeSettings = new ShapeDataSourceSettings();
        private HandDataSourceSettings handDetectionSettings = new HandDataSourceSettings();
        public Form1()
        {
            InitializeComponent();
            this.activeDataSources = new List<IDataSource>();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Clear();
            if (this.dataSourceFactory != null)
            {
                this.dataSourceFactory.Dispose();
            }
        }
		
		private void coba ()
		{
		}
		
        private void SetDataSource(IDataSource dataSource, ILayer layer)
        {
            this.Clear();
            this.activeDataSources.Add(dataSource);
            this.videoControl1.AddLayer(layer);
            dataSource.Start();
        }

        private void SetHandDataSource(IHandDataSource dataSource)
        {
            this.SetDataSource(dataSource, new HandLayer(dataSource));
        }

        private void buttonHandAndFinger_Click(object sender, EventArgs e)
        {
            this.SetHandDataSource(new HandDataSource(this.dataSourceFactory.CreateShapeDataSource(this.clusteringSetting, this.shapeSettings), this.handDetectionSettings));
        }

        private void Clear()
        {
            foreach (var dataSource in this.activeDataSources)
            {
                dataSource.Stop();
            }
            this.activeDataSources.Clear();
            this.videoControl1.Clear();
        }

        private void radioButtonKinectWONear_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.clusteringSetting.MaximumDepthThreshold = 1000;
                this.dataSourceFactory = new SDKDataSourceFactory(useNearMode: false);
            }
            catch (Exception exc)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Cursor.Current = Cursors.Default;
        }
        
        /*private void ToggleButtons()
        {
            this.Enable(this.bu)
        }*/

        private void SetEnabled(IEnumerable<Control> controls, bool value)
        {
            foreach (var control in controls)
            {
                control.Enabled = value;
            }
        }

        private void Enable(params Control[] controls)
        {
            this.SetEnabled(controls, true);
        }

        private void Disable(params Control[] controls)
        {
            this.SetEnabled(controls, false);
        }
    }
}
