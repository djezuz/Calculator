﻿namespace Calculator
{
    namespace UI
    {
        partial class FCalculator
        {
            /// <summary>
            /// Variable del diseñador requerida.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Limpiar los recursos que se estén utilizando.
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
            /// el contenido del método con el editor de código.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCalculator));
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.bSQRT = new System.Windows.Forms.Button();
            this.bReciproc = new System.Windows.Forms.Button();
            this.bMod = new System.Windows.Forms.Button();
            this.bEqual = new System.Windows.Forms.Button();
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.bNot = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMult = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.lResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(11, 100);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(36, 29);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.insertNumber);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(50, 100);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(36, 29);
            this.b8.TabIndex = 1;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.insertNumber);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(89, 100);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(36, 29);
            this.b9.TabIndex = 2;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.insertNumber);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(89, 133);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(36, 29);
            this.b6.TabIndex = 5;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.insertNumber);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(50, 133);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(36, 29);
            this.b5.TabIndex = 4;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.insertNumber);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(11, 133);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(36, 29);
            this.b4.TabIndex = 3;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.insertNumber);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(89, 166);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(36, 29);
            this.b3.TabIndex = 8;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.insertNumber);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(50, 166);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(36, 29);
            this.b2.TabIndex = 7;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.insertNumber);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(11, 166);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(36, 29);
            this.b1.TabIndex = 6;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.insertNumber);
            // 
            // bDot
            // 
            this.bDot.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDot.Location = new System.Drawing.Point(89, 199);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(36, 29);
            this.bDot.TabIndex = 9;
            this.bDot.Text = ",";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.insertDot);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(11, 199);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 29);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.insertNumber);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bC.Location = new System.Drawing.Point(89, 67);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(36, 29);
            this.bC.TabIndex = 13;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.clearAll);
            // 
            // bCE
            // 
            this.bCE.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCE.Location = new System.Drawing.Point(50, 67);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(36, 29);
            this.bCE.TabIndex = 12;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.clear);
            // 
            // bReturn
            // 
            this.bReturn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReturn.Location = new System.Drawing.Point(11, 67);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(36, 29);
            this.bReturn.TabIndex = 11;
            this.bReturn.Text = "←";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.delete);
            // 
            // bSQRT
            // 
            this.bSQRT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSQRT.Location = new System.Drawing.Point(167, 67);
            this.bSQRT.Name = "bSQRT";
            this.bSQRT.Size = new System.Drawing.Size(36, 29);
            this.bSQRT.TabIndex = 16;
            this.bSQRT.Text = "√";
            this.bSQRT.UseVisualStyleBackColor = true;
            this.bSQRT.Click += new System.EventHandler(this.sqrt);
            // 
            // bReciproc
            // 
            this.bReciproc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReciproc.Location = new System.Drawing.Point(167, 133);
            this.bReciproc.Name = "bReciproc";
            this.bReciproc.Size = new System.Drawing.Size(36, 29);
            this.bReciproc.TabIndex = 15;
            this.bReciproc.Text = "1/x";
            this.bReciproc.UseVisualStyleBackColor = true;
            this.bReciproc.Click += new System.EventHandler(this.reciproc);
            // 
            // bMod
            // 
            this.bMod.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMod.Location = new System.Drawing.Point(167, 100);
            this.bMod.Name = "bMod";
            this.bMod.Size = new System.Drawing.Size(36, 29);
            this.bMod.TabIndex = 14;
            this.bMod.Text = "%";
            this.bMod.UseVisualStyleBackColor = true;
            this.bMod.Click += new System.EventHandler(this.mod);
            // 
            // bEqual
            // 
            this.bEqual.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEqual.Location = new System.Drawing.Point(167, 165);
            this.bEqual.Name = "bEqual";
            this.bEqual.Size = new System.Drawing.Size(36, 63);
            this.bEqual.TabIndex = 17;
            this.bEqual.Text = "=";
            this.bEqual.UseVisualStyleBackColor = true;
            this.bEqual.Click += new System.EventHandler(this.equal);
            // 
            // pbResult
            // 
            this.pbResult.Image = ((System.Drawing.Image)(resources.GetObject("pbResult.Image")));
            this.pbResult.Location = new System.Drawing.Point(12, 11);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(190, 50);
            this.pbResult.TabIndex = 19;
            this.pbResult.TabStop = false;
            // 
            // bNot
            // 
            this.bNot.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNot.Location = new System.Drawing.Point(128, 67);
            this.bNot.Name = "bNot";
            this.bNot.Size = new System.Drawing.Size(36, 29);
            this.bNot.TabIndex = 24;
            this.bNot.Text = "±";
            this.bNot.UseVisualStyleBackColor = true;
            this.bNot.Click += new System.EventHandler(this.not);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(128, 199);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(36, 29);
            this.bAdd.TabIndex = 23;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.add);
            // 
            // bSub
            // 
            this.bSub.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSub.Location = new System.Drawing.Point(128, 166);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(36, 29);
            this.bSub.TabIndex = 22;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.sub);
            // 
            // bMult
            // 
            this.bMult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMult.Location = new System.Drawing.Point(128, 133);
            this.bMult.Name = "bMult";
            this.bMult.Size = new System.Drawing.Size(36, 29);
            this.bMult.TabIndex = 21;
            this.bMult.Text = "*";
            this.bMult.UseVisualStyleBackColor = true;
            this.bMult.Click += new System.EventHandler(this.mult);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(128, 100);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(36, 29);
            this.bDiv.TabIndex = 20;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.div);
            // 
            // lResult
            // 
            this.lResult.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lResult.BackColor = System.Drawing.Color.Transparent;
            this.lResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.Location = new System.Drawing.Point(21, 28);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(177, 23);
            this.lResult.TabIndex = 25;
            this.lResult.Text = "0";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 238);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.bNot);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bMult);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bEqual);
            this.Controls.Add(this.bSQRT);
            this.Controls.Add(this.bReciproc);
            this.Controls.Add(this.bMod);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.pbResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Button b7;
            private System.Windows.Forms.Button b8;
            private System.Windows.Forms.Button b9;
            private System.Windows.Forms.Button b6;
            private System.Windows.Forms.Button b5;
            private System.Windows.Forms.Button b4;
            private System.Windows.Forms.Button b3;
            private System.Windows.Forms.Button b2;
            private System.Windows.Forms.Button b1;
            private System.Windows.Forms.Button bDot;
            private System.Windows.Forms.Button b0;
            private System.Windows.Forms.Button bC;
            private System.Windows.Forms.Button bCE;
            private System.Windows.Forms.Button bReturn;
            private System.Windows.Forms.Button bSQRT;
            private System.Windows.Forms.Button bReciproc;
            private System.Windows.Forms.Button bMod;
            private System.Windows.Forms.Button bEqual;
            private System.Windows.Forms.PictureBox pbResult;
            private System.Windows.Forms.Button bNot;
            private System.Windows.Forms.Button bAdd;
            private System.Windows.Forms.Button bSub;
            private System.Windows.Forms.Button bMult;
            private System.Windows.Forms.Button bDiv;
            private System.Windows.Forms.Label lResult;

        }
    }
}

