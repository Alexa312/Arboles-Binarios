namespace Proyecto4_ArbolesBinarios.AlexandraGomez
{
    partial class Escenario1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemGrafica = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRecorridos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPreOrden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInOrden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPostOrden = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGrafica,
            this.menuItemRecorridos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemGrafica
            // 
            this.menuItemGrafica.BackColor = System.Drawing.Color.IndianRed;
            this.menuItemGrafica.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemGrafica.Name = "menuItemGrafica";
            this.menuItemGrafica.Size = new System.Drawing.Size(68, 23);
            this.menuItemGrafica.Text = "Grafica";
            this.menuItemGrafica.Click += new System.EventHandler(this.menuItemGrafica_Click);
            // 
            // menuItemRecorridos
            // 
            this.menuItemRecorridos.BackColor = System.Drawing.Color.LightCoral;
            this.menuItemRecorridos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPreOrden,
            this.menuItemInOrden,
            this.menuItemPostOrden});
            this.menuItemRecorridos.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemRecorridos.Name = "menuItemRecorridos";
            this.menuItemRecorridos.Size = new System.Drawing.Size(87, 23);
            this.menuItemRecorridos.Text = "Recorridos";
            // 
            // menuItemPreOrden
            // 
            this.menuItemPreOrden.Name = "menuItemPreOrden";
            this.menuItemPreOrden.Size = new System.Drawing.Size(142, 24);
            this.menuItemPreOrden.Text = "PreOrden";
            this.menuItemPreOrden.Click += new System.EventHandler(this.menuItemPreOrden_Click);
            // 
            // menuItemInOrden
            // 
            this.menuItemInOrden.Name = "menuItemInOrden";
            this.menuItemInOrden.Size = new System.Drawing.Size(142, 24);
            this.menuItemInOrden.Text = "InOrden";
            this.menuItemInOrden.Click += new System.EventHandler(this.menuItemInOrden_Click);
            // 
            // menuItemPostOrden
            // 
            this.menuItemPostOrden.Name = "menuItemPostOrden";
            this.menuItemPostOrden.Size = new System.Drawing.Size(142, 24);
            this.menuItemPostOrden.Text = "PostOrden";
            this.menuItemPostOrden.Click += new System.EventHandler(this.menuItemPostOrden_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(657, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Proyecto.4 Alexandra Gomez ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(163, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(127, 26);
            this.btnRegresar.TabIndex = 14;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Escenario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(863, 496);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Escenario1";
            this.Text = "Escenario1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Escenario1_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemGrafica;
        private System.Windows.Forms.ToolStripMenuItem menuItemRecorridos;
        private System.Windows.Forms.ToolStripMenuItem menuItemPreOrden;
        private System.Windows.Forms.ToolStripMenuItem menuItemInOrden;
        private System.Windows.Forms.ToolStripMenuItem menuItemPostOrden;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
    }
}