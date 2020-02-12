
// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  internal static partial class SdkInfo
  {
      public static IEnumerable<Tuple<string, string, string>> ApiInfo_PolicyClient
      {
          get
          {
              return new Tuple<string, string, string>[]
              {
                new Tuple<string, string, string>("Authorization", "PolicyAssignments", "2019-09-01"),
                new Tuple<string, string, string>("Authorization", "PolicyDefinitions", "2019-09-01"),
                new Tuple<string, string, string>("Authorization", "PolicySetDefinitions", "2019-09-01"),
                new Tuple<string, string, string>("Management", "PolicyDefinitions", "2019-09-01"),
                new Tuple<string, string, string>("Management", "PolicySetDefinitions", "2019-09-01"),
                new Tuple<string, string, string>("PolicyClient", "PolicyAssignments", "2019-09-01"),
              }.AsEnumerable();
          }
      }
      // BEGIN: Code Generation Metadata Section
      public static readonly String AutoRestVersion = "latest";
      public static readonly String AutoRestBootStrapperVersion = "autorest@2.0.4283";
      public static readonly String AutoRestCmdExecuted = "cmd.exe /c autorest.cmd https://github.com/Azure/azure-rest-api-specs/blob/master/specification/resources/resource-manager/readme.md --csharp --version=latest --reflect-api-versions --tag=package-policy-2019-09 --csharp.output-folder=C:\\code\\azure-sdk-for-net\\sdk\\resources\\Microsoft.Azure.Management.Resource\\src\\Generated";
      public static readonly String GithubForkName = "Azure";
      public static readonly String GithubBranchName = "master";
      public static readonly String GithubCommidId = "15ce9805b7d33225605476aadb8a6338ae26dda5";
      public static readonly String CodeGenerationErrors = "";
      public static readonly String GithubRepoName = "azure-rest-api-specs";
      // END: Code Generation Metadata Section
  }
}
