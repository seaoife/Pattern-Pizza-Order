
namespace CA3Programming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panelPizzaContainer = new System.Windows.Forms.Panel();
            this.pictureBoxCheese = new System.Windows.Forms.PictureBox();
            this.pictureBoxTomato = new System.Windows.Forms.PictureBox();
            this.pictureBoxMushrooms = new System.Windows.Forms.PictureBox();
            this.pictureBoxOnions = new System.Windows.Forms.PictureBox();
            this.pictureBoxPepperoni = new System.Windows.Forms.PictureBox();
            this.pictureBoxBasePizza = new System.Windows.Forms.PictureBox();
            this.button1Tomato = new System.Windows.Forms.Button();
            this.button2Onions = new System.Windows.Forms.Button();
            this.button3Cheese = new System.Windows.Forms.Button();
            this.label2EuroCost = new System.Windows.Forms.Label();
            this.Label3TotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1Pepperoni = new System.Windows.Forms.Button();
            this.removeTopping = new System.Windows.Forms.Button();
            this.buttonAddMushroom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPizzaContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTomato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMushrooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPepperoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasePizza)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1196, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "..";
            // 
            // panelPizzaContainer
            // 
            this.panelPizzaContainer.Controls.Add(this.pictureBoxCheese);
            this.panelPizzaContainer.Controls.Add(this.pictureBoxTomato);
            this.panelPizzaContainer.Controls.Add(this.pictureBoxMushrooms);
            this.panelPizzaContainer.Controls.Add(this.pictureBoxOnions);
            this.panelPizzaContainer.Controls.Add(this.pictureBoxPepperoni);
            this.panelPizzaContainer.Controls.Add(this.pictureBoxBasePizza);
            this.panelPizzaContainer.Location = new System.Drawing.Point(12, 12);
            this.panelPizzaContainer.Name = "panelPizzaContainer";
            this.panelPizzaContainer.Size = new System.Drawing.Size(719, 750);
            this.panelPizzaContainer.TabIndex = 1;
            // 
            // pictureBoxCheese
            // 
            this.pictureBoxCheese.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCheese.Image")));
            this.pictureBoxCheese.Location = new System.Drawing.Point(83, 82);
            this.pictureBoxCheese.Name = "pictureBoxCheese";
            this.pictureBoxCheese.Size = new System.Drawing.Size(197, 218);
            this.pictureBoxCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheese.TabIndex = 9;
            this.pictureBoxCheese.TabStop = false;
            this.pictureBoxCheese.Click += new System.EventHandler(this.pictureBoxCheese_Click);
            // 
            // pictureBoxTomato
            // 
            this.pictureBoxTomato.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTomato.Image")));
            this.pictureBoxTomato.Location = new System.Drawing.Point(72, 300);
            this.pictureBoxTomato.Name = "pictureBoxTomato";
            this.pictureBoxTomato.Size = new System.Drawing.Size(171, 202);
            this.pictureBoxTomato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTomato.TabIndex = 8;
            this.pictureBoxTomato.TabStop = false;
            // 
            // pictureBoxMushrooms
            // 
            this.pictureBoxMushrooms.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMushrooms.Image")));
            this.pictureBoxMushrooms.Location = new System.Drawing.Point(278, 82);
            this.pictureBoxMushrooms.Name = "pictureBoxMushrooms";
            this.pictureBoxMushrooms.Size = new System.Drawing.Size(196, 266);
            this.pictureBoxMushrooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMushrooms.TabIndex = 7;
            this.pictureBoxMushrooms.TabStop = false;
            // 
            // pictureBoxOnions
            // 
            this.pictureBoxOnions.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOnions.Image")));
            this.pictureBoxOnions.Location = new System.Drawing.Point(445, 82);
            this.pictureBoxOnions.Name = "pictureBoxOnions";
            this.pictureBoxOnions.Size = new System.Drawing.Size(266, 518);
            this.pictureBoxOnions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOnions.TabIndex = 6;
            this.pictureBoxOnions.TabStop = false;
            // 
            // pictureBoxPepperoni
            // 
            this.pictureBoxPepperoni.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPepperoni.Image")));
            this.pictureBoxPepperoni.Location = new System.Drawing.Point(234, 336);
            this.pictureBoxPepperoni.Name = "pictureBoxPepperoni";
            this.pictureBoxPepperoni.Size = new System.Drawing.Size(228, 255);
            this.pictureBoxPepperoni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPepperoni.TabIndex = 5;
            this.pictureBoxPepperoni.TabStop = false;
            // 
            // pictureBoxBasePizza
            // 
            this.pictureBoxBasePizza.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBasePizza.Image")));
            this.pictureBoxBasePizza.Location = new System.Drawing.Point(24, 18);
            this.pictureBoxBasePizza.Name = "pictureBoxBasePizza";
            this.pictureBoxBasePizza.Size = new System.Drawing.Size(687, 620);
            this.pictureBoxBasePizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBasePizza.TabIndex = 0;
            this.pictureBoxBasePizza.TabStop = false;
            // 
            // button1Tomato
            // 
            this.button1Tomato.BackColor = System.Drawing.Color.MistyRose;
            this.button1Tomato.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1Tomato.FlatAppearance.BorderSize = 4;
            this.button1Tomato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1Tomato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1Tomato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1Tomato.Location = new System.Drawing.Point(43, 72);
            this.button1Tomato.Name = "button1Tomato";
            this.button1Tomato.Size = new System.Drawing.Size(171, 42);
            this.button1Tomato.TabIndex = 2;
            this.button1Tomato.Text = "Add Tomato Sauce";
            this.button1Tomato.UseVisualStyleBackColor = false;
            this.button1Tomato.Click += new System.EventHandler(this.button1Tomato_Click);
            // 
            // button2Onions
            // 
            this.button2Onions.BackColor = System.Drawing.Color.MistyRose;
            this.button2Onions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2Onions.FlatAppearance.BorderSize = 4;
            this.button2Onions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.button2Onions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2Onions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2Onions.Location = new System.Drawing.Point(43, 135);
            this.button2Onions.Name = "button2Onions";
            this.button2Onions.Size = new System.Drawing.Size(171, 44);
            this.button2Onions.TabIndex = 3;
            this.button2Onions.Text = "Add Onions";
            this.button2Onions.UseVisualStyleBackColor = false;
            this.button2Onions.Click += new System.EventHandler(this.button2Onions_Click);
            // 
            // button3Cheese
            // 
            this.button3Cheese.BackColor = System.Drawing.Color.MistyRose;
            this.button3Cheese.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3Cheese.FlatAppearance.BorderSize = 4;
            this.button3Cheese.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3Cheese.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3Cheese.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3Cheese.Location = new System.Drawing.Point(43, 281);
            this.button3Cheese.Name = "button3Cheese";
            this.button3Cheese.Size = new System.Drawing.Size(171, 42);
            this.button3Cheese.TabIndex = 4;
            this.button3Cheese.Text = "Add Cheese";
            this.button3Cheese.UseVisualStyleBackColor = false;
            this.button3Cheese.Click += new System.EventHandler(this.button3Cheese_Click);
            // 
            // label2EuroCost
            // 
            this.label2EuroCost.AutoSize = true;
            this.label2EuroCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2EuroCost.Location = new System.Drawing.Point(1281, 633);
            this.label2EuroCost.Name = "label2EuroCost";
            this.label2EuroCost.Size = new System.Drawing.Size(47, 32);
            this.label2EuroCost.TabIndex = 5;
            this.label2EuroCost.Text = "....";
            // 
            // Label3TotalCost
            // 
            this.Label3TotalCost.AutoSize = true;
            this.Label3TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3TotalCost.Location = new System.Drawing.Point(807, 633);
            this.Label3TotalCost.Name = "Label3TotalCost";
            this.Label3TotalCost.Size = new System.Drawing.Size(454, 32);
            this.Label3TotalCost.TabIndex = 6;
            this.Label3TotalCost.Text = "Total Cost with Selected Toppings:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(807, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Design Your Pizza!";
            // 
            // button1Pepperoni
            // 
            this.button1Pepperoni.BackColor = System.Drawing.Color.MistyRose;
            this.button1Pepperoni.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1Pepperoni.FlatAppearance.BorderSize = 4;
            this.button1Pepperoni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1Pepperoni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1Pepperoni.Location = new System.Drawing.Point(43, 200);
            this.button1Pepperoni.Name = "button1Pepperoni";
            this.button1Pepperoni.Size = new System.Drawing.Size(171, 55);
            this.button1Pepperoni.TabIndex = 8;
            this.button1Pepperoni.Text = "Add Pepperoni";
            this.button1Pepperoni.UseVisualStyleBackColor = false;
            this.button1Pepperoni.Click += new System.EventHandler(this.button1Pepperoni_Click);
            // 
            // removeTopping
            // 
            this.removeTopping.Location = new System.Drawing.Point(26, 436);
            this.removeTopping.Name = "removeTopping";
            this.removeTopping.Size = new System.Drawing.Size(215, 59);
            this.removeTopping.TabIndex = 9;
            this.removeTopping.Text = "Remove Last Topping Added ";
            this.removeTopping.UseVisualStyleBackColor = true;
            this.removeTopping.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAddMushroom
            // 
            this.buttonAddMushroom.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAddMushroom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddMushroom.FlatAppearance.BorderSize = 4;
            this.buttonAddMushroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAddMushroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonAddMushroom.Location = new System.Drawing.Point(43, 341);
            this.buttonAddMushroom.Name = "buttonAddMushroom";
            this.buttonAddMushroom.Size = new System.Drawing.Size(171, 57);
            this.buttonAddMushroom.TabIndex = 10;
            this.buttonAddMushroom.Text = "Add Mushrooms";
            this.buttonAddMushroom.UseVisualStyleBackColor = false;
            this.buttonAddMushroom.Click += new System.EventHandler(this.buttonAddMushroom_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1Pepperoni);
            this.panel1.Controls.Add(this.removeTopping);
            this.panel1.Controls.Add(this.buttonAddMushroom);
            this.panel1.Controls.Add(this.button2Onions);
            this.panel1.Controls.Add(this.button3Cheese);
            this.panel1.Controls.Add(this.button1Tomato);
            this.panel1.Location = new System.Drawing.Point(768, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 537);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1837, 823);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label3TotalCost);
            this.Controls.Add(this.label2EuroCost);
            this.Controls.Add(this.panelPizzaContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPizzaContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTomato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMushrooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPepperoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBasePizza)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPizzaContainer;
        private System.Windows.Forms.Button button1Tomato;
        private System.Windows.Forms.Button button2Onions;
        private System.Windows.Forms.Button button3Cheese;
        private System.Windows.Forms.Label label2EuroCost;
        private System.Windows.Forms.Label Label3TotalCost;
        private System.Windows.Forms.PictureBox pictureBoxBasePizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPepperoni;
        private System.Windows.Forms.Button button1Pepperoni;
        private System.Windows.Forms.PictureBox pictureBoxOnions;
        private System.Windows.Forms.Button removeTopping;
        private System.Windows.Forms.PictureBox pictureBoxCheese;
        private System.Windows.Forms.PictureBox pictureBoxTomato;
        private System.Windows.Forms.PictureBox pictureBoxMushrooms;
        private System.Windows.Forms.Button buttonAddMushroom;
        private System.Windows.Forms.Panel panel1;
    }
}

