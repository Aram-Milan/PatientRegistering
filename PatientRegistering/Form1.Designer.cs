namespace PatientRegistering
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
            this.registerbtn = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.surenamelbl = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.sexlbl = new System.Windows.Forms.Label();
            this.edulbl = new System.Windows.Forms.Label();
            this.occuplbl = new System.Windows.Forms.Label();
            this.tellbl = new System.Windows.Forms.Label();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.surenametxtbox = new System.Windows.Forms.TextBox();
            this.dobtxtbox = new System.Windows.Forms.TextBox();
            this.sextxtbox = new System.Windows.Forms.TextBox();
            this.edutxtbox = new System.Windows.Forms.TextBox();
            this.occuptxtbox = new System.Windows.Forms.TextBox();
            this.teltxtbox = new System.Windows.Forms.TextBox();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(53, 375);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(446, 63);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.Location = new System.Drawing.Point(48, 47);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(64, 25);
            this.namelbl.TabIndex = 1;
            this.namelbl.Text = "Name";
            // 
            // surenamelbl
            // 
            this.surenamelbl.AutoSize = true;
            this.surenamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surenamelbl.Location = new System.Drawing.Point(48, 91);
            this.surenamelbl.Name = "surenamelbl";
            this.surenamelbl.Size = new System.Drawing.Size(103, 25);
            this.surenamelbl.TabIndex = 2;
            this.surenamelbl.Text = "Surename";
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.Location = new System.Drawing.Point(48, 139);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(116, 25);
            this.doblbl.TabIndex = 3;
            this.doblbl.Text = "Date of birth";
            // 
            // sexlbl
            // 
            this.sexlbl.AutoSize = true;
            this.sexlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexlbl.Location = new System.Drawing.Point(48, 182);
            this.sexlbl.Name = "sexlbl";
            this.sexlbl.Size = new System.Drawing.Size(92, 25);
            this.sexlbl.TabIndex = 4;
            this.sexlbl.Text = "Sexuality";
            // 
            // edulbl
            // 
            this.edulbl.AutoSize = true;
            this.edulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edulbl.Location = new System.Drawing.Point(48, 226);
            this.edulbl.Name = "edulbl";
            this.edulbl.Size = new System.Drawing.Size(99, 25);
            this.edulbl.TabIndex = 5;
            this.edulbl.Text = "Education";
            // 
            // occuplbl
            // 
            this.occuplbl.AutoSize = true;
            this.occuplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occuplbl.Location = new System.Drawing.Point(48, 274);
            this.occuplbl.Name = "occuplbl";
            this.occuplbl.Size = new System.Drawing.Size(112, 25);
            this.occuplbl.TabIndex = 6;
            this.occuplbl.Text = "Occupation";
            // 
            // tellbl
            // 
            this.tellbl.AutoSize = true;
            this.tellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tellbl.Location = new System.Drawing.Point(48, 321);
            this.tellbl.Name = "tellbl";
            this.tellbl.Size = new System.Drawing.Size(177, 25);
            this.tellbl.TabIndex = 7;
            this.tellbl.Text = "Telephone number";
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(252, 47);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(247, 22);
            this.nametxtbox.TabIndex = 8;
            // 
            // surenametxtbox
            // 
            this.surenametxtbox.Location = new System.Drawing.Point(252, 91);
            this.surenametxtbox.Name = "surenametxtbox";
            this.surenametxtbox.Size = new System.Drawing.Size(247, 22);
            this.surenametxtbox.TabIndex = 9;
            // 
            // dobtxtbox
            // 
            this.dobtxtbox.Location = new System.Drawing.Point(252, 139);
            this.dobtxtbox.Name = "dobtxtbox";
            this.dobtxtbox.Size = new System.Drawing.Size(247, 22);
            this.dobtxtbox.TabIndex = 10;
            // 
            // sextxtbox
            // 
            this.sextxtbox.Location = new System.Drawing.Point(252, 182);
            this.sextxtbox.Name = "sextxtbox";
            this.sextxtbox.Size = new System.Drawing.Size(247, 22);
            this.sextxtbox.TabIndex = 11;
            // 
            // edutxtbox
            // 
            this.edutxtbox.Location = new System.Drawing.Point(252, 226);
            this.edutxtbox.Name = "edutxtbox";
            this.edutxtbox.Size = new System.Drawing.Size(247, 22);
            this.edutxtbox.TabIndex = 12;
            // 
            // occuptxtbox
            // 
            this.occuptxtbox.Location = new System.Drawing.Point(252, 274);
            this.occuptxtbox.Name = "occuptxtbox";
            this.occuptxtbox.Size = new System.Drawing.Size(247, 22);
            this.occuptxtbox.TabIndex = 13;
            // 
            // teltxtbox
            // 
            this.teltxtbox.Location = new System.Drawing.Point(252, 321);
            this.teltxtbox.Name = "teltxtbox";
            this.teltxtbox.Size = new System.Drawing.Size(247, 22);
            this.teltxtbox.TabIndex = 14;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(545, 47);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(467, 391);
            this.dataGridViewPatients.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 472);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.teltxtbox);
            this.Controls.Add(this.occuptxtbox);
            this.Controls.Add(this.edutxtbox);
            this.Controls.Add(this.sextxtbox);
            this.Controls.Add(this.dobtxtbox);
            this.Controls.Add(this.surenametxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.tellbl);
            this.Controls.Add(this.occuplbl);
            this.Controls.Add(this.edulbl);
            this.Controls.Add(this.sexlbl);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.surenamelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.registerbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label surenamelbl;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.Label sexlbl;
        private System.Windows.Forms.Label edulbl;
        private System.Windows.Forms.Label occuplbl;
        private System.Windows.Forms.Label tellbl;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox surenametxtbox;
        private System.Windows.Forms.TextBox dobtxtbox;
        private System.Windows.Forms.TextBox sextxtbox;
        private System.Windows.Forms.TextBox edutxtbox;
        private System.Windows.Forms.TextBox occuptxtbox;
        private System.Windows.Forms.TextBox teltxtbox;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
    }
}

