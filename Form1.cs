using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandoMix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Random Int
            Resize randomInt = new Resize();
            dynamic[] RandomIntComponents = { randomIntLeft, randomIntCentral, randomIntRight };
            double[] RandomIntPercents = { 0.2, 0.6, 0.2 };
            randomInt.DoIt(tabPageRandomInt, RandomIntComponents, RandomIntPercents, 0, "Horizontal");

            Resize intCentral = new Resize();
            dynamic[] intCentralComponents = { intCentralTop, intCentralBottom};
            double[] intCentralPercents = { 0.70, 0.30};
            intCentral.DoIt(randomIntCentral, intCentralComponents, intCentralPercents, 20, "Vertical");

            Resize intCentralTopObj = new Resize();
            dynamic[] intCentralTopComponents = { intAnswerPanel, intControlPanel };
            double[] intCentralTopPercents = { 0.40, 0.60 };
            intCentralTopObj.DoIt(intCentralTop, intCentralTopComponents, intCentralTopPercents, 10, "Vertical");

            Resize intCentralButtomObj = new Resize();
            dynamic[] intCentralButtomComponents = { intButtonClear, intButtonStart };
            double[] intCentralButtomPercents = { 0.5, 0.5 };
            intCentralButtomObj.DoIt(intCentralBottom, intCentralButtomComponents, intCentralButtomPercents, 10, "Horizontal");
        }
    }
}