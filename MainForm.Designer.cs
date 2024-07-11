namespace PAW
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBetsForUserByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUserGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userDOBDP = new System.Windows.Forms.DateTimePicker();
            this.userCNPTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.registerTeamGB = new System.Windows.Forms.GroupBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teamNameTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.registerUserButton = new System.Windows.Forms.Button();
            this.registerTeamButton = new System.Windows.Forms.Button();
            this.registerMatchButton = new System.Windows.Forms.Button();
            this.registerMatchGB = new System.Windows.Forms.GroupBox();
            this.teamB_CB = new System.Windows.Forms.ComboBox();
            this.teamA_CB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.matchDateDP = new System.Windows.Forms.DateTimePicker();
            this.placeBetButton = new System.Windows.Forms.Button();
            this.groupBetGB = new System.Windows.Forms.GroupBox();
            this.userID_CB = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.amountNumericUD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.matchComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.winnerTB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.registerUserGB.SuspendLayout();
            this.registerTeamGB.SuspendLayout();
            this.registerMatchGB.SuspendLayout();
            this.groupBetGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            resources.ApplyResources(this.analysisToolStripMenuItem, "analysisToolStripMenuItem");
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBetsForUserByIDToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            // 
            // showBetsForUserByIDToolStripMenuItem
            // 
            resources.ApplyResources(this.showBetsForUserByIDToolStripMenuItem, "showBetsForUserByIDToolStripMenuItem");
            this.showBetsForUserByIDToolStripMenuItem.Name = "showBetsForUserByIDToolStripMenuItem";
            this.showBetsForUserByIDToolStripMenuItem.Click += new System.EventHandler(this.showBetsForUserByIDToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.matchesToolStripMenuItem,
            this.betsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // usersToolStripMenuItem
            // 
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            resources.ApplyResources(this.teamsToolStripMenuItem, "teamsToolStripMenuItem");
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Click += new System.EventHandler(this.teamsToolStripMenuItem_Click);
            // 
            // matchesToolStripMenuItem
            // 
            resources.ApplyResources(this.matchesToolStripMenuItem, "matchesToolStripMenuItem");
            this.matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            this.matchesToolStripMenuItem.Click += new System.EventHandler(this.matchesToolStripMenuItem_Click);
            // 
            // betsToolStripMenuItem
            // 
            resources.ApplyResources(this.betsToolStripMenuItem, "betsToolStripMenuItem");
            this.betsToolStripMenuItem.Name = "betsToolStripMenuItem";
            this.betsToolStripMenuItem.Click += new System.EventHandler(this.betsToolStripMenuItem_Click);
            // 
            // registerUserGB
            // 
            resources.ApplyResources(this.registerUserGB, "registerUserGB");
            this.registerUserGB.Controls.Add(this.label3);
            this.registerUserGB.Controls.Add(this.label2);
            this.registerUserGB.Controls.Add(this.label1);
            this.registerUserGB.Controls.Add(this.userDOBDP);
            this.registerUserGB.Controls.Add(this.userCNPTB);
            this.registerUserGB.Controls.Add(this.userNameTB);
            this.registerUserGB.Name = "registerUserGB";
            this.registerUserGB.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // userDOBDP
            // 
            resources.ApplyResources(this.userDOBDP, "userDOBDP");
            this.userDOBDP.Name = "userDOBDP";
            // 
            // userCNPTB
            // 
            resources.ApplyResources(this.userCNPTB, "userCNPTB");
            this.userCNPTB.Name = "userCNPTB";
            // 
            // userNameTB
            // 
            resources.ApplyResources(this.userNameTB, "userNameTB");
            this.userNameTB.Name = "userNameTB";
            // 
            // registerTeamGB
            // 
            resources.ApplyResources(this.registerTeamGB, "registerTeamGB");
            this.registerTeamGB.Controls.Add(this.countryComboBox);
            this.registerTeamGB.Controls.Add(this.label4);
            this.registerTeamGB.Controls.Add(this.label5);
            this.registerTeamGB.Controls.Add(this.teamNameTB);
            this.registerTeamGB.Name = "registerTeamGB";
            this.registerTeamGB.TabStop = false;
            // 
            // countryComboBox
            // 
            resources.ApplyResources(this.countryComboBox, "countryComboBox");
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            resources.GetString("countryComboBox.Items"),
            resources.GetString("countryComboBox.Items1"),
            resources.GetString("countryComboBox.Items2"),
            resources.GetString("countryComboBox.Items3"),
            resources.GetString("countryComboBox.Items4"),
            resources.GetString("countryComboBox.Items5"),
            resources.GetString("countryComboBox.Items6"),
            resources.GetString("countryComboBox.Items7"),
            resources.GetString("countryComboBox.Items8"),
            resources.GetString("countryComboBox.Items9"),
            resources.GetString("countryComboBox.Items10"),
            resources.GetString("countryComboBox.Items11"),
            resources.GetString("countryComboBox.Items12"),
            resources.GetString("countryComboBox.Items13"),
            resources.GetString("countryComboBox.Items14"),
            resources.GetString("countryComboBox.Items15"),
            resources.GetString("countryComboBox.Items16"),
            resources.GetString("countryComboBox.Items17"),
            resources.GetString("countryComboBox.Items18"),
            resources.GetString("countryComboBox.Items19"),
            resources.GetString("countryComboBox.Items20"),
            resources.GetString("countryComboBox.Items21"),
            resources.GetString("countryComboBox.Items22"),
            resources.GetString("countryComboBox.Items23"),
            resources.GetString("countryComboBox.Items24"),
            resources.GetString("countryComboBox.Items25"),
            resources.GetString("countryComboBox.Items26"),
            resources.GetString("countryComboBox.Items27"),
            resources.GetString("countryComboBox.Items28"),
            resources.GetString("countryComboBox.Items29"),
            resources.GetString("countryComboBox.Items30"),
            resources.GetString("countryComboBox.Items31"),
            resources.GetString("countryComboBox.Items32"),
            resources.GetString("countryComboBox.Items33"),
            resources.GetString("countryComboBox.Items34"),
            resources.GetString("countryComboBox.Items35"),
            resources.GetString("countryComboBox.Items36"),
            resources.GetString("countryComboBox.Items37"),
            resources.GetString("countryComboBox.Items38"),
            resources.GetString("countryComboBox.Items39"),
            resources.GetString("countryComboBox.Items40"),
            resources.GetString("countryComboBox.Items41"),
            resources.GetString("countryComboBox.Items42"),
            resources.GetString("countryComboBox.Items43"),
            resources.GetString("countryComboBox.Items44"),
            resources.GetString("countryComboBox.Items45"),
            resources.GetString("countryComboBox.Items46"),
            resources.GetString("countryComboBox.Items47"),
            resources.GetString("countryComboBox.Items48"),
            resources.GetString("countryComboBox.Items49"),
            resources.GetString("countryComboBox.Items50"),
            resources.GetString("countryComboBox.Items51"),
            resources.GetString("countryComboBox.Items52"),
            resources.GetString("countryComboBox.Items53"),
            resources.GetString("countryComboBox.Items54"),
            resources.GetString("countryComboBox.Items55"),
            resources.GetString("countryComboBox.Items56"),
            resources.GetString("countryComboBox.Items57"),
            resources.GetString("countryComboBox.Items58"),
            resources.GetString("countryComboBox.Items59"),
            resources.GetString("countryComboBox.Items60"),
            resources.GetString("countryComboBox.Items61"),
            resources.GetString("countryComboBox.Items62"),
            resources.GetString("countryComboBox.Items63"),
            resources.GetString("countryComboBox.Items64"),
            resources.GetString("countryComboBox.Items65"),
            resources.GetString("countryComboBox.Items66"),
            resources.GetString("countryComboBox.Items67"),
            resources.GetString("countryComboBox.Items68"),
            resources.GetString("countryComboBox.Items69"),
            resources.GetString("countryComboBox.Items70"),
            resources.GetString("countryComboBox.Items71"),
            resources.GetString("countryComboBox.Items72"),
            resources.GetString("countryComboBox.Items73"),
            resources.GetString("countryComboBox.Items74"),
            resources.GetString("countryComboBox.Items75"),
            resources.GetString("countryComboBox.Items76"),
            resources.GetString("countryComboBox.Items77"),
            resources.GetString("countryComboBox.Items78"),
            resources.GetString("countryComboBox.Items79"),
            resources.GetString("countryComboBox.Items80"),
            resources.GetString("countryComboBox.Items81"),
            resources.GetString("countryComboBox.Items82"),
            resources.GetString("countryComboBox.Items83"),
            resources.GetString("countryComboBox.Items84"),
            resources.GetString("countryComboBox.Items85"),
            resources.GetString("countryComboBox.Items86"),
            resources.GetString("countryComboBox.Items87"),
            resources.GetString("countryComboBox.Items88"),
            resources.GetString("countryComboBox.Items89"),
            resources.GetString("countryComboBox.Items90"),
            resources.GetString("countryComboBox.Items91"),
            resources.GetString("countryComboBox.Items92"),
            resources.GetString("countryComboBox.Items93"),
            resources.GetString("countryComboBox.Items94"),
            resources.GetString("countryComboBox.Items95"),
            resources.GetString("countryComboBox.Items96"),
            resources.GetString("countryComboBox.Items97"),
            resources.GetString("countryComboBox.Items98"),
            resources.GetString("countryComboBox.Items99"),
            resources.GetString("countryComboBox.Items100"),
            resources.GetString("countryComboBox.Items101"),
            resources.GetString("countryComboBox.Items102"),
            resources.GetString("countryComboBox.Items103"),
            resources.GetString("countryComboBox.Items104"),
            resources.GetString("countryComboBox.Items105"),
            resources.GetString("countryComboBox.Items106"),
            resources.GetString("countryComboBox.Items107"),
            resources.GetString("countryComboBox.Items108"),
            resources.GetString("countryComboBox.Items109"),
            resources.GetString("countryComboBox.Items110"),
            resources.GetString("countryComboBox.Items111"),
            resources.GetString("countryComboBox.Items112"),
            resources.GetString("countryComboBox.Items113"),
            resources.GetString("countryComboBox.Items114"),
            resources.GetString("countryComboBox.Items115"),
            resources.GetString("countryComboBox.Items116"),
            resources.GetString("countryComboBox.Items117"),
            resources.GetString("countryComboBox.Items118"),
            resources.GetString("countryComboBox.Items119"),
            resources.GetString("countryComboBox.Items120"),
            resources.GetString("countryComboBox.Items121"),
            resources.GetString("countryComboBox.Items122"),
            resources.GetString("countryComboBox.Items123"),
            resources.GetString("countryComboBox.Items124"),
            resources.GetString("countryComboBox.Items125"),
            resources.GetString("countryComboBox.Items126"),
            resources.GetString("countryComboBox.Items127"),
            resources.GetString("countryComboBox.Items128"),
            resources.GetString("countryComboBox.Items129"),
            resources.GetString("countryComboBox.Items130"),
            resources.GetString("countryComboBox.Items131"),
            resources.GetString("countryComboBox.Items132"),
            resources.GetString("countryComboBox.Items133"),
            resources.GetString("countryComboBox.Items134"),
            resources.GetString("countryComboBox.Items135"),
            resources.GetString("countryComboBox.Items136"),
            resources.GetString("countryComboBox.Items137"),
            resources.GetString("countryComboBox.Items138"),
            resources.GetString("countryComboBox.Items139"),
            resources.GetString("countryComboBox.Items140"),
            resources.GetString("countryComboBox.Items141"),
            resources.GetString("countryComboBox.Items142"),
            resources.GetString("countryComboBox.Items143"),
            resources.GetString("countryComboBox.Items144"),
            resources.GetString("countryComboBox.Items145"),
            resources.GetString("countryComboBox.Items146"),
            resources.GetString("countryComboBox.Items147"),
            resources.GetString("countryComboBox.Items148"),
            resources.GetString("countryComboBox.Items149"),
            resources.GetString("countryComboBox.Items150"),
            resources.GetString("countryComboBox.Items151"),
            resources.GetString("countryComboBox.Items152"),
            resources.GetString("countryComboBox.Items153"),
            resources.GetString("countryComboBox.Items154"),
            resources.GetString("countryComboBox.Items155"),
            resources.GetString("countryComboBox.Items156"),
            resources.GetString("countryComboBox.Items157"),
            resources.GetString("countryComboBox.Items158"),
            resources.GetString("countryComboBox.Items159"),
            resources.GetString("countryComboBox.Items160"),
            resources.GetString("countryComboBox.Items161"),
            resources.GetString("countryComboBox.Items162"),
            resources.GetString("countryComboBox.Items163"),
            resources.GetString("countryComboBox.Items164"),
            resources.GetString("countryComboBox.Items165"),
            resources.GetString("countryComboBox.Items166"),
            resources.GetString("countryComboBox.Items167"),
            resources.GetString("countryComboBox.Items168"),
            resources.GetString("countryComboBox.Items169"),
            resources.GetString("countryComboBox.Items170"),
            resources.GetString("countryComboBox.Items171"),
            resources.GetString("countryComboBox.Items172"),
            resources.GetString("countryComboBox.Items173"),
            resources.GetString("countryComboBox.Items174"),
            resources.GetString("countryComboBox.Items175"),
            resources.GetString("countryComboBox.Items176"),
            resources.GetString("countryComboBox.Items177"),
            resources.GetString("countryComboBox.Items178"),
            resources.GetString("countryComboBox.Items179"),
            resources.GetString("countryComboBox.Items180"),
            resources.GetString("countryComboBox.Items181"),
            resources.GetString("countryComboBox.Items182"),
            resources.GetString("countryComboBox.Items183"),
            resources.GetString("countryComboBox.Items184"),
            resources.GetString("countryComboBox.Items185"),
            resources.GetString("countryComboBox.Items186"),
            resources.GetString("countryComboBox.Items187"),
            resources.GetString("countryComboBox.Items188"),
            resources.GetString("countryComboBox.Items189"),
            resources.GetString("countryComboBox.Items190"),
            resources.GetString("countryComboBox.Items191"),
            resources.GetString("countryComboBox.Items192"),
            resources.GetString("countryComboBox.Items193"),
            resources.GetString("countryComboBox.Items194"),
            resources.GetString("countryComboBox.Items195"),
            resources.GetString("countryComboBox.Items196"),
            resources.GetString("countryComboBox.Items197"),
            resources.GetString("countryComboBox.Items198"),
            resources.GetString("countryComboBox.Items199"),
            resources.GetString("countryComboBox.Items200"),
            resources.GetString("countryComboBox.Items201"),
            resources.GetString("countryComboBox.Items202"),
            resources.GetString("countryComboBox.Items203"),
            resources.GetString("countryComboBox.Items204"),
            resources.GetString("countryComboBox.Items205"),
            resources.GetString("countryComboBox.Items206"),
            resources.GetString("countryComboBox.Items207"),
            resources.GetString("countryComboBox.Items208"),
            resources.GetString("countryComboBox.Items209"),
            resources.GetString("countryComboBox.Items210"),
            resources.GetString("countryComboBox.Items211"),
            resources.GetString("countryComboBox.Items212"),
            resources.GetString("countryComboBox.Items213"),
            resources.GetString("countryComboBox.Items214"),
            resources.GetString("countryComboBox.Items215"),
            resources.GetString("countryComboBox.Items216"),
            resources.GetString("countryComboBox.Items217"),
            resources.GetString("countryComboBox.Items218"),
            resources.GetString("countryComboBox.Items219"),
            resources.GetString("countryComboBox.Items220"),
            resources.GetString("countryComboBox.Items221"),
            resources.GetString("countryComboBox.Items222"),
            resources.GetString("countryComboBox.Items223"),
            resources.GetString("countryComboBox.Items224"),
            resources.GetString("countryComboBox.Items225"),
            resources.GetString("countryComboBox.Items226"),
            resources.GetString("countryComboBox.Items227"),
            resources.GetString("countryComboBox.Items228"),
            resources.GetString("countryComboBox.Items229"),
            resources.GetString("countryComboBox.Items230"),
            resources.GetString("countryComboBox.Items231"),
            resources.GetString("countryComboBox.Items232"),
            resources.GetString("countryComboBox.Items233"),
            resources.GetString("countryComboBox.Items234"),
            resources.GetString("countryComboBox.Items235"),
            resources.GetString("countryComboBox.Items236"),
            resources.GetString("countryComboBox.Items237"),
            resources.GetString("countryComboBox.Items238"),
            resources.GetString("countryComboBox.Items239"),
            resources.GetString("countryComboBox.Items240"),
            resources.GetString("countryComboBox.Items241"),
            resources.GetString("countryComboBox.Items242"),
            resources.GetString("countryComboBox.Items243"),
            resources.GetString("countryComboBox.Items244"),
            resources.GetString("countryComboBox.Items245"),
            resources.GetString("countryComboBox.Items246"),
            resources.GetString("countryComboBox.Items247"),
            resources.GetString("countryComboBox.Items248"),
            resources.GetString("countryComboBox.Items249"),
            resources.GetString("countryComboBox.Items250"),
            resources.GetString("countryComboBox.Items251"),
            resources.GetString("countryComboBox.Items252"),
            resources.GetString("countryComboBox.Items253"),
            resources.GetString("countryComboBox.Items254"),
            resources.GetString("countryComboBox.Items255")});
            this.countryComboBox.Name = "countryComboBox";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // teamNameTB
            // 
            resources.ApplyResources(this.teamNameTB, "teamNameTB");
            this.teamNameTB.Name = "teamNameTB";
            // 
            // registerUserButton
            // 
            resources.ApplyResources(this.registerUserButton, "registerUserButton");
            this.registerUserButton.Name = "registerUserButton";
            this.registerUserButton.UseVisualStyleBackColor = true;
            this.registerUserButton.Click += new System.EventHandler(this.registerUserButton_Click);
            // 
            // registerTeamButton
            // 
            resources.ApplyResources(this.registerTeamButton, "registerTeamButton");
            this.registerTeamButton.Name = "registerTeamButton";
            this.registerTeamButton.UseVisualStyleBackColor = true;
            this.registerTeamButton.Click += new System.EventHandler(this.registerTeamButton_Click);
            // 
            // registerMatchButton
            // 
            resources.ApplyResources(this.registerMatchButton, "registerMatchButton");
            this.registerMatchButton.Name = "registerMatchButton";
            this.registerMatchButton.UseVisualStyleBackColor = true;
            this.registerMatchButton.Click += new System.EventHandler(this.registerMatchButton_Click);
            // 
            // registerMatchGB
            // 
            resources.ApplyResources(this.registerMatchGB, "registerMatchGB");
            this.registerMatchGB.Controls.Add(this.teamB_CB);
            this.registerMatchGB.Controls.Add(this.teamA_CB);
            this.registerMatchGB.Controls.Add(this.label6);
            this.registerMatchGB.Controls.Add(this.label7);
            this.registerMatchGB.Controls.Add(this.label8);
            this.registerMatchGB.Controls.Add(this.matchDateDP);
            this.registerMatchGB.Name = "registerMatchGB";
            this.registerMatchGB.TabStop = false;
            // 
            // teamB_CB
            // 
            resources.ApplyResources(this.teamB_CB, "teamB_CB");
            this.teamB_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.teamB_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teamB_CB.FormattingEnabled = true;
            this.teamB_CB.Name = "teamB_CB";
            // 
            // teamA_CB
            // 
            resources.ApplyResources(this.teamA_CB, "teamA_CB");
            this.teamA_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.teamA_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.teamA_CB.FormattingEnabled = true;
            this.teamA_CB.Name = "teamA_CB";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // matchDateDP
            // 
            resources.ApplyResources(this.matchDateDP, "matchDateDP");
            this.matchDateDP.Name = "matchDateDP";
            // 
            // placeBetButton
            // 
            resources.ApplyResources(this.placeBetButton, "placeBetButton");
            this.placeBetButton.Name = "placeBetButton";
            this.placeBetButton.UseVisualStyleBackColor = true;
            this.placeBetButton.Click += new System.EventHandler(this.placeBetButton_Click);
            // 
            // groupBetGB
            // 
            resources.ApplyResources(this.groupBetGB, "groupBetGB");
            this.groupBetGB.Controls.Add(this.userID_CB);
            this.groupBetGB.Controls.Add(this.label12);
            this.groupBetGB.Controls.Add(this.amountNumericUD);
            this.groupBetGB.Controls.Add(this.label9);
            this.groupBetGB.Controls.Add(this.matchComboBox);
            this.groupBetGB.Controls.Add(this.label10);
            this.groupBetGB.Controls.Add(this.label11);
            this.groupBetGB.Controls.Add(this.winnerTB);
            this.groupBetGB.Name = "groupBetGB";
            this.groupBetGB.TabStop = false;
            // 
            // userID_CB
            // 
            resources.ApplyResources(this.userID_CB, "userID_CB");
            this.userID_CB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.userID_CB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userID_CB.FormattingEnabled = true;
            this.userID_CB.Name = "userID_CB";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // amountNumericUD
            // 
            resources.ApplyResources(this.amountNumericUD, "amountNumericUD");
            this.amountNumericUD.Name = "amountNumericUD";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // matchComboBox
            // 
            resources.ApplyResources(this.matchComboBox, "matchComboBox");
            this.matchComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.matchComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.matchComboBox.FormattingEnabled = true;
            this.matchComboBox.Name = "matchComboBox";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // winnerTB
            // 
            resources.ApplyResources(this.winnerTB, "winnerTB");
            this.winnerTB.Name = "winnerTB";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.placeBetButton);
            this.Controls.Add(this.registerMatchButton);
            this.Controls.Add(this.groupBetGB);
            this.Controls.Add(this.registerTeamButton);
            this.Controls.Add(this.registerMatchGB);
            this.Controls.Add(this.registerUserButton);
            this.Controls.Add(this.registerTeamGB);
            this.Controls.Add(this.registerUserGB);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.registerUserGB.ResumeLayout(false);
            this.registerUserGB.PerformLayout();
            this.registerTeamGB.ResumeLayout(false);
            this.registerTeamGB.PerformLayout();
            this.registerMatchGB.ResumeLayout(false);
            this.registerMatchGB.PerformLayout();
            this.groupBetGB.ResumeLayout(false);
            this.groupBetGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox registerUserGB;
        private System.Windows.Forms.TextBox userCNPTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.DateTimePicker userDOBDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox registerTeamGB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teamNameTB;
        private System.Windows.Forms.Button registerUserButton;
        private System.Windows.Forms.Button registerTeamButton;
        private System.Windows.Forms.Button registerMatchButton;
        private System.Windows.Forms.GroupBox registerMatchGB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker matchDateDP;
        private System.Windows.Forms.Button placeBetButton;
        private System.Windows.Forms.GroupBox groupBetGB;
        private System.Windows.Forms.ComboBox matchComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox winnerTB;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betsToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown amountNumericUD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox teamB_CB;
        private System.Windows.Forms.ComboBox teamA_CB;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ComboBox userID_CB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem showBetsForUserByIDToolStripMenuItem;
    }
}