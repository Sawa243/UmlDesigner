
namespace UmlDesigner
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.formsButton = new System.Windows.Forms.Button();
            this.arrowsSubMenu = new System.Windows.Forms.Panel();
            this.compositionArrowButton = new System.Windows.Forms.Button();
            this.aggregationArrowButton = new System.Windows.Forms.Button();
            this.implementationArrowButton = new System.Windows.Forms.Button();
            this.inheritanceArrowButton = new System.Windows.Forms.Button();
            this.associationArrowButton = new System.Windows.Forms.Button();
            this.arrowsButton = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.formsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.mainPanel.SuspendLayout();
            this.arrowsSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.formsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainPanel.BackgroundImage = global::UmlDesigner.Properties.Resources.fonstola_ru_72341;
            this.mainPanel.Controls.Add(this.trackBar1);
            this.mainPanel.Controls.Add(this.formsPanel);
            this.mainPanel.Controls.Add(this.formsButton);
            this.mainPanel.Controls.Add(this.arrowsSubMenu);
            this.mainPanel.Controls.Add(this.arrowsButton);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Location = new System.Drawing.Point(-4, -1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(167, 529);
            this.mainPanel.TabIndex = 3;
            // 
            // formsButton
            // 
            this.formsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.formsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.formsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formsButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.formsButton.Location = new System.Drawing.Point(0, 223);
            this.formsButton.Name = "formsButton";
            this.formsButton.Size = new System.Drawing.Size(167, 41);
            this.formsButton.TabIndex = 3;
            this.formsButton.Text = "FORMS";
            this.formsButton.UseVisualStyleBackColor = false;
            this.formsButton.Click += new System.EventHandler(this.formsButton_Click);
            // 
            // arrowsSubMenu
            // 
            this.arrowsSubMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.arrowsSubMenu.BackgroundImage = global::UmlDesigner.Properties.Resources._48535680_whtite_paper_pattern_texture_abstract_horizontal_vignette;
            this.arrowsSubMenu.Controls.Add(this.compositionArrowButton);
            this.arrowsSubMenu.Controls.Add(this.aggregationArrowButton);
            this.arrowsSubMenu.Controls.Add(this.implementationArrowButton);
            this.arrowsSubMenu.Controls.Add(this.inheritanceArrowButton);
            this.arrowsSubMenu.Controls.Add(this.associationArrowButton);
            this.arrowsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.arrowsSubMenu.Location = new System.Drawing.Point(0, 68);
            this.arrowsSubMenu.Name = "arrowsSubMenu";
            this.arrowsSubMenu.Size = new System.Drawing.Size(167, 155);
            this.arrowsSubMenu.TabIndex = 2;
            // 
            // compositionArrowButton
            // 
            this.compositionArrowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.compositionArrowButton.Image = global::UmlDesigner.Properties.Resources._000;
            this.compositionArrowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compositionArrowButton.Location = new System.Drawing.Point(0, 124);
            this.compositionArrowButton.Name = "compositionArrowButton";
            this.compositionArrowButton.Size = new System.Drawing.Size(167, 31);
            this.compositionArrowButton.TabIndex = 4;
            this.compositionArrowButton.UseVisualStyleBackColor = true;
            // 
            // aggregationArrowButton
            // 
            this.aggregationArrowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aggregationArrowButton.Image = global::UmlDesigner.Properties.Resources.Uml_classes_en3_svg;
            this.aggregationArrowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aggregationArrowButton.Location = new System.Drawing.Point(0, 93);
            this.aggregationArrowButton.Name = "aggregationArrowButton";
            this.aggregationArrowButton.Size = new System.Drawing.Size(167, 31);
            this.aggregationArrowButton.TabIndex = 3;
            this.aggregationArrowButton.UseVisualStyleBackColor = true;
            // 
            // implementationArrowButton
            // 
            this.implementationArrowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.implementationArrowButton.Image = global::UmlDesigner.Properties.Resources.Uml_classes_en2_svg;
            this.implementationArrowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.implementationArrowButton.Location = new System.Drawing.Point(0, 62);
            this.implementationArrowButton.Name = "implementationArrowButton";
            this.implementationArrowButton.Size = new System.Drawing.Size(167, 31);
            this.implementationArrowButton.TabIndex = 2;
            this.implementationArrowButton.UseVisualStyleBackColor = true;
            // 
            // inheritanceArrowButton
            // 
            this.inheritanceArrowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inheritanceArrowButton.Image = global::UmlDesigner.Properties.Resources.Uml_classes_edn1_svg;
            this.inheritanceArrowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inheritanceArrowButton.Location = new System.Drawing.Point(0, 31);
            this.inheritanceArrowButton.Name = "inheritanceArrowButton";
            this.inheritanceArrowButton.Size = new System.Drawing.Size(167, 31);
            this.inheritanceArrowButton.TabIndex = 1;
            this.inheritanceArrowButton.UseVisualStyleBackColor = true;
            // 
            // associationArrowButton
            // 
            this.associationArrowButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.associationArrowButton.Image = global::UmlDesigner.Properties.Resources._456789_svg;
            this.associationArrowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.associationArrowButton.Location = new System.Drawing.Point(0, 0);
            this.associationArrowButton.Name = "associationArrowButton";
            this.associationArrowButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.associationArrowButton.Size = new System.Drawing.Size(167, 31);
            this.associationArrowButton.TabIndex = 0;
            this.associationArrowButton.UseVisualStyleBackColor = true;
            // 
            // arrowsButton
            // 
            this.arrowsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.arrowsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.arrowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arrowsButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrowsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.arrowsButton.Location = new System.Drawing.Point(0, 27);
            this.arrowsButton.Name = "arrowsButton";
            this.arrowsButton.Size = new System.Drawing.Size(167, 41);
            this.arrowsButton.TabIndex = 1;
            this.arrowsButton.Text = "ARROWS";
            this.arrowsButton.UseVisualStyleBackColor = false;
            this.arrowsButton.Click += new System.EventHandler(this.arrowsButton_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackgroundImage = global::UmlDesigner.Properties.Resources.fonstola_ru_72341;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(167, 27);
            this.headerPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(159, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(886, 526);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // formsPanel
            // 
            this.formsPanel.BackgroundImage = global::UmlDesigner.Properties.Resources._48535680_whtite_paper_pattern_texture_abstract_horizontal_vignette;
            this.formsPanel.Controls.Add(this.button3);
            this.formsPanel.Controls.Add(this.button2);
            this.formsPanel.Controls.Add(this.button1);
            this.formsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formsPanel.Location = new System.Drawing.Point(0, 264);
            this.formsPanel.Name = "formsPanel";
            this.formsPanel.Size = new System.Drawing.Size(167, 92);
            this.formsPanel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackBar1.Location = new System.Drawing.Point(16, 453);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(141, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 509);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UML Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.arrowsSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.formsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel arrowsSubMenu;
        private System.Windows.Forms.Button compositionArrowButton;
        private System.Windows.Forms.Button aggregationArrowButton;
        private System.Windows.Forms.Button implementationArrowButton;
        private System.Windows.Forms.Button inheritanceArrowButton;
        private System.Windows.Forms.Button associationArrowButton;
        private System.Windows.Forms.Button arrowsButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button formsButton;
        private System.Windows.Forms.Panel formsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

