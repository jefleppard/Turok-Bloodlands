﻿/*
 * Mixer Unity SDK
 *
 * Copyright (c) Microsoft Corporation
 * All rights reserved.
 *
 * MIT License
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */
namespace Microsoft.Mixer
{
    /// <summary>
    /// Defines values used to indicate the interactive event types.
    /// </summary>
    public enum InteractiveEventType
    {
        /// <summary>
        /// A default value used all messages.
        /// </summary>
        Unknown,

        /// <summary>
        /// This event is triggered when the service or manager encounters an error.
        /// The Error and ErrorMessage members will contain pertinent info.
        /// </summary>
        Error,

        /// <summary>
        /// The interactivity state of the InteractivityManager has changed.
        /// </summary>
        InteractivityStateChanged,

        /// <summary>
        /// Event fired when a participant's state changes, e.g., joins, leaves,
        /// has input disabled, etc.
        /// </summary>
        ParticipantStateChanged,

        /// <summary>
        /// Events representing button input.
        /// </summary>
        Button,

        /// <summary>
        /// Events representing joystick input.
        /// </summary>
        Joystick
    }
}
