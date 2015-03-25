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
using CCT.NUI.Core.Shape;
using CCT.NUI.Core.Video;
using CCT.NUI.Core.OpenNI;
using CCT.NUI.HandTracking;
using CCT.NUI.KinectSDK;
using CCT.NUI.Touch;


namespace _21Maret_Finger
{
    public partial class MainForm : Form
    {
        private IList<IDataSource> activeDataSources;
        private IDataSourceFactory dataSourceFactory;
        private IHandDataSource handDataSource;

        private ClusterDataSourceSettings clusteringSettings = new ClusterDataSourceSettings();
        private ShapeDataSourceSettings shapeSettings = new ShapeDataSourceSettings();
        private HandDataSourceSettings handDetectionSettings = new HandDataSourceSettings();

        private int fingerPointCount;
        private HandCollection currentData = new HandCollection();
 
        public MainForm()
        {
            InitializeComponent();
            this.activeDataSources = new List<IDataSource>();
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            this.ActivateKinect();
            this.SetImageDataSource(this.dataSourceFactory.CreateDepthBitmapDataSource());
            this.SetHandTrackingDataSource(new HandDataSource(this.dataSourceFactory.CreateShapeDataSource(this.clusteringSettings, this.shapeSettings), this.handDetectionSettings));
            //this.FingerCount(new);
        }

        private void ActivateKinect()
        {
            try 
            {
                this.clusteringSettings.MaximumDepthThreshold = 1000;
                this.dataSourceFactory = new SDKDataSourceFactory(useNearMode: false);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonClustering_Click(object sender, EventArgs e)
        {
            this.SetClusterDataSource(this.dataSourceFactory.CreateClusterDataSource(this.clusteringSettings));
            this.clusteringSettings.MergeMinimumDistanceToCluster = 10;
        }

        private void buttonConvexHull_Click(object sender, EventArgs e)
        {
            this.handDetectionSettings.DetectCenterOfPalm = false;
            this.handDetectionSettings.DetectFingerDirection = false;
            this.handDetectionSettings.DetectFingers = false;
            this.SetHandDataSource(new HandDataSource(this.dataSourceFactory.CreateShapeDataSource(this.clusteringSettings, this.shapeSettings), this.handDetectionSettings));
        }

        private void buttonRGB_Click(object sender, EventArgs e)
        {
            this.SetImageDataSource(this.dataSourceFactory.CreateRGBBitmapDataSource());
        }

        private void buttonDepth_Click(object sender, EventArgs e)
        {
            this.SetImageDataSource(this.dataSourceFactory.CreateDepthBitmapDataSource());
        }

        private void buttonHandAndFinger_Click(object sender, EventArgs e)
        {
            this.handDetectionSettings.DetectCenterOfPalm = true;
            this.handDetectionSettings.DetectFingerDirection = true;
            this.handDetectionSettings.DetectFingers = true;
            this.SetHandDataSource(new HandDataSource(this.dataSourceFactory.CreateShapeDataSource(this.clusteringSettings, this.shapeSettings), this.handDetectionSettings));
        }

        private void buttonGestureRecognition_Click(object sender, EventArgs e)
        {
            this.handDetectionSettings.DetectCenterOfPalm = true;
            this.handDetectionSettings.DetectFingerDirection = true;
            this.handDetectionSettings.DetectFingers = true;
            this.SetImageDataSource(this.dataSourceFactory.CreateDepthBitmapDataSource());           
            this.SetHandTrackingDataSource(new HandDataSource(this.dataSourceFactory.CreateShapeDataSource(this.clusteringSettings, this.shapeSettings), this.handDetectionSettings));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Clear();
            if (this.dataSourceFactory != null)
            {
                this.dataSourceFactory.Dispose();
            }
        }

        private void Clear()
        {
            foreach (var dataSource in this.activeDataSources)
            {
                dataSource.Stop();
            }
            this.activeDataSources.Clear();
            this.videoControl.Clear();
        }

        void layer_RequestRefresh(object sender, EventArgs e)
        {
            this.videoControl.Invalidate();
        }

        private void SetClusterDataSource(IClusterDataSource dataSource)
        {
            this.SetDataSource(dataSource, new ClusterLayer(dataSource));
        }

        private void SetHandDataSource(IHandDataSource dataSource)
        {
            this.SetDataSource(dataSource, new HandLayer(dataSource));
        }

        private void SetDataSource(IDataSource dataSource, ILayer layer)
        {
            this.Clear();
            this.activeDataSources.Add(dataSource);
            this.videoControl.AddLayer(layer);
            dataSource.Start();
        }

        private void SetHandTrackingDataSource(IHandDataSource dataSource)
        {
            this.SetTrackingDataSource(dataSource, new HandLayer(dataSource));
        }

        private void SetTrackingDataSource(IDataSource dataSource, ILayer layer)
        {
            this.activeDataSources.Add(dataSource);
            this.videoControl.AddLayer(layer);
            dataSource.Start();
        }

        private void SetImageDataSource(IBitmapDataSource dataSource)
        {
            this.Clear();
            this.activeDataSources.Add(dataSource);
            this.videoControl.SetImageSource(dataSource);
            dataSource.Start();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
        }

        private void FingerCount(HandCollection data)
        {
            for(int index=0; index < data.Count; index++)
            {
                var hand = data.Hands[index];
                this.labelFingerCount.Text = hand.FingerCount.ToString(); 
            }                               
        }
        
        void handDataSource_NewDataAvailable(HandCollection data)
        {
            this.labelFingerCount.Text = data.Count.ToString();
        }
    }
}
