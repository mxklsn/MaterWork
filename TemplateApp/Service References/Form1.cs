using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGlTemplateApp;

namespace TemplateApp
{
    public partial class Form1 : Form
    {
        /*public static double positionX;
        public static double positionY;*/

        public static bool DxRefresh;

        public static int ChangerX;
        public static int ChangerY;
        public static int ChangerZ;
        public static double StepChanger;
        public static double CoefDepth;

        public static int CountFe;
        public static double[] Points;

        public Form1()
        {
            InitializeComponent();
            var modelCreator = new ModelCreator(new ModelData("../TestCase/test.json"), 0);
            modelCreator.Create();

            Points = modelCreator.Points;
            CountFe = modelCreator.CountFe;

            countOX.Text = modelCreator.CountO[0].ToString();
            countOY.Text = modelCreator.CountO[1].ToString();
            countOZ.Text = modelCreator.CountO[2].ToString();

            CoefDepth = 0.7;
            StepChanger = Convert.ToDouble(stepChanger.Value);
            DxRefresh = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxControl1.Invalidate();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            dxControl1.EnablePaint = true;
            dxControl1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dxControl1.Invalidate();
        }


        private void reMesh_ValueChanged(object sender, EventArgs e)
        {
            var modelCreator = new ModelCreator(new ModelData("../TestCase/test.json"), Convert.ToInt32(reMesh.Value));
            modelCreator.Create();

            Points = modelCreator.Points;
            CountFe = modelCreator.CountFe;

            countOX.Text = modelCreator.CountO[0].ToString();
            countOY.Text = modelCreator.CountO[1].ToString();
            countOZ.Text = modelCreator.CountO[2].ToString();

            StepChanger = Convert.ToDouble(stepChanger.Value);
            DxRefresh = true;
            dxControl1.Refresh();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /* Коэф одного шага */
        private void stepChanger_ValueChanged(object sender, EventArgs e)
        {
            StepChanger = Convert.ToDouble(stepChanger.Value);
            dxControl1.Refresh();
        }

        private void minusX_Click(object sender, EventArgs e)
        {
            ChangerX--;
            dxControl1.Refresh();
        }

        private void plusX_Click(object sender, EventArgs e)
        {
            ChangerX++;
            dxControl1.Refresh();
        }

        private void minusY_Click(object sender, EventArgs e)
        {
            ChangerY--;
            dxControl1.Refresh();
        }

        private void plusY_Click(object sender, EventArgs e)
        {
            ChangerY++;
            dxControl1.Refresh();
        }

        private void minusZ_Click(object sender, EventArgs e)
        {
            ChangerZ--;
            dxControl1.Refresh();
        }

        private void plusZ_Click(object sender, EventArgs e)
        {
            ChangerZ++;
            dxControl1.Refresh();
        }

        private void minusScale_Click(object sender, EventArgs e)
        {
            CoefDepth -= 0.1;
            dxControl1.Refresh();
        }

        private void plusScale_Click(object sender, EventArgs e)
        {
            CoefDepth += 0.1;
            dxControl1.Refresh();
        }
    }
}
