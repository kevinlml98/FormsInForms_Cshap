namespace FormsInForms_Csharp
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnPantalla1 = new System.Windows.Forms.Button();
            this.btnPantalla2 = new System.Windows.Forms.Button();
            this.btnPantalla3 = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMain.Location = new System.Drawing.Point(161, 35);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(596, 368);
            this.panelMain.TabIndex = 0;
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.btnPantalla3);
            this.panelNav.Controls.Add(this.btnPantalla2);
            this.panelNav.Controls.Add(this.btnPantalla1);
            this.panelNav.Location = new System.Drawing.Point(12, 35);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(134, 368);
            this.panelNav.TabIndex = 1;
            // 
            // btnPantalla1
            // 
            this.btnPantalla1.Location = new System.Drawing.Point(8, 22);
            this.btnPantalla1.Name = "btnPantalla1";
            this.btnPantalla1.Size = new System.Drawing.Size(118, 47);
            this.btnPantalla1.TabIndex = 0;
            this.btnPantalla1.Text = "Pantalla 1";
            this.btnPantalla1.UseVisualStyleBackColor = true;
            this.btnPantalla1.Click += new System.EventHandler(this.btnPantalla1_Click);
            // 
            // btnPantalla2
            // 
            this.btnPantalla2.Location = new System.Drawing.Point(8, 92);
            this.btnPantalla2.Name = "btnPantalla2";
            this.btnPantalla2.Size = new System.Drawing.Size(118, 47);
            this.btnPantalla2.TabIndex = 1;
            this.btnPantalla2.Text = "Pantalla 2";
            this.btnPantalla2.UseVisualStyleBackColor = true;
            this.btnPantalla2.Click += new System.EventHandler(this.btnPantalla2_Click);
            // 
            // btnPantalla3
            // 
            this.btnPantalla3.Location = new System.Drawing.Point(8, 161);
            this.btnPantalla3.Name = "btnPantalla3";
            this.btnPantalla3.Size = new System.Drawing.Size(118, 47);
            this.btnPantalla3.TabIndex = 2;
            this.btnPantalla3.Text = "Pantalla 3";
            this.btnPantalla3.UseVisualStyleBackColor = true;
            this.btnPantalla3.Click += new System.EventHandler(this.btnPantalla3_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelMain);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMain;
        private Panel panelNav;
        private Button btnPantalla3;
        private Button btnPantalla2;
        private Button btnPantalla1;
    }
}