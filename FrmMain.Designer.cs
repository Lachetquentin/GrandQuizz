namespace GrandQuizz
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tBReponse = new System.Windows.Forms.TextBox();
            this.btChanger = new System.Windows.Forms.Button();
            this.lbDevine = new System.Windows.Forms.Label();
            this.lbpoints = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btCredits = new System.Windows.Forms.Button();
            this.questionOrder = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBReponse
            // 
            this.tBReponse.Location = new System.Drawing.Point(12, 530);
            this.tBReponse.Name = "tBReponse";
            this.tBReponse.Size = new System.Drawing.Size(765, 20);
            this.tBReponse.TabIndex = 2;
            this.tBReponse.TextChanged += new System.EventHandler(this.checkAnswer);
            // 
            // btChanger
            // 
            this.btChanger.Location = new System.Drawing.Point(252, 565);
            this.btChanger.Name = "btChanger";
            this.btChanger.Size = new System.Drawing.Size(300, 56);
            this.btChanger.TabIndex = 3;
            this.btChanger.Text = "Changer";
            this.btChanger.UseVisualStyleBackColor = true;
            this.btChanger.Click += new System.EventHandler(this.btChanger_Click);
            // 
            // lbDevine
            // 
            this.lbDevine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevine.Location = new System.Drawing.Point(12, 9);
            this.lbDevine.Name = "lbDevine";
            this.lbDevine.Size = new System.Drawing.Size(765, 26);
            this.lbDevine.TabIndex = 4;
            this.lbDevine.Text = "D\'ou ça vient ?";
            this.lbDevine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbpoints
            // 
            this.lbpoints.AutoSize = true;
            this.lbpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpoints.Location = new System.Drawing.Point(8, 570);
            this.lbpoints.Name = "lbpoints";
            this.lbpoints.Size = new System.Drawing.Size(94, 24);
            this.lbpoints.TabIndex = 5;
            this.lbpoints.Text = "Score : 0";
            this.lbpoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(642, 579);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(60, 24);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "00:60";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCredits
            // 
            this.btCredits.Location = new System.Drawing.Point(12, 597);
            this.btCredits.Name = "btCredits";
            this.btCredits.Size = new System.Drawing.Size(101, 24);
            this.btCredits.TabIndex = 7;
            this.btCredits.Text = "Crédits";
            this.btCredits.UseVisualStyleBackColor = true;
            this.btCredits.Click += new System.EventHandler(this.BtCredits_Click);
            // 
            // questionOrder
            // 
            this.questionOrder.AutoSize = true;
            this.questionOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionOrder.Location = new System.Drawing.Point(8, 35);
            this.questionOrder.Name = "questionOrder";
            this.questionOrder.Size = new System.Drawing.Size(0, 24);
            this.questionOrder.TabIndex = 8;
            this.questionOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 627);
            this.Controls.Add(this.questionOrder);
            this.Controls.Add(this.btCredits);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbpoints);
            this.Controls.Add(this.lbDevine);
            this.Controls.Add(this.btChanger);
            this.Controls.Add(this.tBReponse);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Grand Quizz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBReponse;
        private System.Windows.Forms.Button btChanger;
        private System.Windows.Forms.Label lbDevine;
        private System.Windows.Forms.Label lbpoints;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btCredits;
        private System.Windows.Forms.Label questionOrder;
    }
}

