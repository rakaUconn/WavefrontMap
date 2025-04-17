using System.Drawing.Drawing2D;
using System.Numerics;
using Timer = System.Windows.Forms.Timer;
using HtmlAgilityPack;

namespace WavefrontMap
{
    public partial class Form1 : Form
    {
        private int[,] grid;
        private readonly int gridSize = 100;
        private readonly int cellSize = 5;
        private readonly List<Point> sources = new List<Point>();
        private readonly Timer animationTimer = new Timer();
        private int currentStep = 0;

        private double apertureRadius = 0.0033; // meters
        private double wavelength = 6.3e-7; // meters
        private int numPoints = 256; // resolution
        private double[]? zernikeCoeffs;
        private Bitmap? wavefrontMap;
        private bool displayInWaves = false;
        private double pvValue;
        private double rmsValue;
        private Label? lblPV;
        private Label? lblRMS;
        private PictureBox? pictureBoxMap;

        public Form1()
        {
            InitializeComponent();
            grid = new int[gridSize, gridSize];
            InitializeGrid();
            SetupTimer();

            this.DoubleBuffered = true;
            this.MouseClick += Form1_MouseClick!;
            this.Paint += Form1_Paint!;

            SetupUI();
        }

        // Rest of the Form1.cs code...
    }
}