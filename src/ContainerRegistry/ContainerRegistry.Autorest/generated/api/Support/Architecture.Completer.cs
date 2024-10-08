// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The OS architecture.</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ArchitectureTypeConverter))]
    public partial struct Architecture :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "amd64".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'amd64'", "amd64", global::System.Management.Automation.CompletionResultType.ParameterValue, "amd64");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "x86".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'x86'", "x86", global::System.Management.Automation.CompletionResultType.ParameterValue, "x86");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "386".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'386'", "386", global::System.Management.Automation.CompletionResultType.ParameterValue, "386");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "arm".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'arm'", "arm", global::System.Management.Automation.CompletionResultType.ParameterValue, "arm");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "arm64".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'arm64'", "arm64", global::System.Management.Automation.CompletionResultType.ParameterValue, "arm64");
            }
        }
    }
}