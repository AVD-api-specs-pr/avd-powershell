﻿using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Sql.Common;
using Microsoft.Azure.Commands.Sql.Database.Model;
using Microsoft.Azure.Commands.Sql.DataClassification.Model;
using Microsoft.Azure.Commands.Sql.DataClassification.Services;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Sql.DataClassification.Cmdlet
{
    [Cmdlet(
        VerbsCommon.Get,
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + DataClassificationCommon.SqlDatabaseSensitivityClassification),
        OutputType(typeof(SqlDatabaseSensitivityClassificationModel))]
    public class GetAzSqlDatabaseSensitivityClassification : AzureSqlDatabaseCmdletBase<SqlDatabaseSensitivityClassificationModel, DataClassificationAdapter>
    {
        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 0,
            HelpMessage = DataClassificationCommon.ResourceGroupNameHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.ColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 0,
            HelpMessage = DataClassificationCommon.ResourceGroupNameHelpMessage)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public override string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 1,
            HelpMessage = DataClassificationCommon.ServerNameHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.ColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 1,
            HelpMessage = DataClassificationCommon.ServerNameHelpMessage)]
        [ResourceNameCompleter("Microsoft.Sql/servers", "ResourceGroupName")]
        [ValidateNotNullOrEmpty]
        public override string ServerName { get; set; }

        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 2,
            HelpMessage = DataClassificationCommon.DatabaseNameHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.ColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 2,
            HelpMessage = DataClassificationCommon.DatabaseNameHelpMessage)]
        [ResourceNameCompleter("Microsoft.Sql/servers/databases", "ResourceGroupName", "ServerName")]
        [ValidateNotNullOrEmpty]
        public override string DatabaseName { get; set; }

        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseObjectParameterSet,
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = DataClassificationCommon.SqlDatabaseObjectHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseObjectColumnParameterSet,
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = DataClassificationCommon.SqlDatabaseObjectHelpMessage)]
        [ValidateNotNullOrEmpty]
        public AzureSqlDatabaseModel DatabaseObject { get; set; }

        [Parameter(
            ParameterSetName = DataClassificationCommon.ColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = DataClassificationCommon.SchemaNameHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseObjectColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = DataClassificationCommon.SchemaNameHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string SchemaName { get; set; }

        [Parameter(
            ParameterSetName = DataClassificationCommon.ColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = DataClassificationCommon.TableNameHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseObjectColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = DataClassificationCommon.TableNameHelpMessage)]
        public string TableName { get; set; }

        [Parameter(
            ParameterSetName = DataClassificationCommon.ColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = DataClassificationCommon.ColumnNameHelpMessage)]
        [Parameter(
            ParameterSetName = DataClassificationCommon.DatabaseObjectColumnParameterSet,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = DataClassificationCommon.ColumnNameHelpMessage)]
        [ValidateNotNullOrEmpty]
        public string ColumnName { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = DataClassificationCommon.AsJobHelpMessage)]
        public SwitchParameter AsJob { get; set; }

        protected override SqlDatabaseSensitivityClassificationModel GetEntity()
        {
            if (DatabaseObject != null)
            {
                ResourceGroupName = DatabaseObject.ResourceGroupName;
                ServerName = DatabaseObject.ServerName;
                DatabaseName = DatabaseObject.DatabaseName;
            }

            return new SqlDatabaseSensitivityClassificationModel()
            {
                ResourceGroupName = ResourceGroupName,
                ServerName = ServerName,
                DatabaseName = DatabaseName,
                SensitivityLabels = ParameterSetName == DataClassificationCommon.ColumnParameterSet ||
                    ParameterSetName == DataClassificationCommon.DatabaseObjectColumnParameterSet
                    ? ModelAdapter.GetCurrentSensitivityLabel(
                        ResourceGroupName, ServerName, DatabaseName, SchemaName, TableName, ColumnName)
                    : ModelAdapter.GetCurrentSensitivityLabels(ResourceGroupName, ServerName, DatabaseName)
            };
        }

        protected override DataClassificationAdapter InitModelAdapter()
        {
            return new DataClassificationAdapter(DefaultProfile.DefaultContext);
        }
    }
}
