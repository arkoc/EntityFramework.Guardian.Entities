// Copyright (c) Aram Kocharyan. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace EntityFramework.Guardian.Entities
{
    /// <summary>
    /// Entity interfce presenting permission linked to entitytype
    /// </summary>
    public interface IPermission
    {
        /// <summary>
        /// Gets the name of the Resource.
        /// </summary>
        /// <value>
        /// The name of the Resource.
        /// </value>
        string Resource { get; }

        /// <summary>
        /// Gets the type of the access.
        /// </summary>
        /// <value>
        /// The type of the access.
        /// </value>
        ActionTypes ActionType { get; }
    }
}
