namespace Generator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addToListButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenList = new System.Windows.Forms.Button();
            this.obsFilePathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToListInput = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(270, 109);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(110, 30);
            this.addToListButton.TabIndex = 2;
            this.addToListButton.Text = "Ajouter";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajouter une phrase";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Random Generator";
            // 
            // buttonOpenList
            // 
            this.buttonOpenList.Location = new System.Drawing.Point(12, 239);
            this.buttonOpenList.Name = "buttonOpenList";
            this.buttonOpenList.Size = new System.Drawing.Size(122, 30);
            this.buttonOpenList.TabIndex = 8;
            this.buttonOpenList.Text = "Ouvrir la liste";
            this.buttonOpenList.UseVisualStyleBackColor = true;
            this.buttonOpenList.Click += new System.EventHandler(this.buttonOpenList_Click);
            // 
            // obsFilePathTextBox
            // 
            this.obsFilePathTextBox.Location = new System.Drawing.Point(12, 171);
            this.obsFilePathTextBox.Name = "obsFilePathTextBox";
            this.obsFilePathTextBox.ReadOnly = true;
            this.obsFilePathTextBox.Size = new System.Drawing.Size(368, 22);
            this.obsFilePathTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fichier à ajouter en source \"text\" sur OBS";
            // 
            // addToListInput
            // 
            this.addToListInput.Location = new System.Drawing.Point(12, 81);
            this.addToListInput.Name = "addToListInput";
            this.addToListInput.Size = new System.Drawing.Size(368, 22);
            this.addToListInput.TabIndex = 12;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(229, 239);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(146, 30);
            this.buttonOpenFile.TabIndex = 13;
            this.buttonOpenFile.Text = "Ouvrir fichier OBS";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 284);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.addToListInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.obsFilePathTextBox);
            this.Controls.Add(this.buttonOpenList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToListButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator by Masa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenList;
        private System.Windows.Forms.TextBox obsFilePathTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addToListInput;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Timer timer;
    }
}

