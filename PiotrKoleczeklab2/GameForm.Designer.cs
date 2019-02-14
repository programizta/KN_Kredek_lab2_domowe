namespace PiotrKoleczeklab1
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelYourHuman = new System.Windows.Forms.Label();
            this.labelYourTanks = new System.Windows.Forms.Label();
            this.labelYourResources = new System.Windows.Forms.Label();
            this.labelEnemyResources = new System.Windows.Forms.Label();
            this.labelEnemyHuman = new System.Windows.Forms.Label();
            this.labelEnemyTanks = new System.Windows.Forms.Label();
            this.textBoxYourHuman = new System.Windows.Forms.TextBox();
            this.textBoxYourTanks = new System.Windows.Forms.TextBox();
            this.textBoxEnemyHuman = new System.Windows.Forms.TextBox();
            this.textBoxEnemyTanks = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonCallSupport = new System.Windows.Forms.Button();
            this.buttonCallArtillery = new System.Windows.Forms.Button();
            this.labelYourPlanes = new System.Windows.Forms.Label();
            this.labelEnemyPlanes = new System.Windows.Forms.Label();
            this.textBoxYourPlanes = new System.Windows.Forms.TextBox();
            this.textBoxEnemyPlanes = new System.Windows.Forms.TextBox();
            this.buttonCallPlaneSupport = new System.Windows.Forms.Button();
            this.timerDecPlayerTankRes = new System.Windows.Forms.Timer(this.components);
            this.timerDecPlayerFlyRes = new System.Windows.Forms.Timer(this.components);
            this.timerDecEnHumRes = new System.Windows.Forms.Timer(this.components);
            this.timerDecEnTankRes = new System.Windows.Forms.Timer(this.components);
            this.timerDecPlayerHumRes = new System.Windows.Forms.Timer(this.components);
            this.timerDecEnFlyRes = new System.Windows.Forms.Timer(this.components);
            this.timerCheckGameResult = new System.Windows.Forms.Timer(this.components);
            this.timerRandomCatastrophy = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelYourHuman
            // 
            this.labelYourHuman.AutoSize = true;
            this.labelYourHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourHuman.Location = new System.Drawing.Point(33, 139);
            this.labelYourHuman.Name = "labelYourHuman";
            this.labelYourHuman.Size = new System.Drawing.Size(144, 20);
            this.labelYourHuman.TabIndex = 0;
            this.labelYourHuman.Text = "Jednostki piechoty:";
            // 
            // labelYourTanks
            // 
            this.labelYourTanks.AutoSize = true;
            this.labelYourTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourTanks.Location = new System.Drawing.Point(33, 209);
            this.labelYourTanks.Name = "labelYourTanks";
            this.labelYourTanks.Size = new System.Drawing.Size(121, 20);
            this.labelYourTanks.TabIndex = 1;
            this.labelYourTanks.Text = "Liczba czołgów:";
            // 
            // labelYourResources
            // 
            this.labelYourResources.AutoSize = true;
            this.labelYourResources.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourResources.Location = new System.Drawing.Point(29, 27);
            this.labelYourResources.Name = "labelYourResources";
            this.labelYourResources.Size = new System.Drawing.Size(249, 45);
            this.labelYourResources.TabIndex = 2;
            this.labelYourResources.Text = "Twoje zasoby:";
            // 
            // labelEnemyResources
            // 
            this.labelEnemyResources.AutoSize = true;
            this.labelEnemyResources.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnemyResources.Location = new System.Drawing.Point(669, 27);
            this.labelEnemyResources.Name = "labelEnemyResources";
            this.labelEnemyResources.Size = new System.Drawing.Size(252, 45);
            this.labelEnemyResources.TabIndex = 3;
            this.labelEnemyResources.Text = "Zasoby wroga:";
            // 
            // labelEnemyHuman
            // 
            this.labelEnemyHuman.AutoSize = true;
            this.labelEnemyHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnemyHuman.Location = new System.Drawing.Point(687, 139);
            this.labelEnemyHuman.Name = "labelEnemyHuman";
            this.labelEnemyHuman.Size = new System.Drawing.Size(144, 20);
            this.labelEnemyHuman.TabIndex = 4;
            this.labelEnemyHuman.Text = "Jednostki piechoty:";
            // 
            // labelEnemyTanks
            // 
            this.labelEnemyTanks.AutoSize = true;
            this.labelEnemyTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnemyTanks.Location = new System.Drawing.Point(687, 212);
            this.labelEnemyTanks.Name = "labelEnemyTanks";
            this.labelEnemyTanks.Size = new System.Drawing.Size(121, 20);
            this.labelEnemyTanks.TabIndex = 5;
            this.labelEnemyTanks.Text = "Liczba czołgów:";
            // 
            // textBoxYourHuman
            // 
            this.textBoxYourHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxYourHuman.Location = new System.Drawing.Point(258, 136);
            this.textBoxYourHuman.Name = "textBoxYourHuman";
            this.textBoxYourHuman.Size = new System.Drawing.Size(132, 26);
            this.textBoxYourHuman.TabIndex = 6;
            // 
            // textBoxYourTanks
            // 
            this.textBoxYourTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxYourTanks.Location = new System.Drawing.Point(258, 206);
            this.textBoxYourTanks.Name = "textBoxYourTanks";
            this.textBoxYourTanks.Size = new System.Drawing.Size(132, 26);
            this.textBoxYourTanks.TabIndex = 8;
            // 
            // textBoxEnemyHuman
            // 
            this.textBoxEnemyHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEnemyHuman.Location = new System.Drawing.Point(912, 136);
            this.textBoxEnemyHuman.Name = "textBoxEnemyHuman";
            this.textBoxEnemyHuman.Size = new System.Drawing.Size(132, 26);
            this.textBoxEnemyHuman.TabIndex = 9;
            // 
            // textBoxEnemyTanks
            // 
            this.textBoxEnemyTanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEnemyTanks.Location = new System.Drawing.Point(912, 206);
            this.textBoxEnemyTanks.Name = "textBoxEnemyTanks";
            this.textBoxEnemyTanks.Size = new System.Drawing.Size(132, 26);
            this.textBoxEnemyTanks.TabIndex = 10;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartGame.Location = new System.Drawing.Point(485, 336);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(116, 44);
            this.buttonStartGame.TabIndex = 11;
            this.buttonStartGame.Text = "Zacznij grę!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonCallSupport
            // 
            this.buttonCallSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCallSupport.Location = new System.Drawing.Point(12, 408);
            this.buttonCallSupport.Name = "buttonCallSupport";
            this.buttonCallSupport.Size = new System.Drawing.Size(370, 33);
            this.buttonCallSupport.TabIndex = 12;
            this.buttonCallSupport.Text = "Wezwij posiłki (uzupełnia straty bitewne)";
            this.buttonCallSupport.UseVisualStyleBackColor = true;
            this.buttonCallSupport.Click += new System.EventHandler(this.buttonCallSupport_Click);
            // 
            // buttonCallArtillery
            // 
            this.buttonCallArtillery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCallArtillery.Location = new System.Drawing.Point(12, 495);
            this.buttonCallArtillery.Name = "buttonCallArtillery";
            this.buttonCallArtillery.Size = new System.Drawing.Size(370, 35);
            this.buttonCallArtillery.TabIndex = 13;
            this.buttonCallArtillery.Text = "Wezwij wsparcie artyleryjskie (niszczy j. naziemne)";
            this.buttonCallArtillery.UseVisualStyleBackColor = true;
            this.buttonCallArtillery.Click += new System.EventHandler(this.buttonCallArtillery_Click);
            // 
            // labelYourPlanes
            // 
            this.labelYourPlanes.AutoSize = true;
            this.labelYourPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourPlanes.Location = new System.Drawing.Point(33, 283);
            this.labelYourPlanes.Name = "labelYourPlanes";
            this.labelYourPlanes.Size = new System.Drawing.Size(139, 20);
            this.labelYourPlanes.TabIndex = 14;
            this.labelYourPlanes.Text = "Liczba samolotów:";
            // 
            // labelEnemyPlanes
            // 
            this.labelEnemyPlanes.AutoSize = true;
            this.labelEnemyPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEnemyPlanes.Location = new System.Drawing.Point(687, 283);
            this.labelEnemyPlanes.Name = "labelEnemyPlanes";
            this.labelEnemyPlanes.Size = new System.Drawing.Size(139, 20);
            this.labelEnemyPlanes.TabIndex = 15;
            this.labelEnemyPlanes.Text = "Liczba samolotów:";
            // 
            // textBoxYourPlanes
            // 
            this.textBoxYourPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxYourPlanes.Location = new System.Drawing.Point(257, 280);
            this.textBoxYourPlanes.Name = "textBoxYourPlanes";
            this.textBoxYourPlanes.Size = new System.Drawing.Size(132, 26);
            this.textBoxYourPlanes.TabIndex = 16;
            // 
            // textBoxEnemyPlanes
            // 
            this.textBoxEnemyPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxEnemyPlanes.Location = new System.Drawing.Point(912, 280);
            this.textBoxEnemyPlanes.Name = "textBoxEnemyPlanes";
            this.textBoxEnemyPlanes.Size = new System.Drawing.Size(132, 26);
            this.textBoxEnemyPlanes.TabIndex = 17;
            // 
            // buttonCallPlaneSupport
            // 
            this.buttonCallPlaneSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCallPlaneSupport.Location = new System.Drawing.Point(12, 447);
            this.buttonCallPlaneSupport.Name = "buttonCallPlaneSupport";
            this.buttonCallPlaneSupport.Size = new System.Drawing.Size(370, 42);
            this.buttonCallPlaneSupport.TabIndex = 18;
            this.buttonCallPlaneSupport.Text = "Wezwij wsparcie lotnicze (niszczy samoloty)";
            this.buttonCallPlaneSupport.UseVisualStyleBackColor = true;
            this.buttonCallPlaneSupport.Click += new System.EventHandler(this.buttonCallPlaneSupport_Click);
            // 
            // timerDecPlayerTankRes
            // 
            this.timerDecPlayerTankRes.Tick += new System.EventHandler(this.timerDecPlayerTankRes_Tick);
            // 
            // timerDecPlayerFlyRes
            // 
            this.timerDecPlayerFlyRes.Tick += new System.EventHandler(this.timerDecPlayerFlyRes_Tick);
            // 
            // timerDecEnHumRes
            // 
            this.timerDecEnHumRes.Tick += new System.EventHandler(this.timerDecEnHumRes_Tick);
            // 
            // timerDecEnTankRes
            // 
            this.timerDecEnTankRes.Tick += new System.EventHandler(this.timerDecEnTankRes_Tick);
            // 
            // timerDecPlayerHumRes
            // 
            this.timerDecPlayerHumRes.Tick += new System.EventHandler(this.timerDecPlayerHumRes_Tick);
            // 
            // timerDecEnFlyRes
            // 
            this.timerDecEnFlyRes.Tick += new System.EventHandler(this.timerDecEnFlyRes_Tick);
            // 
            // timerCheckGameResult
            // 
            this.timerCheckGameResult.Tick += new System.EventHandler(this.timerCheckGameResult_Tick);
            // 
            // timerRandomCatastrophy
            // 
            this.timerRandomCatastrophy.Tick += new System.EventHandler(this.timerRandomCatastrophy_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 542);
            this.Controls.Add(this.buttonCallPlaneSupport);
            this.Controls.Add(this.textBoxEnemyPlanes);
            this.Controls.Add(this.textBoxYourPlanes);
            this.Controls.Add(this.labelEnemyPlanes);
            this.Controls.Add(this.labelYourPlanes);
            this.Controls.Add(this.buttonCallArtillery);
            this.Controls.Add(this.buttonCallSupport);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.textBoxEnemyTanks);
            this.Controls.Add(this.textBoxEnemyHuman);
            this.Controls.Add(this.textBoxYourTanks);
            this.Controls.Add(this.textBoxYourHuman);
            this.Controls.Add(this.labelEnemyTanks);
            this.Controls.Add(this.labelEnemyHuman);
            this.Controls.Add(this.labelEnemyResources);
            this.Controls.Add(this.labelYourResources);
            this.Controls.Add(this.labelYourTanks);
            this.Controls.Add(this.labelYourHuman);
            this.Name = "GameForm";
            this.Text = "Rozgrywka";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYourHuman;
        private System.Windows.Forms.Label labelYourTanks;
        private System.Windows.Forms.Label labelYourResources;
        private System.Windows.Forms.Label labelEnemyResources;
        private System.Windows.Forms.Label labelEnemyHuman;
        private System.Windows.Forms.Label labelEnemyTanks;
        private System.Windows.Forms.TextBox textBoxYourHuman;
        private System.Windows.Forms.TextBox textBoxYourTanks;
        private System.Windows.Forms.TextBox textBoxEnemyHuman;
        private System.Windows.Forms.TextBox textBoxEnemyTanks;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonCallSupport;
        private System.Windows.Forms.Button buttonCallArtillery;
        private System.Windows.Forms.Label labelYourPlanes;
        private System.Windows.Forms.Label labelEnemyPlanes;
        private System.Windows.Forms.TextBox textBoxYourPlanes;
        private System.Windows.Forms.TextBox textBoxEnemyPlanes;
        private System.Windows.Forms.Button buttonCallPlaneSupport;
        private System.Windows.Forms.Timer timerDecPlayerTankRes;
        private System.Windows.Forms.Timer timerDecPlayerFlyRes;
        private System.Windows.Forms.Timer timerDecEnHumRes;
        private System.Windows.Forms.Timer timerDecEnTankRes;
        private System.Windows.Forms.Timer timerDecPlayerHumRes;
        private System.Windows.Forms.Timer timerDecEnFlyRes;
        private System.Windows.Forms.Timer timerCheckGameResult;
        private System.Windows.Forms.Timer timerRandomCatastrophy;
    }
}