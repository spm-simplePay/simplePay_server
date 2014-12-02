using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePay_Stammdaten.Tests
{
    [TestClass()]
    public class SimplePay_Stammdaten_UnitTest : SqlDatabaseTestClass
    {

        public SimplePay_Stammdaten_UnitTest()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void TableCountStammdaten()
        {
            SqlDatabaseTestActions testActions = this.TableCountStammdatenData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ColumnCountAdresse()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountAdresseData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ColumnCountHaendler()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountHaendlerData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ColumnCountHaendlerart()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountHaendlerartData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ColumnCountNutzer()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountNutzerData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ColumnCountNutzerart()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountNutzerartData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ColumnCountProvision()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountProvisionData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ConstraintFroeignKeyCount()
        {
            SqlDatabaseTestActions testActions = this.ConstraintFroeignKeyCountData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ConstraintUniqueCount()
        {
            SqlDatabaseTestActions testActions = this.ConstraintUniqueCountData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void ConstraintCheckCount()
        {
            SqlDatabaseTestActions testActions = this.ConstraintCheckCountData;
            // Skript für Vortest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Vortest-Skript wird ausgeführt...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Testskript ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Test-Skript wird ausgeführt...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Skript für Nachtest ausführen
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Nachtest-Skript wird ausgeführt...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }











        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction TableCountStammdaten_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplePay_Stammdaten_UnitTest));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountAdresse_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountHaendler_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountHaendlerart_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountNutzer_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountNutzerart_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountProvision_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ConstraintFroeignKeyCount_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ConstraintUniqueCount_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ConstraintCheckCount_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition10;
            this.TableCountStammdatenData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountAdresseData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountHaendlerData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountHaendlerartData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountNutzerData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountNutzerartData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountProvisionData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ConstraintFroeignKeyCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ConstraintUniqueCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ConstraintCheckCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            TableCountStammdaten_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountAdresse_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountHaendler_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountHaendlerart_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountNutzer_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountNutzerart_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountProvision_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ConstraintFroeignKeyCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ConstraintUniqueCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ConstraintCheckCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // TableCountStammdaten_TestAction
            // 
            TableCountStammdaten_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(TableCountStammdaten_TestAction, "TableCountStammdaten_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 6;
            // 
            // ColumnCountAdresse_TestAction
            // 
            ColumnCountAdresse_TestAction.Conditions.Add(rowCountCondition2);
            resources.ApplyResources(ColumnCountAdresse_TestAction, "ColumnCountAdresse_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 6;
            // 
            // ColumnCountHaendler_TestAction
            // 
            ColumnCountHaendler_TestAction.Conditions.Add(rowCountCondition3);
            resources.ApplyResources(ColumnCountHaendler_TestAction, "ColumnCountHaendler_TestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 6;
            // 
            // ColumnCountHaendlerart_TestAction
            // 
            ColumnCountHaendlerart_TestAction.Conditions.Add(rowCountCondition4);
            resources.ApplyResources(ColumnCountHaendlerart_TestAction, "ColumnCountHaendlerart_TestAction");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 3;
            // 
            // ColumnCountNutzer_TestAction
            // 
            ColumnCountNutzer_TestAction.Conditions.Add(rowCountCondition5);
            resources.ApplyResources(ColumnCountNutzer_TestAction, "ColumnCountNutzer_TestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 11;
            // 
            // ColumnCountNutzerart_TestAction
            // 
            ColumnCountNutzerart_TestAction.Conditions.Add(rowCountCondition6);
            resources.ApplyResources(ColumnCountNutzerart_TestAction, "ColumnCountNutzerart_TestAction");
            // 
            // rowCountCondition6
            // 
            rowCountCondition6.Enabled = true;
            rowCountCondition6.Name = "rowCountCondition6";
            rowCountCondition6.ResultSet = 1;
            rowCountCondition6.RowCount = 3;
            // 
            // ColumnCountProvision_TestAction
            // 
            ColumnCountProvision_TestAction.Conditions.Add(rowCountCondition7);
            resources.ApplyResources(ColumnCountProvision_TestAction, "ColumnCountProvision_TestAction");
            // 
            // rowCountCondition7
            // 
            rowCountCondition7.Enabled = true;
            rowCountCondition7.Name = "rowCountCondition7";
            rowCountCondition7.ResultSet = 1;
            rowCountCondition7.RowCount = 8;
            // 
            // TableCountStammdatenData
            // 
            this.TableCountStammdatenData.PosttestAction = null;
            this.TableCountStammdatenData.PretestAction = null;
            this.TableCountStammdatenData.TestAction = TableCountStammdaten_TestAction;
            // 
            // ColumnCountAdresseData
            // 
            this.ColumnCountAdresseData.PosttestAction = null;
            this.ColumnCountAdresseData.PretestAction = null;
            this.ColumnCountAdresseData.TestAction = ColumnCountAdresse_TestAction;
            // 
            // ColumnCountHaendlerData
            // 
            this.ColumnCountHaendlerData.PosttestAction = null;
            this.ColumnCountHaendlerData.PretestAction = null;
            this.ColumnCountHaendlerData.TestAction = ColumnCountHaendler_TestAction;
            // 
            // ColumnCountHaendlerartData
            // 
            this.ColumnCountHaendlerartData.PosttestAction = null;
            this.ColumnCountHaendlerartData.PretestAction = null;
            this.ColumnCountHaendlerartData.TestAction = ColumnCountHaendlerart_TestAction;
            // 
            // ColumnCountNutzerData
            // 
            this.ColumnCountNutzerData.PosttestAction = null;
            this.ColumnCountNutzerData.PretestAction = null;
            this.ColumnCountNutzerData.TestAction = ColumnCountNutzer_TestAction;
            // 
            // ColumnCountNutzerartData
            // 
            this.ColumnCountNutzerartData.PosttestAction = null;
            this.ColumnCountNutzerartData.PretestAction = null;
            this.ColumnCountNutzerartData.TestAction = ColumnCountNutzerart_TestAction;
            // 
            // ColumnCountProvisionData
            // 
            this.ColumnCountProvisionData.PosttestAction = null;
            this.ColumnCountProvisionData.PretestAction = null;
            this.ColumnCountProvisionData.TestAction = ColumnCountProvision_TestAction;
            // 
            // ConstraintFroeignKeyCountData
            // 
            this.ConstraintFroeignKeyCountData.PosttestAction = null;
            this.ConstraintFroeignKeyCountData.PretestAction = null;
            this.ConstraintFroeignKeyCountData.TestAction = ConstraintFroeignKeyCount_TestAction;
            // 
            // ConstraintFroeignKeyCount_TestAction
            // 
            ConstraintFroeignKeyCount_TestAction.Conditions.Add(rowCountCondition8);
            resources.ApplyResources(ConstraintFroeignKeyCount_TestAction, "ConstraintFroeignKeyCount_TestAction");
            // 
            // rowCountCondition8
            // 
            rowCountCondition8.Enabled = true;
            rowCountCondition8.Name = "rowCountCondition8";
            rowCountCondition8.ResultSet = 1;
            rowCountCondition8.RowCount = 5;
            // 
            // ConstraintUniqueCountData
            // 
            this.ConstraintUniqueCountData.PosttestAction = null;
            this.ConstraintUniqueCountData.PretestAction = null;
            this.ConstraintUniqueCountData.TestAction = ConstraintUniqueCount_TestAction;
            // 
            // ConstraintUniqueCount_TestAction
            // 
            ConstraintUniqueCount_TestAction.Conditions.Add(rowCountCondition9);
            resources.ApplyResources(ConstraintUniqueCount_TestAction, "ConstraintUniqueCount_TestAction");
            // 
            // rowCountCondition9
            // 
            rowCountCondition9.Enabled = true;
            rowCountCondition9.Name = "rowCountCondition9";
            rowCountCondition9.ResultSet = 1;
            rowCountCondition9.RowCount = 1;
            // 
            // ConstraintCheckCountData
            // 
            this.ConstraintCheckCountData.PosttestAction = null;
            this.ConstraintCheckCountData.PretestAction = null;
            this.ConstraintCheckCountData.TestAction = ConstraintCheckCount_TestAction;
            // 
            // ConstraintCheckCount_TestAction
            // 
            ConstraintCheckCount_TestAction.Conditions.Add(rowCountCondition10);
            resources.ApplyResources(ConstraintCheckCount_TestAction, "ConstraintCheckCount_TestAction");
            // 
            // rowCountCondition10
            // 
            rowCountCondition10.Enabled = true;
            rowCountCondition10.Name = "rowCountCondition10";
            rowCountCondition10.ResultSet = 1;
            rowCountCondition10.RowCount = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private SqlDatabaseTestActions TableCountStammdatenData;
        private SqlDatabaseTestActions ColumnCountAdresseData;
        private SqlDatabaseTestActions ColumnCountHaendlerData;
        private SqlDatabaseTestActions ColumnCountHaendlerartData;
        private SqlDatabaseTestActions ColumnCountNutzerData;
        private SqlDatabaseTestActions ColumnCountNutzerartData;
        private SqlDatabaseTestActions ColumnCountProvisionData;
        private SqlDatabaseTestActions ConstraintFroeignKeyCountData;
        private SqlDatabaseTestActions ConstraintUniqueCountData;
        private SqlDatabaseTestActions ConstraintCheckCountData;
    }
}
