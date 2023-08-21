namespace Recran
{
    partial class Main_Form
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
            this.screen = new MaterialSkin.Controls.MaterialComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.record_activ = new MaterialSkin.Controls.MaterialCheckbox();
            this.footer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.preview = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.AutoResize = false;
            this.screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.screen.Depth = 0;
            this.screen.Dock = System.Windows.Forms.DockStyle.Left;
            this.screen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.screen.DropDownHeight = 174;
            this.screen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screen.DropDownWidth = 121;
            this.screen.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.screen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.screen.FormattingEnabled = true;
            this.screen.Hint = "Screen to record";
            this.screen.IntegralHeight = false;
            this.screen.ItemHeight = 43;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.MaxDropDownItems = 4;
            this.screen.MouseState = MaterialSkin.MouseState.OUT;
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(950, 49);
            this.screen.StartIndex = 0;
            this.screen.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.screen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 55);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.record_activ);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(950, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 55);
            this.panel2.TabIndex = 1;
            // 
            // record_activ
            // 
            this.record_activ.AutoSize = true;
            this.record_activ.Depth = 0;
            this.record_activ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.record_activ.Location = new System.Drawing.Point(0, 0);
            this.record_activ.Margin = new System.Windows.Forms.Padding(0);
            this.record_activ.MouseLocation = new System.Drawing.Point(-1, -1);
            this.record_activ.MouseState = MaterialSkin.MouseState.HOVER;
            this.record_activ.Name = "record_activ";
            this.record_activ.ReadOnly = false;
            this.record_activ.Ripple = true;
            this.record_activ.Size = new System.Drawing.Size(97, 55);
            this.record_activ.TabIndex = 0;
            this.record_activ.Text = "Record";
            this.record_activ.UseVisualStyleBackColor = true;
            // 
            // footer
            // 
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(2, 493);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1047, 55);
            this.footer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.preview);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 396);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live Preview";
            // 
            // preview
            // 
            this.preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preview.Location = new System.Drawing.Point(3, 16);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(1041, 377);
            this.preview.TabIndex = 2;
            this.preview.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main_Form";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox screen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialCheckbox record_activ;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox preview;
    }
}

