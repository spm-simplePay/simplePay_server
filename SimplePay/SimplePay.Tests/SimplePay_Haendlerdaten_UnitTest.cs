using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePay.Tests
{
    [TestClass()]
    public class SimplePay_Haendlerdaten_UnitTest : SqlDatabaseTestClass
    {

        public SimplePay_Haendlerdaten_UnitTest()
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
        public void TableCountHaendlerdaten()
        {
            SqlDatabaseTestActions testActions = this.TableCountHaendlerdatenData;
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
        public void ColumnCountProdukt()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountProduktData;
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
        public void ColumnCountBestellposition()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountBestellpositionData;
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
        public void ColumnCountBestellung()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountBestellungData;
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
        public void ColumnCountKategorie()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountKategorieData;
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
        public void ColumnCountKunde()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountKundeData;
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
        public void ColumnCountKunde_Tisch()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountKunde_TischData;
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
        public void ColumnCountMitarbeiter()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountMitarbeiterData;
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
        public void ColumnCountMwSt_Satz()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountMwSt_SatzData;
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
        public void ColumnCountProdukt_Kategorie()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountProdukt_KategorieData;
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
        public void ColumnCountProdukt_Zusatz()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountProdukt_ZusatzData;
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
        public void ColumnCountRechnung()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountRechnungData;
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
        public void ColumnCountRolle()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountRolleData;
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
        public void ColumnCountTisch()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountTischData;
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
        public void ColumnCountZusatz()
        {
            SqlDatabaseTestActions testActions = this.ColumnCountZusatzData;
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
        public void ContraintsForeignKeyCount()
        {
            SqlDatabaseTestActions testActions = this.ContraintsForeignKeyCountData;
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction TableCountHaendlerdaten_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimplePay_Haendlerdaten_UnitTest));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountProdukt_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountBestellposition_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountBestellung_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountKategorie_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountKunde_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountKunde_Tisch_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountMitarbeiter_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountMwSt_Satz_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountProdukt_Kategorie_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountProdukt_Zusatz_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountRechnung_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountRolle_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition13;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountTisch_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition14;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ColumnCountZusatz_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition15;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition16;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ContraintsForeignKeyCount_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition17;
            this.TableCountHaendlerdatenData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountProduktData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountBestellpositionData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountBestellungData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountKategorieData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountKundeData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountKunde_TischData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountMitarbeiterData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountMwSt_SatzData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountProdukt_KategorieData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountProdukt_ZusatzData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountRechnungData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountRolleData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountTischData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ColumnCountZusatzData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ContraintsForeignKeyCountData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            TableCountHaendlerdaten_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountProdukt_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountBestellposition_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountBestellung_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountKategorie_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountKunde_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountKunde_Tisch_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountMitarbeiter_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountMwSt_Satz_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountProdukt_Kategorie_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountProdukt_Zusatz_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountRechnung_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountRolle_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition13 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountTisch_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition14 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ColumnCountZusatz_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition15 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition16 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            ContraintsForeignKeyCount_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition17 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // TableCountHaendlerdaten_TestAction
            // 
            TableCountHaendlerdaten_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(TableCountHaendlerdaten_TestAction, "TableCountHaendlerdaten_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 16;
            // 
            // ColumnCountProdukt_TestAction
            // 
            ColumnCountProdukt_TestAction.Conditions.Add(rowCountCondition2);
            resources.ApplyResources(ColumnCountProdukt_TestAction, "ColumnCountProdukt_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 6;
            // 
            // ColumnCountBestellposition_TestAction
            // 
            ColumnCountBestellposition_TestAction.Conditions.Add(rowCountCondition3);
            resources.ApplyResources(ColumnCountBestellposition_TestAction, "ColumnCountBestellposition_TestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 6;
            // 
            // ColumnCountBestellung_TestAction
            // 
            ColumnCountBestellung_TestAction.Conditions.Add(rowCountCondition4);
            resources.ApplyResources(ColumnCountBestellung_TestAction, "ColumnCountBestellung_TestAction");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 7;
            // 
            // ColumnCountKategorie_TestAction
            // 
            ColumnCountKategorie_TestAction.Conditions.Add(rowCountCondition5);
            resources.ApplyResources(ColumnCountKategorie_TestAction, "ColumnCountKategorie_TestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 4;
            // 
            // ColumnCountKunde_TestAction
            // 
            ColumnCountKunde_TestAction.Conditions.Add(rowCountCondition6);
            resources.ApplyResources(ColumnCountKunde_TestAction, "ColumnCountKunde_TestAction");
            // 
            // rowCountCondition6
            // 
            rowCountCondition6.Enabled = true;
            rowCountCondition6.Name = "rowCountCondition6";
            rowCountCondition6.ResultSet = 1;
            rowCountCondition6.RowCount = 2;
            // 
            // ColumnCountKunde_Tisch_TestAction
            // 
            ColumnCountKunde_Tisch_TestAction.Conditions.Add(rowCountCondition7);
            resources.ApplyResources(ColumnCountKunde_Tisch_TestAction, "ColumnCountKunde_Tisch_TestAction");
            // 
            // rowCountCondition7
            // 
            rowCountCondition7.Enabled = true;
            rowCountCondition7.Name = "rowCountCondition7";
            rowCountCondition7.ResultSet = 1;
            rowCountCondition7.RowCount = 3;
            // 
            // ColumnCountMitarbeiter_TestAction
            // 
            ColumnCountMitarbeiter_TestAction.Conditions.Add(rowCountCondition8);
            resources.ApplyResources(ColumnCountMitarbeiter_TestAction, "ColumnCountMitarbeiter_TestAction");
            // 
            // rowCountCondition8
            // 
            rowCountCondition8.Enabled = true;
            rowCountCondition8.Name = "rowCountCondition8";
            rowCountCondition8.ResultSet = 1;
            rowCountCondition8.RowCount = 8;
            // 
            // ColumnCountMwSt_Satz_TestAction
            // 
            ColumnCountMwSt_Satz_TestAction.Conditions.Add(rowCountCondition9);
            resources.ApplyResources(ColumnCountMwSt_Satz_TestAction, "ColumnCountMwSt_Satz_TestAction");
            // 
            // rowCountCondition9
            // 
            rowCountCondition9.Enabled = true;
            rowCountCondition9.Name = "rowCountCondition9";
            rowCountCondition9.ResultSet = 1;
            rowCountCondition9.RowCount = 4;
            // 
            // ColumnCountProdukt_Kategorie_TestAction
            // 
            ColumnCountProdukt_Kategorie_TestAction.Conditions.Add(rowCountCondition10);
            resources.ApplyResources(ColumnCountProdukt_Kategorie_TestAction, "ColumnCountProdukt_Kategorie_TestAction");
            // 
            // rowCountCondition10
            // 
            rowCountCondition10.Enabled = true;
            rowCountCondition10.Name = "rowCountCondition10";
            rowCountCondition10.ResultSet = 1;
            rowCountCondition10.RowCount = 3;
            // 
            // ColumnCountProdukt_Zusatz_TestAction
            // 
            ColumnCountProdukt_Zusatz_TestAction.Conditions.Add(rowCountCondition11);
            resources.ApplyResources(ColumnCountProdukt_Zusatz_TestAction, "ColumnCountProdukt_Zusatz_TestAction");
            // 
            // rowCountCondition11
            // 
            rowCountCondition11.Enabled = true;
            rowCountCondition11.Name = "rowCountCondition11";
            rowCountCondition11.ResultSet = 1;
            rowCountCondition11.RowCount = 3;
            // 
            // ColumnCountRechnung_TestAction
            // 
            ColumnCountRechnung_TestAction.Conditions.Add(rowCountCondition12);
            resources.ApplyResources(ColumnCountRechnung_TestAction, "ColumnCountRechnung_TestAction");
            // 
            // rowCountCondition12
            // 
            rowCountCondition12.Enabled = true;
            rowCountCondition12.Name = "rowCountCondition12";
            rowCountCondition12.ResultSet = 1;
            rowCountCondition12.RowCount = 5;
            // 
            // ColumnCountRolle_TestAction
            // 
            ColumnCountRolle_TestAction.Conditions.Add(rowCountCondition13);
            resources.ApplyResources(ColumnCountRolle_TestAction, "ColumnCountRolle_TestAction");
            // 
            // rowCountCondition13
            // 
            rowCountCondition13.Enabled = true;
            rowCountCondition13.Name = "rowCountCondition13";
            rowCountCondition13.ResultSet = 1;
            rowCountCondition13.RowCount = 3;
            // 
            // ColumnCountTisch_TestAction
            // 
            ColumnCountTisch_TestAction.Conditions.Add(rowCountCondition14);
            resources.ApplyResources(ColumnCountTisch_TestAction, "ColumnCountTisch_TestAction");
            // 
            // rowCountCondition14
            // 
            rowCountCondition14.Enabled = true;
            rowCountCondition14.Name = "rowCountCondition14";
            rowCountCondition14.ResultSet = 1;
            rowCountCondition14.RowCount = 3;
            // 
            // ColumnCountZusatz_TestAction
            // 
            ColumnCountZusatz_TestAction.Conditions.Add(rowCountCondition15);
            resources.ApplyResources(ColumnCountZusatz_TestAction, "ColumnCountZusatz_TestAction");
            // 
            // rowCountCondition15
            // 
            rowCountCondition15.Enabled = true;
            rowCountCondition15.Name = "rowCountCondition15";
            rowCountCondition15.ResultSet = 1;
            rowCountCondition15.RowCount = 4;
            // 
            // TableCountHaendlerdatenData
            // 
            this.TableCountHaendlerdatenData.PosttestAction = null;
            this.TableCountHaendlerdatenData.PretestAction = null;
            this.TableCountHaendlerdatenData.TestAction = TableCountHaendlerdaten_TestAction;
            // 
            // ColumnCountProduktData
            // 
            this.ColumnCountProduktData.PosttestAction = null;
            this.ColumnCountProduktData.PretestAction = null;
            this.ColumnCountProduktData.TestAction = ColumnCountProdukt_TestAction;
            // 
            // ColumnCountBestellpositionData
            // 
            this.ColumnCountBestellpositionData.PosttestAction = null;
            this.ColumnCountBestellpositionData.PretestAction = null;
            this.ColumnCountBestellpositionData.TestAction = ColumnCountBestellposition_TestAction;
            // 
            // ColumnCountBestellungData
            // 
            this.ColumnCountBestellungData.PosttestAction = null;
            this.ColumnCountBestellungData.PretestAction = null;
            this.ColumnCountBestellungData.TestAction = ColumnCountBestellung_TestAction;
            // 
            // ColumnCountKategorieData
            // 
            this.ColumnCountKategorieData.PosttestAction = null;
            this.ColumnCountKategorieData.PretestAction = null;
            this.ColumnCountKategorieData.TestAction = ColumnCountKategorie_TestAction;
            // 
            // ColumnCountKundeData
            // 
            this.ColumnCountKundeData.PosttestAction = null;
            this.ColumnCountKundeData.PretestAction = null;
            this.ColumnCountKundeData.TestAction = ColumnCountKunde_TestAction;
            // 
            // ColumnCountKunde_TischData
            // 
            this.ColumnCountKunde_TischData.PosttestAction = null;
            this.ColumnCountKunde_TischData.PretestAction = null;
            this.ColumnCountKunde_TischData.TestAction = ColumnCountKunde_Tisch_TestAction;
            // 
            // ColumnCountMitarbeiterData
            // 
            this.ColumnCountMitarbeiterData.PosttestAction = null;
            this.ColumnCountMitarbeiterData.PretestAction = null;
            this.ColumnCountMitarbeiterData.TestAction = ColumnCountMitarbeiter_TestAction;
            // 
            // ColumnCountMwSt_SatzData
            // 
            this.ColumnCountMwSt_SatzData.PosttestAction = null;
            this.ColumnCountMwSt_SatzData.PretestAction = null;
            this.ColumnCountMwSt_SatzData.TestAction = ColumnCountMwSt_Satz_TestAction;
            // 
            // ColumnCountProdukt_KategorieData
            // 
            this.ColumnCountProdukt_KategorieData.PosttestAction = null;
            this.ColumnCountProdukt_KategorieData.PretestAction = null;
            this.ColumnCountProdukt_KategorieData.TestAction = ColumnCountProdukt_Kategorie_TestAction;
            // 
            // ColumnCountProdukt_ZusatzData
            // 
            this.ColumnCountProdukt_ZusatzData.PosttestAction = null;
            this.ColumnCountProdukt_ZusatzData.PretestAction = null;
            this.ColumnCountProdukt_ZusatzData.TestAction = ColumnCountProdukt_Zusatz_TestAction;
            // 
            // ColumnCountRechnungData
            // 
            this.ColumnCountRechnungData.PosttestAction = null;
            this.ColumnCountRechnungData.PretestAction = null;
            this.ColumnCountRechnungData.TestAction = ColumnCountRechnung_TestAction;
            // 
            // ColumnCountRolleData
            // 
            this.ColumnCountRolleData.PosttestAction = null;
            this.ColumnCountRolleData.PretestAction = null;
            this.ColumnCountRolleData.TestAction = ColumnCountRolle_TestAction;
            // 
            // ColumnCountTischData
            // 
            this.ColumnCountTischData.PosttestAction = null;
            this.ColumnCountTischData.PretestAction = null;
            this.ColumnCountTischData.TestAction = ColumnCountTisch_TestAction;
            // 
            // ColumnCountZusatzData
            // 
            this.ColumnCountZusatzData.PosttestAction = null;
            this.ColumnCountZusatzData.PretestAction = null;
            this.ColumnCountZusatzData.TestAction = ColumnCountZusatz_TestAction;
            // 
            // testInitializeAction
            // 
            testInitializeAction.Conditions.Add(rowCountCondition16);
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // rowCountCondition16
            // 
            rowCountCondition16.Enabled = true;
            rowCountCondition16.Name = "rowCountCondition16";
            rowCountCondition16.ResultSet = 1;
            rowCountCondition16.RowCount = 16;
            // 
            // ContraintsForeignKeyCountData
            // 
            this.ContraintsForeignKeyCountData.PosttestAction = null;
            this.ContraintsForeignKeyCountData.PretestAction = null;
            this.ContraintsForeignKeyCountData.TestAction = ContraintsForeignKeyCount_TestAction;
            // 
            // ContraintsForeignKeyCount_TestAction
            // 
            ContraintsForeignKeyCount_TestAction.Conditions.Add(rowCountCondition17);
            resources.ApplyResources(ContraintsForeignKeyCount_TestAction, "ContraintsForeignKeyCount_TestAction");
            // 
            // rowCountCondition17
            // 
            rowCountCondition17.Enabled = true;
            rowCountCondition17.Name = "rowCountCondition17";
            rowCountCondition17.ResultSet = 1;
            rowCountCondition17.RowCount = 16;
            // 
            // SimplePay_Haendlerdaten_UnitTest
            // 
            this.TestInitializeAction = testInitializeAction;
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

        private SqlDatabaseTestActions TableCountHaendlerdatenData;
        private SqlDatabaseTestActions ColumnCountProduktData;
        private SqlDatabaseTestActions ColumnCountBestellpositionData;
        private SqlDatabaseTestActions ColumnCountBestellungData;
        private SqlDatabaseTestActions ColumnCountKategorieData;
        private SqlDatabaseTestActions ColumnCountKundeData;
        private SqlDatabaseTestActions ColumnCountKunde_TischData;
        private SqlDatabaseTestActions ColumnCountMitarbeiterData;
        private SqlDatabaseTestActions ColumnCountMwSt_SatzData;
        private SqlDatabaseTestActions ColumnCountProdukt_KategorieData;
        private SqlDatabaseTestActions ColumnCountProdukt_ZusatzData;
        private SqlDatabaseTestActions ColumnCountRechnungData;
        private SqlDatabaseTestActions ColumnCountRolleData;
        private SqlDatabaseTestActions ColumnCountTischData;
        private SqlDatabaseTestActions ColumnCountZusatzData;
        private SqlDatabaseTestActions ContraintsForeignKeyCountData;
    }
}
