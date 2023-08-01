namespace student_manager
{
    partial class FormPrincipal
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.estudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirEstudanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarremoverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEstudantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudanteToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // estudanteToolStripMenuItem
            // 
            this.estudanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirEstudanteToolStripMenuItem,
            this.listarEstudantesToolStripMenuItem,
            this.estatisticasToolStripMenuItem,
            this.editarremoverToolStripMenuItem,
            this.gerenciarEstudantesToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.estudanteToolStripMenuItem.Name = "estudanteToolStripMenuItem";
            this.estudanteToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.estudanteToolStripMenuItem.Text = "estudante";
            // 
            // inserirEstudanteToolStripMenuItem
            // 
            this.inserirEstudanteToolStripMenuItem.Name = "inserirEstudanteToolStripMenuItem";
            this.inserirEstudanteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.inserirEstudanteToolStripMenuItem.Text = "inserir estudante";
            this.inserirEstudanteToolStripMenuItem.Click += new System.EventHandler(this.inserirEstudanteToolStripMenuItem_Click);
            // 
            // listarEstudantesToolStripMenuItem
            // 
            this.listarEstudantesToolStripMenuItem.Name = "listarEstudantesToolStripMenuItem";
            this.listarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listarEstudantesToolStripMenuItem.Text = "listar estudantes";
            // 
            // estatisticasToolStripMenuItem
            // 
            this.estatisticasToolStripMenuItem.Name = "estatisticasToolStripMenuItem";
            this.estatisticasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.estatisticasToolStripMenuItem.Text = "estatisticas";
            // 
            // editarremoverToolStripMenuItem
            // 
            this.editarremoverToolStripMenuItem.Name = "editarremoverToolStripMenuItem";
            this.editarremoverToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.editarremoverToolStripMenuItem.Text = "editar/remover";
            // 
            // gerenciarEstudantesToolStripMenuItem
            // 
            this.gerenciarEstudantesToolStripMenuItem.Name = "gerenciarEstudantesToolStripMenuItem";
            this.gerenciarEstudantesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gerenciarEstudantesToolStripMenuItem.Text = "gerenciar estudantes";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.imprimirToolStripMenuItem.Text = "imprimir";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.cursosToolStripMenuItem.Text = "cursos";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.notasToolStripMenuItem.Text = "notas";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem estudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirEstudanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarremoverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEstudantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
    }
}