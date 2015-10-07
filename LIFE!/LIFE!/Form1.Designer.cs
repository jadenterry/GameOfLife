namespace LIFE_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nextGenButton = new System.Windows.Forms.Button();
            this.theWorld = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playButton = new System.Windows.Forms.Button();
            this.popLabel = new System.Windows.Forms.Label();
            this.genNumLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.resizeTextbox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadButton = new System.Windows.Forms.Button();
            this.speedBar = new System.Windows.Forms.HScrollBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.resizeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wrapOrFallLabel = new System.Windows.Forms.Label();
            this.gridBox = new System.Windows.Forms.CheckBox();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.nextGen = new System.Windows.Forms.Button();
            this.mirrorButton = new System.Windows.Forms.Button();
            this.mirror2Button = new System.Windows.Forms.Button();
            this.presetShapesLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.theWorld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // nextGenButton
            // 
            this.nextGenButton.Location = new System.Drawing.Point(653, 89);
            this.nextGenButton.Name = "nextGenButton";
            this.nextGenButton.Size = new System.Drawing.Size(75, 23);
            this.nextGenButton.TabIndex = 1;
            this.nextGenButton.Text = "Next";
            this.nextGenButton.UseVisualStyleBackColor = true;
            // 
            // theWorld
            // 
            this.theWorld.BackColor = System.Drawing.Color.White;
            this.theWorld.Location = new System.Drawing.Point(85, 31);
            this.theWorld.Name = "theWorld";
            this.theWorld.Size = new System.Drawing.Size(690, 690);
            this.theWorld.TabIndex = 2;
            this.theWorld.TabStop = false;
            this.theWorld.Paint += new System.Windows.Forms.PaintEventHandler(this.theWorld_Paint_1);
            this.theWorld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.theWorld_MouseClick);
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(810, 49);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // popLabel
            // 
            this.popLabel.AutoSize = true;
            this.popLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popLabel.Location = new System.Drawing.Point(807, 302);
            this.popLabel.Name = "popLabel";
            this.popLabel.Size = new System.Drawing.Size(52, 17);
            this.popLabel.TabIndex = 4;
            this.popLabel.Text = "label1";
            // 
            // genNumLabel
            // 
            this.genNumLabel.AutoSize = true;
            this.genNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genNumLabel.Location = new System.Drawing.Point(807, 319);
            this.genNumLabel.Name = "genNumLabel";
            this.genNumLabel.Size = new System.Drawing.Size(52, 17);
            this.genNumLabel.TabIndex = 5;
            this.genNumLabel.Text = "label2";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(807, 336);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(52, 17);
            this.sizeLabel.TabIndex = 6;
            this.sizeLabel.Text = "label1";
            // 
            // resizeTextbox
            // 
            this.resizeTextbox.Location = new System.Drawing.Point(810, 182);
            this.resizeTextbox.Name = "resizeTextbox";
            this.resizeTextbox.Size = new System.Drawing.Size(75, 20);
            this.resizeTextbox.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(810, 89);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(810, 231);
            this.speedBar.Maximum = 500;
            this.speedBar.Minimum = 50;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(156, 17);
            this.speedBar.TabIndex = 11;
            this.speedBar.Value = 50;
            this.speedBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedBar_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(862, 205);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(54, 17);
            this.speedLabel.TabIndex = 12;
            this.speedLabel.Text = "Speed";
            // 
            // resizeButton
            // 
            this.resizeButton.Location = new System.Drawing.Point(909, 179);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(75, 23);
            this.resizeButton.TabIndex = 15;
            this.resizeButton.Text = "Resize";
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(909, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Wrap-Around",
            "Fall Off"});
            this.comboBox1.Location = new System.Drawing.Point(810, 268);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wrapOrFallLabel
            // 
            this.wrapOrFallLabel.AutoSize = true;
            this.wrapOrFallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrapOrFallLabel.Location = new System.Drawing.Point(825, 248);
            this.wrapOrFallLabel.Name = "wrapOrFallLabel";
            this.wrapOrFallLabel.Size = new System.Drawing.Size(124, 17);
            this.wrapOrFallLabel.TabIndex = 20;
            this.wrapOrFallLabel.Text = "Wrap or Fall Off";
            // 
            // gridBox
            // 
            this.gridBox.AutoSize = true;
            this.gridBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridBox.Location = new System.Drawing.Point(828, 152);
            this.gridBox.Name = "gridBox";
            this.gridBox.Size = new System.Drawing.Size(121, 21);
            this.gridBox.TabIndex = 21;
            this.gridBox.Text = "Remove Grid";
            this.gridBox.UseVisualStyleBackColor = true;
            this.gridBox.CheckedChanged += new System.EventHandler(this.gridBox_CheckedChanged);
            // 
            // resetButton1
            // 
            this.resetButton1.Location = new System.Drawing.Point(906, 49);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(75, 23);
            this.resetButton1.TabIndex = 22;
            this.resetButton1.Text = "Clear";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click_1);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(807, 397);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(174, 41);
            this.colorButton.TabIndex = 23;
            this.colorButton.Text = "Change Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // nextGen
            // 
            this.nextGen.Location = new System.Drawing.Point(810, 123);
            this.nextGen.Name = "nextGen";
            this.nextGen.Size = new System.Drawing.Size(171, 23);
            this.nextGen.TabIndex = 24;
            this.nextGen.Text = "Next Generation";
            this.nextGen.UseVisualStyleBackColor = true;
            this.nextGen.Click += new System.EventHandler(this.nextGen_Click);
            // 
            // mirrorButton
            // 
            this.mirrorButton.Location = new System.Drawing.Point(903, 367);
            this.mirrorButton.Name = "mirrorButton";
            this.mirrorButton.Size = new System.Drawing.Size(78, 24);
            this.mirrorButton.TabIndex = 25;
            this.mirrorButton.Text = "Mirror X Axis";
            this.mirrorButton.UseVisualStyleBackColor = true;
            this.mirrorButton.Click += new System.EventHandler(this.mirrorButton_Click);
            // 
            // mirror2Button
            // 
            this.mirror2Button.Location = new System.Drawing.Point(807, 368);
            this.mirror2Button.Name = "mirror2Button";
            this.mirror2Button.Size = new System.Drawing.Size(75, 23);
            this.mirror2Button.TabIndex = 26;
            this.mirror2Button.Text = "Mirror Y Axis";
            this.mirror2Button.UseVisualStyleBackColor = true;
            this.mirror2Button.Click += new System.EventHandler(this.mirror2Button_Click);
            // 
            // presetShapesLabel
            // 
            this.presetShapesLabel.AutoSize = true;
            this.presetShapesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetShapesLabel.Location = new System.Drawing.Point(825, 454);
            this.presetShapesLabel.Name = "presetShapesLabel";
            this.presetShapesLabel.Size = new System.Drawing.Size(119, 17);
            this.presetShapesLabel.TabIndex = 27;
            this.presetShapesLabel.Text = "Preset Shapes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 483);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 47);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(806, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 83);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(887, 536);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 83);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(798, 625);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 69);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(887, 625);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(110, 69);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(993, 726);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.presetShapesLabel);
            this.Controls.Add(this.mirror2Button);
            this.Controls.Add(this.mirrorButton);
            this.Controls.Add(this.nextGen);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.gridBox);
            this.Controls.Add(this.wrapOrFallLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.resizeTextbox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.genNumLabel);
            this.Controls.Add(this.popLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.theWorld);
            this.Controls.Add(this.nextGenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.theWorld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextGenButton;
        private System.Windows.Forms.PictureBox theWorld;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label popLabel;
        private System.Windows.Forms.Label genNumLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox resizeTextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.HScrollBar speedBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label wrapOrFallLabel;
        private System.Windows.Forms.CheckBox gridBox;
        private System.Windows.Forms.Button resetButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button nextGen;
        private System.Windows.Forms.Button mirrorButton;
        private System.Windows.Forms.Button mirror2Button;
        private System.Windows.Forms.Label presetShapesLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

