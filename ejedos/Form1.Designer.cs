namespace ejedos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnFigura = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btbLimpiar = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFigura = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(119, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Figura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(330, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Perímetro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(349, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Área";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblArea.Location = new System.Drawing.Point(328, 151);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(97, 18);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "El área es: ";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.BackColor = System.Drawing.Color.Transparent;
            this.lblPerimetro.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblPerimetro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerimetro.Location = new System.Drawing.Point(300, 265);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(139, 18);
            this.lblPerimetro.TabIndex = 4;
            this.lblPerimetro.Text = "El perímetro es: ";
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(100, 269);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(101, 20);
            this.txtB.TabIndex = 4;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(100, 233);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 3;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // btnFigura
            // 
            this.btnFigura.BackColor = System.Drawing.Color.Transparent;
            this.btnFigura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFigura.BackgroundImage")));
            this.btnFigura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFigura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFigura.FlatAppearance.BorderSize = 0;
            this.btnFigura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFigura.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFigura.ForeColor = System.Drawing.Color.Transparent;
            this.btnFigura.Image = ((System.Drawing.Image)(resources.GetObject("btnFigura.Image")));
            this.btnFigura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFigura.Location = new System.Drawing.Point(101, 151);
            this.btnFigura.Name = "btnFigura";
            this.btnFigura.Size = new System.Drawing.Size(102, 40);
            this.btnFigura.TabIndex = 2;
            this.btnFigura.Text = "&Figura";
            this.btnFigura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFigura.UseVisualStyleBackColor = false;
            this.btnFigura.Click += new System.EventHandler(this.btnFigura_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Enabled = false;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(98, 295);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 40);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btbLimpiar
            // 
            this.btbLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btbLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbLimpiar.BackgroundImage")));
            this.btbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbLimpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btbLimpiar.FlatAppearance.BorderSize = 0;
            this.btbLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbLimpiar.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbLimpiar.ForeColor = System.Drawing.Color.Transparent;
            this.btbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btbLimpiar.Image")));
            this.btbLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbLimpiar.Location = new System.Drawing.Point(319, 295);
            this.btbLimpiar.Margin = new System.Windows.Forms.Padding(0);
            this.btbLimpiar.Name = "btbLimpiar";
            this.btbLimpiar.Size = new System.Drawing.Size(103, 40);
            this.btbLimpiar.TabIndex = 6;
            this.btbLimpiar.Text = "&Limpiar";
            this.btbLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbLimpiar.UseVisualStyleBackColor = false;
            this.btbLimpiar.Click += new System.EventHandler(this.btbLimpiar_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblA.Location = new System.Drawing.Point(64, 234);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 18);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "1";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.lblB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblB.Location = new System.Drawing.Point(64, 270);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 18);
            this.lblB.TabIndex = 16;
            this.lblB.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(110, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Variables";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Location = new System.Drawing.Point(189, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 37);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "FIGURAS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(167, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Olguin Jimenez Ariel Victor";
            // 
            // txtFigura
            // 
            this.txtFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFigura.FormattingEnabled = true;
            this.txtFigura.Items.AddRange(new object[] {
            "triangulo",
            "rectangulo",
            "cuadrado"});
            this.txtFigura.Location = new System.Drawing.Point(101, 118);
            this.txtFigura.Name = "txtFigura";
            this.txtFigura.Size = new System.Drawing.Size(102, 21);
            this.txtFigura.TabIndex = 20;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btbLimpiar;
            this.ClientSize = new System.Drawing.Size(525, 407);
            this.Controls.Add(this.txtFigura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btbLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnFigura);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área y perímetro de figuras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnFigura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btbLimpiar;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtFigura;
    }
}

