namespace Proyecto4_ArbolesBinarios.AlexandraGomez
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscenario1 = new System.Windows.Forms.Button();
            this.btnEscenario2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "DISEÑO DE ARBOLES BINARIOS ";
            // 
            // btnEscenario1
            // 
            this.btnEscenario1.BackColor = System.Drawing.Color.IndianRed;
            this.btnEscenario1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscenario1.Location = new System.Drawing.Point(200, 144);
            this.btnEscenario1.Name = "btnEscenario1";
            this.btnEscenario1.Size = new System.Drawing.Size(163, 70);
            this.btnEscenario1.TabIndex = 2;
            this.btnEscenario1.Text = "Escenario # 1 ";
            this.btnEscenario1.UseVisualStyleBackColor = false;
            this.btnEscenario1.Click += new System.EventHandler(this.btnEscenario1_Click);
            // 
            // btnEscenario2
            // 
            this.btnEscenario2.BackColor = System.Drawing.Color.Coral;
            this.btnEscenario2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscenario2.Location = new System.Drawing.Point(446, 144);
            this.btnEscenario2.Name = "btnEscenario2";
            this.btnEscenario2.Size = new System.Drawing.Size(164, 70);
            this.btnEscenario2.TabIndex = 3;
            this.btnEscenario2.Text = "Escenario # 2";
            this.btnEscenario2.UseVisualStyleBackColor = false;
            this.btnEscenario2.Click += new System.EventHandler(this.btnEscenario2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Peru;
            this.btnSalir.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(330, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 48);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(594, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Proyecto.4 Alexandra Gomez ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEscenario2);
            this.Controls.Add(this.btnEscenario1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEscenario1;
        private System.Windows.Forms.Button btnEscenario2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label13;
    }
}