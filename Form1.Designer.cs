namespace Puntero_Windows
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowIp = new System.Windows.Forms.Label();
            this.ShowLog = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ShowIp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ShowLog, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ShowIp
            // 
            this.ShowIp.AutoSize = true;
            this.ShowIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowIp.Location = new System.Drawing.Point(3, 0);
            this.ShowIp.Name = "ShowIp";
            this.ShowIp.Size = new System.Drawing.Size(794, 225);
            this.ShowIp.TabIndex = 0;
            this.ShowIp.Text = "label1";
            this.ShowIp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowLog
            // 
            this.ShowLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowLog.Location = new System.Drawing.Point(3, 228);
            this.ShowLog.Name = "ShowLog";
            this.ShowLog.Size = new System.Drawing.Size(794, 219);
            this.ShowLog.TabIndex = 1;
            this.ShowLog.TileSize = new System.Drawing.Size(30, 30);
            this.ShowLog.UseCompatibleStateImageBehavior = false;
            this.ShowLog.View = System.Windows.Forms.View.Tile;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ShowIp;
        private System.Windows.Forms.ListView ShowLog;
    }
}

