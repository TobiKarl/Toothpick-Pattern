namespace Toothpick_patterns
{
    partial class Form
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.tpickLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundColor = new System.Windows.Forms.TextBox();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.newTpickColor = new System.Windows.Forms.TextBox();
            this.tpickColor = new System.Windows.Forms.TextBox();
            this.lblNewTpickColor = new System.Windows.Forms.Label();
            this.lblTpickColor = new System.Windows.Forms.Label();
            this.txtNumOfTpicks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.lblIterations = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpickLength)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.Info;
            this.topPanel.Controls.Add(this.btnReset);
            this.topPanel.Controls.Add(this.tpickLength);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.backgroundColor);
            this.topPanel.Controls.Add(this.lblBackgroundColor);
            this.topPanel.Controls.Add(this.newTpickColor);
            this.topPanel.Controls.Add(this.tpickColor);
            this.topPanel.Controls.Add(this.lblNewTpickColor);
            this.topPanel.Controls.Add(this.lblTpickColor);
            this.topPanel.Controls.Add(this.txtNumOfTpicks);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.txtIterations);
            this.topPanel.Controls.Add(this.lblIterations);
            this.topPanel.Controls.Add(this.btnDraw);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1121, 81);
            this.topPanel.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Location = new System.Drawing.Point(506, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // tpickLength
            // 
            this.tpickLength.Location = new System.Drawing.Point(321, 50);
            this.tpickLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.tpickLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.tpickLength.Name = "tpickLength";
            this.tpickLength.Size = new System.Drawing.Size(45, 20);
            this.tpickLength.TabIndex = 12;
            this.tpickLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tpickLength.UseWaitCursor = true;
            this.tpickLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Toothpick length";
            // 
            // backgroundColor
            // 
            this.backgroundColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backgroundColor.Location = new System.Drawing.Point(321, 17);
            this.backgroundColor.Name = "backgroundColor";
            this.backgroundColor.ReadOnly = true;
            this.backgroundColor.Size = new System.Drawing.Size(45, 20);
            this.backgroundColor.TabIndex = 10;
            this.backgroundColor.Click += new System.EventHandler(this.TxtTpickColor_Click);
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(223, 20);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(92, 13);
            this.lblBackgroundColor.TabIndex = 9;
            this.lblBackgroundColor.Text = "Background Color";
            // 
            // newTpickColor
            // 
            this.newTpickColor.BackColor = System.Drawing.Color.Aqua;
            this.newTpickColor.Location = new System.Drawing.Point(150, 49);
            this.newTpickColor.Name = "newTpickColor";
            this.newTpickColor.ReadOnly = true;
            this.newTpickColor.Size = new System.Drawing.Size(45, 20);
            this.newTpickColor.TabIndex = 8;
            this.newTpickColor.Click += new System.EventHandler(this.TxtTpickColor_Click);
            // 
            // tpickColor
            // 
            this.tpickColor.BackColor = System.Drawing.Color.White;
            this.tpickColor.Location = new System.Drawing.Point(150, 20);
            this.tpickColor.Name = "tpickColor";
            this.tpickColor.ReadOnly = true;
            this.tpickColor.Size = new System.Drawing.Size(45, 20);
            this.tpickColor.TabIndex = 7;
            this.tpickColor.Click += new System.EventHandler(this.TxtTpickColor_Click);
            // 
            // lblNewTpickColor
            // 
            this.lblNewTpickColor.AutoSize = true;
            this.lblNewTpickColor.Location = new System.Drawing.Point(27, 52);
            this.lblNewTpickColor.Name = "lblNewTpickColor";
            this.lblNewTpickColor.Size = new System.Drawing.Size(107, 13);
            this.lblNewTpickColor.TabIndex = 6;
            this.lblNewTpickColor.Text = "New Toothpick Color";
            // 
            // lblTpickColor
            // 
            this.lblTpickColor.AutoSize = true;
            this.lblTpickColor.Location = new System.Drawing.Point(40, 20);
            this.lblTpickColor.Name = "lblTpickColor";
            this.lblTpickColor.Size = new System.Drawing.Size(82, 13);
            this.lblTpickColor.TabIndex = 5;
            this.lblTpickColor.Text = "Toothpick Color";
            // 
            // txtNumOfTpicks
            // 
            this.txtNumOfTpicks.Location = new System.Drawing.Point(901, 33);
            this.txtNumOfTpicks.Name = "txtNumOfTpicks";
            this.txtNumOfTpicks.ReadOnly = true;
            this.txtNumOfTpicks.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfTpicks.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of toothpicks";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(658, 34);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.ReadOnly = true;
            this.txtIterations.Size = new System.Drawing.Size(55, 20);
            this.txtIterations.TabIndex = 2;
            this.txtIterations.Text = "0";
            this.txtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIterations
            // 
            this.lblIterations.AutoSize = true;
            this.lblIterations.Location = new System.Drawing.Point(602, 37);
            this.lblIterations.Name = "lblIterations";
            this.lblIterations.Size = new System.Drawing.Size(50, 13);
            this.lblIterations.TabIndex = 1;
            this.lblIterations.Text = "Iterations";
            // 
            // btnDraw
            // 
            this.btnDraw.AutoSize = true;
            this.btnDraw.Location = new System.Drawing.Point(506, 15);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.BackColor = System.Drawing.Color.Black;
            this.canvasPanel.Location = new System.Drawing.Point(0, 87);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(1121, 649);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CanvasPanel_Paint);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 736);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.topPanel);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.ShowIcon = false;
            this.Text = "Toothpick pattern";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tpickLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label lblIterations;
        private System.Windows.Forms.TextBox txtNumOfTpicks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newTpickColor;
        private System.Windows.Forms.TextBox tpickColor;
        private System.Windows.Forms.Label lblNewTpickColor;
        private System.Windows.Forms.Label lblTpickColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox backgroundColor;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.NumericUpDown tpickLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
    }
}

