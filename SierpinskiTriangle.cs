using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Windows;

namespace SierpinskiTriangle
{
    public partial class SierpinskiTriangle : Form
    {
        //Variable membre
        Thread thread;
        bool threadExist =false;
        Graphics myCanvas;
        Random r = new Random();
        float[] pointIni = { 0, 0 };
        float[] deplacementA = { 0, 0 };
        float[] deplacementB = { 0.5f, 0 };
        float[] deplacementC = { 0.25f, ((float)Math.Sqrt(3) / 4) };
        float[,] matrice = { { 0.5f, 0 }, { 0, 0.5f } };
        
        

        public SierpinskiTriangle()
        {
            InitializeComponent();
            myCanvas = canvas.CreateGraphics();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            //Creer un nouvelle thread et la lance si l'ancienne est fermée
            if (!threadExist)
            {
                thread = new Thread(new ThreadStart(dessiner));
                thread.Start(); 
                threadExist = true;
                label1.Text = "Running";
                label1.ForeColor = Color.Red;
            }
        }
        public void dessiner()
        {
            //Variable
            int loop = 0;
            float dia = 0;
            int val;
            float[] deplacement = { };
            if (!int.TryParse(txtLoop.Text, out loop)) { MessageBox.Show("Veuillez entrer un nombre"); }
            if (!float.TryParse(txtRayon.Text, out dia)) { MessageBox.Show("Veuillez entrer un nombre"); }
            SolidBrush brush = new SolidBrush(Color.Red);

            //Loop
            for (int i = 0; i < loop; i++)
            {
                val = r.Next(0, 3);

                //Trouve le deplacement
                switch (val)
                {
                    case 0:
                        deplacement = deplacementA;
                        brush.Color = Color.Blue;
                        break;
                    case 1:
                        deplacement = deplacementB;
                        brush.Color = Color.Red;
                        break;
                    case 2:
                        deplacement = deplacementC;
                        brush.Color = Color.Green;
                        break;
                    default:
                        deplacement = deplacementC;
                        break;
                }

                //Calcule le positionement du point
                pointIni[0] = matrice[0, 0] * pointIni[0] + matrice[0, 1] * pointIni[1] + deplacement[0];
                pointIni[1] = matrice[1, 0] * pointIni[0] + matrice[1, 1] * pointIni[1] + deplacement[1];
                //Dessine le point
                myCanvas.FillEllipse(brush, pointIni[1] * 600, pointIni[0] * 600, dia, dia);
            }
            threadExist = false;
            label1.Text = "";
            return;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            if (!threadExist) { myCanvas.Clear(canvas.BackColor); }
            else { MessageBox.Show("Veuillez attendre la fin du processus"); }
        
        }
        
    }

}
