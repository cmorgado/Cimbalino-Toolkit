﻿// ****************************************************************************
// <copyright file="ISmsComposeService.cs" company="Pedro Lamas">
// Copyright © Pedro Lamas 2014
// </copyright>
// ****************************************************************************
// <author>Pedro Lamas</author>
// <email>pedrolamas@gmail.com</email>
// <project>Cimbalino.Toolkit.Portable</project>
// <web>http://www.pedrolamas.com</web>
// <license>
// See license.txt in this solution or http://www.pedrolamas.com/license_MIT.txt
// </license>
// ****************************************************************************

namespace Cimbalino.Toolkit.Services
{
    /// <summary>
    /// Represents a service capable of launching the Messaging application with a new SMS message displayed.
    /// </summary>
    public interface ISmsComposeService
    {
        /// <summary>
        /// Shows the Messaging application, using the specified recipient list.
        /// </summary>
        /// <param name="recipient">The recipient.</param>
        void Show(string recipient);

        /// <summary>
        /// Shows the Messaging application, using the specified recipient list and message body.
        /// </summary>
        /// <param name="recipient">The recipient list for the new SMS message.</param>
        /// <param name="body">The body text of the new SMS message.</param>
        void Show(string recipient, string body);
    }
}