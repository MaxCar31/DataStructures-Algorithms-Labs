namespace Lab04_Carrion
{
    partial class Form1
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
            treeView1 = new TreeView();
            label1 = new Label();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 11);
            treeView1.Margin = new Padding(3, 2, 3, 2);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(623, 259);
            treeView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(547, 301);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "By Max Carrión";
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 387);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

            // Configurar la etiqueta del nombre del nodo
            lblNodeName = new Label();
            lblNodeName.Text = "Nombre del Nodo:";
            lblNodeName.Location = new Point(12, 300);
            lblNodeName.AutoSize = true;

            // Configurar la etiqueta del nombre del elemento
            lblElementName = new Label();
            lblElementName.Text = "Nombre del Elemento:";
            lblElementName.Location = new Point(138, 300);
            lblElementName.AutoSize = true;

            // Agregar las etiquetas al formulario
            this.Controls.Add(lblNodeName);
            this.Controls.Add(lblElementName);

            // TextBox para personalizar el nombre del nodo
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.txtNodeName.Location = new System.Drawing.Point(12, 320);
            this.txtNodeName.Size = new System.Drawing.Size(120, 20);
            this.Controls.Add(this.txtNodeName);

            // TextBox para personalizar el nombre del elemento
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.txtElementName.Location = new System.Drawing.Point(138, 320);
            this.txtElementName.Size = new System.Drawing.Size(120, 20);
            this.Controls.Add(this.txtElementName);

            // Configuración del botón "Agregar Nodo"
            this.btnAddNode = new System.Windows.Forms.Button();
            this.btnAddNode.Location = new System.Drawing.Point(12, 350);
            this.btnAddNode.Size = new System.Drawing.Size(120, 30);
            this.btnAddNode.Text = "Agregar Nodo";
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            this.Controls.Add(this.btnAddNode);

            // Configuración del botón "Agregar Elemento"
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnAddElement.Location = new System.Drawing.Point(138, 350);
            this.btnAddElement.Size = new System.Drawing.Size(120, 30);
            this.btnAddElement.Text = "Agregar Elemento";
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            this.Controls.Add(this.btnAddElement);

            // Configuración del botón "Limpiar Árbol"
            this.btnClearTree = new System.Windows.Forms.Button();
            this.btnClearTree.Location = new System.Drawing.Point(264, 350);
            this.btnClearTree.Size = new System.Drawing.Size(120, 30);
            this.btnClearTree.Text = "Limpiar Árbol";
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
            this.Controls.Add(this.btnClearTree);

            // Configuración del botón "Eliminar Nodo"
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnRemoveNode.Location = new System.Drawing.Point(390, 350);
            this.btnRemoveNode.Size = new System.Drawing.Size(190, 30);
            this.btnRemoveNode.Text = "Eliminar Nodo o Elemento";
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            this.Controls.Add(this.btnRemoveNode);

        }

        #endregion

        private TreeView treeView1;
        private Label label1;
    }
}