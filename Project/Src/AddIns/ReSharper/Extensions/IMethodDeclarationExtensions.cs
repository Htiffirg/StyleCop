﻿//-----------------------------------------------------------------------
// <copyright file="">
//   MS-PL
// </copyright>
// <license>
//   This source code is subject to terms and conditions of the Microsoft 
//   Public License. A copy of the license can be found in the License.html 
//   file at the root of this distribution. If you cannot locate the  
//   Microsoft Public License, please send an email to dlr@microsoft.com. 
//   By using this source code in any fashion, you are agreeing to be bound 
//   by the terms of the Microsoft Public License. You must not remove this 
//   notice, or any other, from this software.
// </license>
//-----------------------------------------------------------------------

namespace JetBrains.ReSharper.Psi.CSharp.Tree.Extensions
{
    using Impl;

    /// <summary>
    /// I method declaration extensions.
    /// </summary>
    public static class IMethodDeclarationExtensions
    {
        #region Public Methods

        /// <summary>
        /// Get return type.
        /// </summary>
        /// <param name="declaration">
        /// The declaration.
        /// </param>
        /// <returns>
        /// </returns>
        public static IType GetReturnType(this IMethodDeclaration declaration)
        {
            var methodDeclarationNode = declaration as IMethodDeclarationNode;

            if (methodDeclarationNode == null)
            {
                return null;
            }

            var typeUsage = methodDeclarationNode.TypeUsage;

            if (typeUsage == null)
            {
                return null;
            }

            return CSharpTypeFactory.CreateType(typeUsage);
        }

        /// <summary>
        /// Indicates whether this method is declared with the new keyword.
        /// </summary>
        /// <param name="declaration">
        /// The method to check.
        /// </param>
        /// <returns>
        /// <c>true</c> if the declaration is declared with new otherwise <c>false</c>
        /// </returns>
        public static bool IsNew(this IMethodDeclaration declaration)
        {
            return declaration != null && ModifiersUtil.GetNew(declaration as IModifiersListOwnerNode);
        }

        #endregion
    }
}