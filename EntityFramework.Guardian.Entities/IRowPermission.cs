// Copyright (c) Aram Kocharyan. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace EntityFramework.Guardian.Entities
{
    /// <summary>
    /// Entity interfce presenting permission linked to entitytype and row identifier
    /// </summary>
    public interface IRowPermission : IPermission
    {
        /// <summary>
        /// Gets the row identifier.
        /// </summary>
        /// <value>
        /// The row identifier.
        /// </value>
        string RowIdentifier { get; }
    }
}
