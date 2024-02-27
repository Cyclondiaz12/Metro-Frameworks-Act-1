namespace fua
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtLados = new MetroFramework.Controls.MetroTextBox();
            this.txtLargo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(157, 220);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Calcular";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(116, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(149, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CALCULAR PERÍMETRO";
            // 
            // txtLados
            // 
            // 
            // 
            // 
            this.txtLados.CustomButton.Image = null;
            this.txtLados.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtLados.CustomButton.Name = "";
            this.txtLados.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLados.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLados.CustomButton.TabIndex = 1;
            this.txtLados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLados.CustomButton.UseSelectable = true;
            this.txtLados.CustomButton.Visible = false;
            this.txtLados.Lines = new string[0];
            this.txtLados.Location = new System.Drawing.Point(216, 124);
            this.txtLados.MaxLength = 32767;
            this.txtLados.Name = "txtLados";
            this.txtLados.PasswordChar = '\0';
            this.txtLados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLados.SelectedText = "";
            this.txtLados.SelectionLength = 0;
            this.txtLados.SelectionStart = 0;
            this.txtLados.ShortcutsEnabled = true;
            this.txtLados.Size = new System.Drawing.Size(75, 23);
            this.txtLados.TabIndex = 2;
            this.txtLados.UseSelectable = true;
            this.txtLados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLargo
            // 
            // 
            // 
            // 
            this.txtLargo.CustomButton.Image = null;
            this.txtLargo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtLargo.CustomButton.Name = "";
            this.txtLargo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLargo.CustomButton.TabIndex = 1;
            this.txtLargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLargo.CustomButton.UseSelectable = true;
            this.txtLargo.CustomButton.Visible = false;
            this.txtLargo.Lines = new string[0];
            this.txtLargo.Location = new System.Drawing.Point(216, 164);
            this.txtLargo.MaxLength = 32767;
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.PasswordChar = '\0';
            this.txtLargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLargo.SelectedText = "";
            this.txtLargo.SelectionLength = 0;
            this.txtLargo.SelectionStart = 0;
            this.txtLargo.ShortcutsEnabled = true;
            this.txtLargo.Size = new System.Drawing.Size(75, 23);
            this.txtLargo.TabIndex = 3;
            this.txtLargo.UseSelectable = true;
            this.txtLargo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLargo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(81, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Número de lados";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(81, 168);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Largo del lado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 346);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.txtLados);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtLados;
        private MetroFramework.Controls.MetroTextBox txtLargo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

