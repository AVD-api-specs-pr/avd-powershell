@{
  GUID = '2cba45aa-6788-45db-94bf-7aa7a2b8312a'
  RootModule = './Az.MachineLearningWorkspaces.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: MachineLearningWorkspaces cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.MachineLearningWorkspaces.private.dll'
  FormatsToProcess = './Az.MachineLearningWorkspaces.format.ps1xml'
  FunctionsToExport = 'Get-AzMLServiceQuota', 'Get-AzMLServiceUsage', 'Get-AzMLServiceVMSize', 'Get-AzMlWorkspace', 'Get-AzMlWorkspaceBatchDeployment', 'Get-AzMlWorkspaceBatchEndpoint', 'Get-AzMlWorkspaceCodeVersion', 'Get-AzMlWorkspaceComponentContainer', 'Get-AzMlWorkspaceComponentVersion', 'Get-AzMlWorkspaceCompute', 'Get-AzMlWorkspaceComputeKey', 'Get-AzMlWorkspaceComputeNode', 'Get-AzMlWorkspaceConnection', 'Get-AzMlWorkspaceDataContainer', 'Get-AzMlWorkspaceDatastore', 'Get-AzMlWorkspaceDatastoreSecret', 'Get-AzMlWorkspaceDataVersion', 'Get-AzMlWorkspaceEnvironmentContainer', 'Get-AzMlWorkspaceEnvironmentVersion', 'Get-AzMlWorkspaceFeature', 'Get-AzMlWorkspaceJob', 'Get-AzMlWorkspaceKey', 'Get-AzMlWorkspaceModelContainer', 'Get-AzMlWorkspaceModelVersion', 'Get-AzMlWorkspaceNotebookAccessToken', 'Get-AzMlWorkspaceNotebookKey', 'Get-AzMlWorkspaceOnlineDeployment', 'Get-AzMlWorkspaceOnlineDeploymentLog', 'Get-AzMlWorkspaceOnlineDeploymentSku', 'Get-AzMlWorkspaceOnlineEndpoint', 'Get-AzMlWorkspaceOnlineEndpointKey', 'Get-AzMlWorkspaceOnlineEndpointToken', 'Get-AzMlWorkspaceOutboundNetworkDependencyEndpoint', 'Get-AzMlWorkspaceStorageAccountKey', 'Invoke-AzMlWorkspaceDiagnose', 'Invoke-AzMlWorkspaceNotebook', 'New-AzMlWorkspace', 'New-AzMLWorkspaceAksObject', 'New-AzMLWorkspaceAmlComputeObject', 'New-AzMlWorkspaceBatchDeployment', 'New-AzMlWorkspaceBatchEndpoint', 'New-AzMlWorkspaceCodeVersion', 'New-AzMLWorkspaceCommandJobObject', 'New-AzMlWorkspaceComponentContainer', 'New-AzMlWorkspaceComponentVersion', 'New-AzMlWorkspaceCompute', 'New-AzMLWorkspaceComputeInstanceObject', 'New-AzMLWorkspaceComputeStartStopScheduleObject', 'New-AzMlWorkspaceConnection', 'New-AzMLWorkspaceCustomModelJobInputObject', 'New-AzMLWorkspaceCustomModelJobOutputObject', 'New-AzMLWorkspaceDatabricksObject', 'New-AzMlWorkspaceDataContainer', 'New-AzMLWorkspaceDataFactoryObject', 'New-AzMLWorkspaceDataLakeAnalyticsObject', 'New-AzMlWorkspaceDatastore', 'New-AzMLWorkspaceDatastoreBlobObject', 'New-AzMLWorkspaceDatastoreCredentialObject', 'New-AzMLWorkspaceDatastoreDataLakeGen1Object', 'New-AzMLWorkspaceDatastoreDataLakeGen2Object', 'New-AzMLWorkspaceDatastoreFileObject', 'New-AzMLWorkspaceDatastoreKeyCredentialObject', 'New-AzMLWorkspaceDatastoreNoneCredentialObject', 'New-AzMLWorkspaceDatastoreSasCredentialObject', 'New-AzMLWorkspaceDatastoreServicePrincipalCredentialObject', 'New-AzMlWorkspaceDataVersion', 'New-AzMlWorkspaceEnvironmentVersion', 'New-AzMLWorkspaceHDInsightObject', 'New-AzMlWorkspaceJob', 'New-AzMLWorkspaceJobServiceObject', 'New-AzMLWorkspaceKubernetesObject', 'New-AzMLWorkspaceLiteralJobInputObject', 'New-AzMLWorkspaceMLFlowModelJobInputObject', 'New-AzMLWorkspaceMLFlowModelJobOutputObject', 'New-AzMLWorkspaceMLTableJobInputObject', 'New-AzMLWorkspaceMLTableJobOutputObject', 'New-AzMlWorkspaceModelContainer', 'New-AzMlWorkspaceModelVersion', 'New-AzMlWorkspaceOnlineDeployment', 'New-AzMlWorkspaceOnlineEndpoint', 'New-AzMlWorkspaceOnlineEndpointKey', 'New-AzMLWorkspacePipelineJobObject', 'New-AzMLWorkspaceQuotaPropertiesObject', 'New-AzMLWorkspaceSharedPrivateLinkResourceObject', 'New-AzMLWorkspaceSweepJobObject', 'New-AzMLWorkspaceSynapseSparkObject', 'New-AzMLWorkspaceTritonModelJobInputObject', 'New-AzMLWorkspaceTritonModelJobOutputObject', 'New-AzMLWorkspaceUriFileJobInputObject', 'New-AzMLWorkspaceUriFileJobOutputObject', 'New-AzMLWorkspaceUriFolderJobInputObject', 'New-AzMLWorkspaceUriFolderJobOutputObject', 'New-AzMLWorkspaceVirtualMachineObject', 'Remove-AzMlWorkspace', 'Remove-AzMlWorkspaceBatchDeployment', 'Remove-AzMlWorkspaceBatchEndpoint', 'Remove-AzMlWorkspaceCodeVersion', 'Remove-AzMlWorkspaceComponentContainer', 'Remove-AzMlWorkspaceComponentVersion', 'Remove-AzMlWorkspaceCompute', 'Remove-AzMlWorkspaceConnection', 'Remove-AzMlWorkspaceDataContainer', 'Remove-AzMlWorkspaceDatastore', 'Remove-AzMlWorkspaceDataVersion', 'Remove-AzMlWorkspaceEnvironmentContainer', 'Remove-AzMlWorkspaceEnvironmentVersion', 'Remove-AzMlWorkspaceJob', 'Remove-AzMlWorkspaceModelContainer', 'Remove-AzMlWorkspaceModelVersion', 'Remove-AzMlWorkspaceOnlineDeployment', 'Remove-AzMlWorkspaceOnlineEndpoint', 'Restart-AzMlWorkspaceCompute', 'Start-AzMlWorkspaceCompute', 'Stop-AzMlWorkspaceCompute', 'Stop-AzMlWorkspaceJob', 'Sync-AzMlWorkspaceKey', 'Update-AzMLServiceQuota', 'Update-AzMlWorkspace', 'Update-AzMlWorkspaceBatchDeployment', 'Update-AzMlWorkspaceBatchEndpoint', 'Update-AzMlWorkspaceCompute', 'Update-AzMlWorkspaceOnlineDeployment', 'Update-AzMlWorkspaceOnlineEndpoint', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'MachineLearningWorkspaces'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
    }
  }
}
