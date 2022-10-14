namespace PizzaOrder
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
            this.lstboxname = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbExtraToppings = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.cbSalami = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbPineapple = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbHam = new System.Windows.Forms.CheckBox();
            this.cbJalapenos = new System.Windows.Forms.CheckBox();
            this.cbSweetcorn = new System.Windows.Forms.CheckBox();
            this.cbChicken = new System.Windows.Forms.CheckBox();
            this.cbBacon = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.tbSpecialReq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbExtraToppings.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstboxname
            // 
            this.lstboxname.FormattingEnabled = true;
            this.lstboxname.ItemHeight = 15;
            this.lstboxname.Items.AddRange(new object[] {
            "Indian Apache",
            "Mexican Pepper Volcano",
            "All Day Breakfast",
            "Bacon Apache",
            "Buffalo",
            "Cajun Apache",
            "Chicken Apache",
            "Geronimo",
            "Hot Apache",
            "Sitting Bull",
            "Texas Beef Fiesta",
            "Tomahawk",
            "Vegetarian",
            "Wigwammer"});
            this.lstboxname.Location = new System.Drawing.Point(39, 59);
            this.lstboxname.Name = "lstboxname";
            this.lstboxname.Size = new System.Drawing.Size(163, 214);
            this.lstboxname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // gbExtraToppings
            // 
            this.gbExtraToppings.Controls.Add(this.cbGreenPeppers);
            this.gbExtraToppings.Controls.Add(this.cbExtraCheese);
            this.gbExtraToppings.Controls.Add(this.cbSalami);
            this.gbExtraToppings.Controls.Add(this.cbTomatoes);
            this.gbExtraToppings.Controls.Add(this.cbMushrooms);
            this.gbExtraToppings.Controls.Add(this.cbPineapple);
            this.gbExtraToppings.Controls.Add(this.cbOnion);
            this.gbExtraToppings.Controls.Add(this.cbPepperoni);
            this.gbExtraToppings.Controls.Add(this.cbHam);
            this.gbExtraToppings.Controls.Add(this.cbJalapenos);
            this.gbExtraToppings.Controls.Add(this.cbSweetcorn);
            this.gbExtraToppings.Controls.Add(this.cbChicken);
            this.gbExtraToppings.Controls.Add(this.cbBacon);
            this.gbExtraToppings.Controls.Add(this.cbSausage);
            this.gbExtraToppings.Location = new System.Drawing.Point(222, 59);
            this.gbExtraToppings.Name = "gbExtraToppings";
            this.gbExtraToppings.Size = new System.Drawing.Size(242, 214);
            this.gbExtraToppings.TabIndex = 2;
            this.gbExtraToppings.TabStop = false;
            this.gbExtraToppings.Text = "Extra Toppings";
            // 
            // cbGreenPeppers
            // 
            this.cbGreenPeppers.AutoSize = true;
            this.cbGreenPeppers.Location = new System.Drawing.Point(134, 139);
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.Size = new System.Drawing.Size(102, 19);
            this.cbGreenPeppers.TabIndex = 16;
            this.cbGreenPeppers.Text = "Green Peppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbExtraCheese
            // 
            this.cbExtraCheese.AutoSize = true;
            this.cbExtraCheese.Location = new System.Drawing.Point(134, 164);
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.Size = new System.Drawing.Size(91, 19);
            this.cbExtraCheese.TabIndex = 17;
            this.cbExtraCheese.Text = "Extra cheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbSalami
            // 
            this.cbSalami.AutoSize = true;
            this.cbSalami.Location = new System.Drawing.Point(134, 189);
            this.cbSalami.Name = "cbSalami";
            this.cbSalami.Size = new System.Drawing.Size(61, 19);
            this.cbSalami.TabIndex = 18;
            this.cbSalami.Text = "Salami";
            this.cbSalami.UseVisualStyleBackColor = true;
            this.cbSalami.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbTomatoes
            // 
            this.cbTomatoes.AutoSize = true;
            this.cbTomatoes.Location = new System.Drawing.Point(5, 39);
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.Size = new System.Drawing.Size(77, 19);
            this.cbTomatoes.TabIndex = 0;
            this.cbTomatoes.Text = "Tomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbMushrooms
            // 
            this.cbMushrooms.AutoSize = true;
            this.cbMushrooms.Location = new System.Drawing.Point(134, 64);
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.Size = new System.Drawing.Size(90, 19);
            this.cbMushrooms.TabIndex = 13;
            this.cbMushrooms.Text = "Mushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbPineapple
            // 
            this.cbPineapple.AutoSize = true;
            this.cbPineapple.Location = new System.Drawing.Point(134, 39);
            this.cbPineapple.Name = "cbPineapple";
            this.cbPineapple.Size = new System.Drawing.Size(78, 19);
            this.cbPineapple.TabIndex = 12;
            this.cbPineapple.Text = "Pineapple";
            this.cbPineapple.UseVisualStyleBackColor = true;
            this.cbPineapple.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(5, 64);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(59, 19);
            this.cbOnion.TabIndex = 6;
            this.cbOnion.Text = "Onion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(5, 89);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(80, 19);
            this.cbPepperoni.TabIndex = 7;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            this.cbPepperoni.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbHam
            // 
            this.cbHam.AutoSize = true;
            this.cbHam.Location = new System.Drawing.Point(5, 114);
            this.cbHam.Name = "cbHam";
            this.cbHam.Size = new System.Drawing.Size(52, 19);
            this.cbHam.TabIndex = 8;
            this.cbHam.Text = "Ham";
            this.cbHam.UseVisualStyleBackColor = true;
            this.cbHam.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbJalapenos
            // 
            this.cbJalapenos.AutoSize = true;
            this.cbJalapenos.Location = new System.Drawing.Point(134, 89);
            this.cbJalapenos.Name = "cbJalapenos";
            this.cbJalapenos.Size = new System.Drawing.Size(77, 19);
            this.cbJalapenos.TabIndex = 14;
            this.cbJalapenos.Text = "Jalapenos";
            this.cbJalapenos.UseVisualStyleBackColor = true;
            this.cbJalapenos.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbSweetcorn
            // 
            this.cbSweetcorn.AutoSize = true;
            this.cbSweetcorn.Location = new System.Drawing.Point(134, 114);
            this.cbSweetcorn.Name = "cbSweetcorn";
            this.cbSweetcorn.Size = new System.Drawing.Size(81, 19);
            this.cbSweetcorn.TabIndex = 15;
            this.cbSweetcorn.Text = "Sweetcorn";
            this.cbSweetcorn.UseVisualStyleBackColor = true;
            this.cbSweetcorn.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbChicken
            // 
            this.cbChicken.AutoSize = true;
            this.cbChicken.Location = new System.Drawing.Point(5, 189);
            this.cbChicken.Name = "cbChicken";
            this.cbChicken.Size = new System.Drawing.Size(69, 19);
            this.cbChicken.TabIndex = 11;
            this.cbChicken.Text = "Chicken";
            this.cbChicken.UseVisualStyleBackColor = true;
            this.cbChicken.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbBacon
            // 
            this.cbBacon.AutoSize = true;
            this.cbBacon.Location = new System.Drawing.Point(5, 164);
            this.cbBacon.Name = "cbBacon";
            this.cbBacon.Size = new System.Drawing.Size(59, 19);
            this.cbBacon.TabIndex = 10;
            this.cbBacon.Text = "Bacon";
            this.cbBacon.UseVisualStyleBackColor = true;
            this.cbBacon.Click += new System.EventHandler(this.SelectToppings);
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(5, 139);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(69, 19);
            this.cbSausage.TabIndex = 9;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            this.cbSausage.Click += new System.EventHandler(this.SelectToppings);
            // 
            // tbSpecialReq
            // 
            this.tbSpecialReq.Location = new System.Drawing.Point(39, 315);
            this.tbSpecialReq.Multiline = true;
            this.tbSpecialReq.Name = "tbSpecialReq";
            this.tbSpecialReq.Size = new System.Drawing.Size(502, 75);
            this.tbSpecialReq.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Special Requirements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order a Pizza";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbPersonal);
            this.gbSize.Location = new System.Drawing.Point(556, 59);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(108, 128);
            this.gbSize.TabIndex = 6;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(10, 99);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(54, 19);
            this.rbLarge.TabIndex = 3;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.Click += new System.EventHandler(this.SizeSelection);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(10, 74);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(70, 19);
            this.rbMedium.TabIndex = 2;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.Click += new System.EventHandler(this.SizeSelection);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(10, 49);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(54, 19);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.Click += new System.EventHandler(this.SizeSelection);
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(10, 24);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(70, 19);
            this.rbPersonal.TabIndex = 0;
            this.rbPersonal.TabStop = true;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.Click += new System.EventHandler(this.SizeSelection);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(557, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 51);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(556, 261);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(107, 51);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(557, 323);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmount.Location = new System.Drawing.Point(571, 352);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 21);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(557, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpecialReq);
            this.Controls.Add(this.gbExtraToppings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstboxname);
            this.MinimumSize = new System.Drawing.Size(697, 489);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbExtraToppings.ResumeLayout(false);
            this.gbExtraToppings.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstboxname;
        private Label label1;
        private GroupBox gbExtraToppings;
        private TextBox tbSpecialReq;
        private Label label2;
        private Label label3;
        private CheckBox cbGreenPeppers;
        private CheckBox cbExtraCheese;
        private CheckBox cbSalami;
        private CheckBox cbTomatoes;
        private CheckBox cbMushrooms;
        private CheckBox cbPineapple;
        private CheckBox cbOnion;
        private CheckBox cbPepperoni;
        private CheckBox cbHam;
        private CheckBox cbJalapenos;
        private CheckBox cbSweetcorn;
        private CheckBox cbChicken;
        private CheckBox cbBacon;
        private CheckBox cbSausage;
        private GroupBox gbSize;
        private RadioButton rbLarge;
        private RadioButton rbMedium;
        private RadioButton rbSmall;
        private RadioButton rbPersonal;
        private Button btnReset;
        private Button btnPlaceOrder;
        private Label lblPrice;
        private Label lblAmount;
        private Label label4;
    }
}