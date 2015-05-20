namespace ClientDemo
{
    partial class Form1
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
            this.lblChoosInstance = new System.Windows.Forms.Label();
            this.cmbInstances = new System.Windows.Forms.ComboBox();
            this.lblInstanceName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblCollation = new System.Windows.Forms.Label();
            this.lblIsClustered = new System.Windows.Forms.Label();
            this.lblChooseDb = new System.Windows.Forms.Label();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChoosInstance
            // 
            this.lblChoosInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoosInstance.Location = new System.Drawing.Point(26, 35);
            this.lblChoosInstance.Name = "lblChoosInstance";
            this.lblChoosInstance.Size = new System.Drawing.Size(124, 23);
            this.lblChoosInstance.TabIndex = 0;
            this.lblChoosInstance.Text = "Choose Instance";
            // 
            // cmbInstances
            // 
            this.cmbInstances.FormattingEnabled = true;
            this.cmbInstances.Location = new System.Drawing.Point(167, 35);
            this.cmbInstances.Name = "cmbInstances";
            this.cmbInstances.Size = new System.Drawing.Size(205, 21);
            this.cmbInstances.TabIndex = 1;
            this.cmbInstances.SelectedIndexChanged += new System.EventHandler(this.cmbInstances_SelectedIndexChanged);
            // 
            // lblInstanceName
            // 
            this.lblInstanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstanceName.Location = new System.Drawing.Point(26, 75);
            this.lblInstanceName.Name = "lblInstanceName";
            this.lblInstanceName.Size = new System.Drawing.Size(116, 23);
            this.lblInstanceName.TabIndex = 2;
            this.lblInstanceName.Text = "InstanceName";
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(164, 75);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(116, 23);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version";
            // 
            // lblEdition
            // 
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.Location = new System.Drawing.Point(286, 75);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(116, 23);
            this.lblEdition.TabIndex = 4;
            this.lblEdition.Text = "Edition";
            // 
            // lblCollation
            // 
            this.lblCollation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollation.Location = new System.Drawing.Point(408, 75);
            this.lblCollation.Name = "lblCollation";
            this.lblCollation.Size = new System.Drawing.Size(116, 23);
            this.lblCollation.TabIndex = 5;
            this.lblCollation.Text = "Collation";
            // 
            // lblIsClustered
            // 
            this.lblIsClustered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsClustered.Location = new System.Drawing.Point(530, 75);
            this.lblIsClustered.Name = "lblIsClustered";
            this.lblIsClustered.Size = new System.Drawing.Size(116, 23);
            this.lblIsClustered.TabIndex = 6;
            this.lblIsClustered.Text = "IsClustered";
            // 
            // lblChooseDb
            // 
            this.lblChooseDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseDb.Location = new System.Drawing.Point(26, 126);
            this.lblChooseDb.Name = "lblChooseDb";
            this.lblChooseDb.Size = new System.Drawing.Size(124, 23);
            this.lblChooseDb.TabIndex = 7;
            this.lblChooseDb.Text = "Choose Database";
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(167, 126);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(205, 21);
            this.cmbDatabases.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 632);
            this.Controls.Add(this.cmbDatabases);
            this.Controls.Add(this.lblChooseDb);
            this.Controls.Add(this.lblIsClustered);
            this.Controls.Add(this.lblCollation);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblInstanceName);
            this.Controls.Add(this.cmbInstances);
            this.Controls.Add(this.lblChoosInstance);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblChoosInstance;
        private System.Windows.Forms.ComboBox cmbInstances;
        private System.Windows.Forms.Label lblInstanceName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblCollation;
        private System.Windows.Forms.Label lblIsClustered;
        private System.Windows.Forms.Label lblChooseDb;
        private System.Windows.Forms.ComboBox cmbDatabases;
    }
}

