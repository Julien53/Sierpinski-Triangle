namespace SierpinskiTriangle
{
    partial class SierpinskiTriangle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SierpinskiTriangle));
            this.canvas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRayon = new System.Windows.Forms.TextBox();
            this.txtLoop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.canvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.canvas.Controls.Add(this.label3);
            this.canvas.Controls.Add(this.label2);
            this.canvas.Controls.Add(this.txtRayon);
            this.canvas.Controls.Add(this.txtLoop);
            this.canvas.Controls.Add(this.label1);
            this.canvas.Location = new System.Drawing.Point(25, 47);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(587, 643);
            this.canvas.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Diametre des points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre d\'itération";
            // 
            // txtRayon
            // 
            this.txtRayon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRayon.Location = new System.Drawing.Point(284, 17);
            this.txtRayon.Name = "txtRayon";
            this.txtRayon.Size = new System.Drawing.Size(100, 20);
            this.txtRayon.TabIndex = 2;
            // 
            // txtLoop
            // 
            this.txtLoop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLoop.Location = new System.Drawing.Point(178, 17);
            this.txtLoop.Name = "txtLoop";
            this.txtLoop.Size = new System.Drawing.Size(100, 20);
            this.txtLoop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 17);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAfficher.Location = new System.Drawing.Point(25, 18);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(288, 23);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEffacer.Location = new System.Drawing.Point(324, 18);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(288, 23);
            this.btnEffacer.TabIndex = 2;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // SierpinskiTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(636, 702);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.canvas);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SierpinskiTriangle";
            this.Text = "SierpinskiTriangle";
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRayon;
        private System.Windows.Forms.TextBox txtLoop;
    }
}

