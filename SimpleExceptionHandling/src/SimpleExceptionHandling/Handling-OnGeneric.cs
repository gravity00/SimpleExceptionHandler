﻿#region License
// The MIT License (MIT)
// 
// Copyright (c) 2016 João Simões
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion
namespace SimpleExceptionHandling
{
    using System;
    
    public static partial class Handling
    {
        #region On

        #region Generic

        /// <summary>
        /// Adds the given exception handler to this configuration. If this handler matches
        /// a given exception on <see cref="IHandlingConfiguration.Catch"/>, it will be considered successfully handled.
        /// </summary>
        /// <typeparam name="TException">The exception type</typeparam>
        /// <typeparam name="TParameter">The parameter type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="handler">The handler to be added</param>
        /// <param name="condition">An optional condition to be checked if the handler must be used</param>
        /// <returns>The configuration after changes</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHandlingConfiguration<TParameter, TResult> On<TException, TParameter, TResult>(
            Action<TException, IHandlingInput<TParameter>> handler,
            Func<TException, IHandlingInput<TParameter>, bool> condition = null) where TException : Exception
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return new HandlingConfiguration<TParameter, TResult>().On(handler, condition);
        }

        /// <summary>
        /// Adds the given exception handler to this configuration. If this handler matches
        /// a given exception on <see cref="IHandlingConfiguration.Catch"/> and true is returned, it will be considered successfully handled.
        /// </summary>
        /// <typeparam name="TException">The exception type</typeparam>
        /// <typeparam name="TParameter">The parameter type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="handler">The handler to be added</param>
        /// <param name="condition">An optional condition to be checked if the handler must be used</param>
        /// <returns>The configuration after changes</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHandlingConfiguration<TParameter, TResult> On<TException, TParameter, TResult>(
            Func<TException, IHandlingInput<TParameter>, bool> handler,
            Func<TException, IHandlingInput<TParameter>, bool> condition = null) where TException : Exception
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return new HandlingConfiguration<TParameter, TResult>().On(handler, condition);
        }

        /// <summary>
        /// Adds the given exception handler to this configuration. If this handler matches
        /// a given exception on <see cref="IHandlingConfiguration.Catch"/> and <see cref="IHandlingResult.Handled"/> is true, 
        /// it will be considered successfully handled.
        /// </summary>
        /// <typeparam name="TException">The exception type</typeparam>
        /// <typeparam name="TParameter">The parameter type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="handler">The handler to be added</param>
        /// <param name="condition">An optional condition to be checked if the handler must be used</param>
        /// <returns>The configuration after changes</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHandlingConfiguration<TParameter, TResult> On<TException, TParameter, TResult>(
            Func<TException, IHandlingInput<TParameter>, IHandlingResult<TResult>> handler,
            Func<TException, IHandlingInput<TParameter>, bool> condition = null) where TException : Exception
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return new HandlingConfiguration<TParameter, TResult>().On(handler, condition);
        }

        /// <summary>
        /// Adds the given exception handler to this configuration. If this handler matches
        /// a given exception on <see cref="IHandlingConfiguration.Catch"/>, it will be considered successfully handled.
        /// </summary>
        /// <typeparam name="TException">The exception type</typeparam>
        /// <typeparam name="TParameter">The parameter type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="handler">The handler to be added</param>
        /// <param name="condition">An optional condition to be checked if the handler must be used</param>
        /// <returns>The configuration after changes</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHandlingConfiguration<TParameter, TResult> On<TException, TParameter, TResult>(
            Action<TException> handler, Func<TException, IHandlingInput<TParameter>, bool> condition = null)
            where TException : Exception
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return new HandlingConfiguration<TParameter, TResult>().On(handler, condition);
        }

        /// <summary>
        /// Adds the given exception handler to this configuration. If this handler matches
        /// a given exception on <see cref="IHandlingConfiguration.Catch"/> and true is returned, it will be considered successfully handled.
        /// </summary>
        /// <typeparam name="TException">The exception type</typeparam>
        /// <typeparam name="TParameter">The parameter type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="handler">The handler to be added</param>
        /// <param name="condition">An optional condition to be checked if the handler must be used</param>
        /// <returns>The configuration after changes</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHandlingConfiguration<TParameter, TResult> On<TException, TParameter, TResult>(
            Func<TException, bool> handler,
            Func<TException, IHandlingInput<TParameter>, bool> condition = null)
            where TException : Exception
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return new HandlingConfiguration<TParameter, TResult>().On(handler, condition);
        }

        /// <summary>
        /// Adds the given exception handler to this configuration. If this handler matches
        /// a given exception on <see cref="IHandlingConfiguration.Catch"/> and <see cref="IHandlingResult.Handled"/> is true, 
        /// it will be considered successfully handled.
        /// </summary>
        /// <typeparam name="TException">The exception type</typeparam>
        /// <typeparam name="TParameter">The parameter type</typeparam>
        /// <typeparam name="TResult">The result type</typeparam>
        /// <param name="handler">The handler to be added</param>
        /// <param name="condition">An optional condition to be checked if the handler must be used</param>
        /// <returns>The configuration after changes</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHandlingConfiguration<TParameter, TResult> On<TException, TParameter, TResult>(
            Func<TException, IHandlingResult<TResult>> handler, 
            Func<TException, IHandlingInput<TParameter>, bool> condition = null) where TException : Exception
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            return new HandlingConfiguration<TParameter, TResult>().On(handler, condition);
        }

        #endregion

        #endregion
    }
}
